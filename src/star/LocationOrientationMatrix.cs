using OpenTK;
using System;

namespace star
{
    public class LocationOrientationMatrix
    {
        public static Matrix4d GetModelView(Location location, Matrix4d orientation)
        {
            // 1. Calculate position in 3D cartesian world
            // 2. Find "up"
            // 3. Orient to face the north pole
            // 4. Apply the device orientation

            //
            // 1. Calculate position in 3D cartesian world
            //
            var pos = location.Position;

            //
            // 2. Find "up"
            //
            var up = location.OffsetAltitude(100).Position - pos;
            up.Normalize();

            //
            // 3. Orient to face the north pole
            //
            var northPos = new Location(location.Latitude + 0.1, location.Longitude, location.Altitude).Position;

            var northZAxis = (pos - northPos);
            northZAxis.Normalize();

            var northYAxis = up;
            var northXAxis = Vector3d.Cross(northYAxis, northZAxis);

            northXAxis.Normalize();
            northZAxis = Vector3d.Cross(northXAxis, northYAxis);
            northZAxis.Normalize();

            northYAxis = Vector3d.Cross(northZAxis, northXAxis);
            northYAxis.Normalize();

            var lookNorthI = new Matrix4d(
                new Vector4d(northXAxis),
                new Vector4d(northYAxis),
                new Vector4d(northZAxis),
                Vector4d.UnitW);

            //
            // 4. Apply the device orientation
            //
            var newOrient = new Matrix4d(
                -orientation.Column1,
                orientation.Column2,
                -orientation.Column0,
                Vector4d.UnitW);

            var newOrientI = newOrient;
            newOrientI.Transpose();

            var modelViewI = (newOrientI * lookNorthI);
            modelViewI.Row3 = new Vector4d(pos.X, pos.Y, pos.Z, 1);
            var modelView = modelViewI;
            try
            {
                modelView.Invert();
                return modelView;
            }
            // if cannot invert?
            catch (InvalidOperationException)
            {
                var lookNorth = lookNorthI;
                lookNorth.Invert();
                return lookNorth;
            }
        }
    }
}

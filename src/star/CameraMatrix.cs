using OpenTK;

namespace star
{
    public static class CameraMatrix
    {
        // todo: check the camera rotation matrix for android/iphone
        public static Matrix4d GetCameraMatrix(Matrix3d rotationMatrix)
        {
            var res = new Matrix4d();
            res[0, 0] = rotationMatrix[0, 0];
            res[0, 1] = rotationMatrix[1, 0];
            res[0, 2] = rotationMatrix[2, 0];
            res[0, 3] = 0;


            res[1, 0] = rotationMatrix[0, 1];
            res[1, 1] = rotationMatrix[1, 1];
            res[1, 2] = rotationMatrix[2, 1];
            res[1, 3] = 0;

            res[2, 0] = rotationMatrix[0, 2];
            res[2, 1] = rotationMatrix[1, 2];
            res[2, 2] = rotationMatrix[2, 2];
            res[2, 3] = 0;

            res[3, 0] = 0;
            res[3, 1] = 0;
            res[3, 2] = 0;
            res[3, 3] = 1;
            return res;
        }
    }
}


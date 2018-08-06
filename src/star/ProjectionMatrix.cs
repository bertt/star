using OpenTK;
using System;

namespace star
{
    public static class ProjectionMatrix
    {
        const double DEGREES_TO_RADIANS = Math.PI / 180.0;
        // VideoCamera videoCamera (videoCamera.FieldOfView), UIImage frame.Size.Height, frame.Size.Height
        public static Matrix4d GetProjectionMatrix(double aspect, float zNear, float zFar)
        {
            var fov = 60;
            // Aspect is height/widht (in portrait mode only?)
            return Matrix4d.CreatePerspectiveFieldOfView(
                fovy: fov * Math.PI / 180,
                aspect: aspect,
                zNear: zNear,
                zFar: zFar);
        }
    }
}

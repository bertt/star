using OpenTK;
using System;

namespace star
{
    public static class ProjectionMatrix
    {
        // VideoCamera videoCamera (videoCamera.FieldOfView), UIImage frame.Size.Height, frame.Size.Height
        public static Matrix4d GetProjectionMatrix(double fov, double width, double height)
        {
            // Aspect is inverted because we rotate the image
            // What are 0.01 and 4700?
            return Matrix4d.CreatePerspectiveFieldOfView(
                fovy: fov * Math.PI / 180,
                aspect: height / width,
                zNear: 0.01,
                zFar: 4700);
        }

    }
}

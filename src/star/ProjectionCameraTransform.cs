using OpenTK;

namespace star
{
    public static class ProjectionCameraTransform
    {
        public static Matrix4d GetProjectionCameraMatrix(Matrix4d projectionTransform, Matrix4d cameraTransform)
        {
            return Matrix4d.Mult(projectionTransform, cameraTransform);
        }
    }
}

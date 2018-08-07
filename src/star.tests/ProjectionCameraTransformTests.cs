using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class ProjectionCameraTransformTests
    {
        [Test]
        public void ProjectionCameraTest()
        {
            var projectionMatrix = ProjectionMatrix.GetProjectionMatrix(50 / 10f, 0.25f, 1000);


        }
    }
}

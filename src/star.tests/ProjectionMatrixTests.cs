using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class ProjectionMatrixTests
    {
        [Test]
        public void TestProjectionMatrix()
        {
            var projectionMatrix = ProjectionMatrix.GetProjectionMatrix(10, 50, 100);

            // Result:
            //    {
            //    (5.71502615138067, 0, 0, 0)
            //    (0, 11.4300523027613, 0, 0)
            //    (0, 0, -1.0000042553282, -1)
            //    (0, 0, -0.020000042553282, 0)
            //    }

            Assert.IsTrue(projectionMatrix.M11 == 5.7150261513806715);
            Assert.IsTrue(projectionMatrix.M22 == 11.430052302761343);
            Assert.IsTrue(projectionMatrix.M33 == -1.0000042553282029);
            Assert.IsTrue(projectionMatrix.M43 == -0.02000004255328203);
            Assert.IsTrue(projectionMatrix.M41 == 0);
            Assert.IsTrue(true);

        }
    }
}

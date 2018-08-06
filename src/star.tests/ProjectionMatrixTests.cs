using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class ProjectionMatrixTests
    {
        [Test]
        public void TestProjectionMatrix()
        {
            var projectionMatrix = ProjectionMatrix.GetProjectionMatrix(50/10f, 0.25f,1000);

            // Result:
            //    {
            //    (0.34641016151377546, 0, 0, 0)
            //    (0, .7320508075688774, 0, 0)
            //    (0, 0, -1.0005001250312577, -1)
            //    (0, 0, -0.50012503125781449, 0)
            //    }

            Assert.IsTrue(projectionMatrix.M11 == 0.34641016151377546);
            Assert.IsTrue(projectionMatrix.M22 == 1.7320508075688774);
            Assert.IsTrue(projectionMatrix.M33 == -1.0005001250312577);
            Assert.IsTrue(projectionMatrix.M43 == -0.50012503125781449);
            Assert.IsTrue(projectionMatrix.M41 == 0);
            Assert.IsTrue(true);

        }
    }
}

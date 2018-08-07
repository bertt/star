using NUnit.Framework;
using OpenTK;

namespace star.tests
{
    [TestFixture]
    public class CameraMatrixTests
    {
        [Test]
        public void CameraMatrixTest()
        {
            var m3 = new Matrix3d();
            var res = CameraMatrix.GetCameraMatrix(m3);
            Assert.IsTrue(res != null);
        }
    }
}

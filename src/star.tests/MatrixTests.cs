using NUnit.Framework;
using OpenTK;

namespace star.tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void TestCross()
        {
            var v1 = new Vector3d(3,-3,1);
            var v2 = new Vector3d(4, 9, 2);
            var v3 = Vector3d.Cross(v1, v2);

            Assert.IsTrue(v3 != null);
            Assert.IsTrue(v3.X==-15);
            Assert.IsTrue(v3.Y == -2);
            Assert.IsTrue(v3.Z == 39);
        }
    }
}

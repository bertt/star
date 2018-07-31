using NUnit.Framework;
using OpenTK;

namespace star.tests
{
    [TestFixture]
    public class LocationOrientationMatrixTests
    {
        [Test]
        public void FirstTest()
        {
            var locationPK = new Location(4.911608, 52.340395);
            var orientation = new Matrix4d();
            var result = LocationOrientationMatrix.GetModelView(locationPK, orientation);
        }
    }
}

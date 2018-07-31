using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class LocationTests
    {
        private Location locationPK = new Location(4.911608, 52.340395);

        [Test]
        public void CreateLocationTest()
        {
            var loc = new Location(10,5,0);
            Assert.IsTrue(loc.Latitude == 10);
            Assert.IsTrue(loc.Longitude == 5);
        }

        [Test]
        public void LocationPositionTest()
        {
            var position = locationPK.Position;

            // 3882535.00983891, 5030739.61321056, 546088.300751991
            Assert.IsTrue(position.X == 3882535.0098389126);
            Assert.IsTrue(position.Y == 5030739.6132105617);
            Assert.IsTrue(position.Z == 546088.30075199076);
        }

        [Test]
        // ECEF: earth-centered, earth-fixed
        public void LocationEcefPositionTest()
        {
            var positionEcef = locationPK.EcefPosition;

            Assert.IsTrue(positionEcef.X == 45499319.920485817);
            Assert.IsTrue(positionEcef.Y == 58955097.769388907);
            Assert.IsTrue(positionEcef.Z == 6356752.31424518);
        }

        [Test]
        public void OffsetAltitudeTest()
        {
            Assert.IsTrue(locationPK.OffsetAltitude(10).Altitude == 10);
        }

        [Test]
        public void ToStringTests()
        {
            var locationString = locationPK.ToString();

            Assert.IsTrue(locationString == "[Lat=4.911608, Lon=52.340395, Alt=0]");
        }
    }
}
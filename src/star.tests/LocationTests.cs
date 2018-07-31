using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class LocationTests
    {
        private Location locationPK = new Location(52.340395, 4.911608);

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

            Assert.IsTrue(position.X == 3882535.0098389131);
            Assert.IsTrue(position.Y == 333643.05321155547);
            Assert.IsTrue(position.Z == 5049280.7211708706);
        }

        [Test]
        // ECEF: earth-centered, earth-fixed
        public void LocationEcefPositionTest()
        {
            var positionEcef = locationPK.EcefPosition;
            Assert.IsTrue(positionEcef.X == 4920828.86114275);
            Assert.IsTrue(positionEcef.Y == 422868.14192342);
            Assert.IsTrue(positionEcef.Z == 6356752.3142451793);
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

            Assert.IsTrue(locationString == "[Lat=52.340395, Lon=4.911608, Alt=0]");
        }
    }
}




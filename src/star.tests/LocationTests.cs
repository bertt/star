using NUnit.Framework;

namespace star.tests
{
    [TestFixture]
    public class LocationTests
    {
        private Location locationPK = new Location(52.340395, 4.911608);
        // 52.342327, 4.913019

        [Test]
        public void CreateLocationTest()
        {
            var loc = new Location(10,5,0);
            Assert.IsTrue(loc.Latitude == 10);
            Assert.IsTrue(loc.Longitude == 5);
        }

        [Test]
        // ECEF: earth-centered, earth-fixed
        public void LocationEcefPositionTest()
        {
            var positionEcef = locationPK.EcefPosition;

            Assert.IsTrue(positionEcef.X == 3890705.2774487687);
            Assert.IsTrue(positionEcef.Y == 334345.15970228892);
            Assert.IsTrue(positionEcef.Z == 5059907.0330199348);
        }

        [Test]
        // ECEF: earth-centered, earth-fixed
        public void LocationEnuPositionTest()
        {
            // 52.341362, 4.912569
            var myposition = new OpenTK.Vector3d(52.341362, 4.912569, 0);
            var enu = locationPK.EnuPosition(myposition);

            Assert.IsTrue(enu.X == 0.41312640806427225);
            Assert.IsTrue(enu.Y == -42.097533230204135);
            Assert.IsTrue(enu.Z == -6391527.4270682726);
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




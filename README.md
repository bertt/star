# Star

.NET Standard 2.0 Library for handling augmented reality and locations (longitude, latitude)

Dependencies: OpenTK

Sample code calculating ECEF (earth-centered, earth-fixed) from longitude, latitude:

```
var locationPK = new Location(4.911608, 52.340395);
var positionEcef = locationPK.EcefPosition;
Assert.IsTrue(positionEcef.X == 45499319.920485817);
Assert.IsTrue(positionEcef.Y == 58955097.769388907);
Assert.IsTrue(positionEcef.Z == 6356752.31424518);

```
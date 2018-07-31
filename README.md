# Star

.NET Standard 2.0 Library for handling augmented reality and locations (longitude, latitude)

Dependencies: OpenTK

Sample code calculating ECEF (earth-centered, earth-fixed) from longitude, latitude:

```
var locationPK = new Location(52.340395, 4.911608);;
var positionEcef = locationPK.EcefPosition;
Assert.IsTrue(positionEcef.X == 4920828.86114275);
Assert.IsTrue(positionEcef.Y == 422868.14192342);
Assert.IsTrue(positionEcef.Z == 6356752.3142451793);

```
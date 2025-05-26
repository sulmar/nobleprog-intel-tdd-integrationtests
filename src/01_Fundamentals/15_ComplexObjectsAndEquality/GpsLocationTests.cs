namespace ComplexObjectsAndEquality;

using Xunit;

public class GpsLocationTests
{
    [Fact(Skip = "Do poprawy")]
    public void TwoLocations_WithSameCoordinates_ShouldBeEqual()
    {
        var loc1 = new GpsLocation(52.2297, 21.0122);
        var loc2 = new GpsLocation(52.2297, 21.0122);

        Assert.Equal(loc1, loc2);
        Assert.True(loc1.Equals(loc2));
    }

    [Fact]
    public void TwoLocations_WithDifferentCoordinates_ShouldNotBeEqual()
    {
        var loc1 = new GpsLocation(52.2297, 21.0122);
        var loc2 = new GpsLocation(50.0647, 19.9450);

        Assert.NotEqual(loc1, loc2);
        Assert.False(loc1.Equals(loc2));
    }

    [Fact]
    public void Locations_WithSameReference_ShouldBeEqual()
    {
        var loc = new GpsLocation(52.2297, 21.0122);

        Assert.Equal(loc, loc);
    }

    [Fact(Skip = "Do poprawy")]
    public void TwoLocations_WithSmallDifference_ShouldBeEqual_WithToleranceToPrecision6()
    {
        var loc1 = new GpsLocation(52.2297001, 21.0122001);
        var loc2 = new GpsLocation(52.2297000, 21.0122000);

        Assert.Equal(loc1.Latitude, loc2.Latitude);
        Assert.Equal(loc1.Longitude, loc2.Longitude);
    }
}

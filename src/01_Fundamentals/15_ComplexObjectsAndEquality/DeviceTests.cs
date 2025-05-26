using Xunit;
using ComplexObjectsAndEquality;

public class DeviceTests
{
    [Fact(Skip = "Do poprawy")]
    public void Devices_WithSameData_ShouldBeEqual()
    {
        var device1 = new Device(
            "dev-001",
            new GpsLocation(52.2297, 21.0122),
            DeviceStatus.Online);

        var device2 = new Device(
            "dev-001",
            new GpsLocation(52.2297, 21.0122),
            DeviceStatus.Online);

        // Porównanie całych obiektów złożonych
        Assert.Equal(device1, device2);
    }

    [Fact]
    public void Devices_WithDifferentStatus_ShouldNotBeEqual()
    {
        var device1 = new Device(
            "dev-001",
            new GpsLocation(52.2297, 21.0122),
            DeviceStatus.Online);

        var device2 = new Device(
            "dev-001",
            new GpsLocation(52.2297, 21.0122),
            DeviceStatus.Offline);

        Assert.NotEqual(device1, device2);
    }
}

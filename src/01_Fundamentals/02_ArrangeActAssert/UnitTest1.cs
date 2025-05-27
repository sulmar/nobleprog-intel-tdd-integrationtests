namespace ArrangeActAssert;

public class WaterLevelSensorTests
{
    private readonly Battery battery;
    private const Battery NoBattery = null;
    public WaterLevelSensorTests()
    {
        battery = new Battery();
    }
    
    [Fact]
    public void WaterLevelSensor_WhenHasChargedBattery_ReturnsIsEnableSetTrue()
    {
        // Arrange
        battery.Level = 1;
        
        // Act
        var sensor = new WaterLevelSensor(battery);
        
        // Assert
        Assert.True(sensor.IsEnabled);
    }
    
    [Fact]
    public void WaterLevelSensor_WhenHasDischargedBattery_ReturnsIsEnableSetFalse()
    {
        // Arrange
        battery.Level = 0;
        
        // Act
        var sensor = new WaterLevelSensor(battery);
        
        // Assert
        Assert.False(sensor.IsEnabled);
    }
    
    [Fact]
    public void WaterLevelSensor_WhenHasNoBattery_ReturnsIsEnableSetFalse()
    {
        // Arrange
        
        // Act
        var sensor = new WaterLevelSensor(NoBattery);
        
        // Assert
        Assert.False(sensor.IsEnabled);
    }
}

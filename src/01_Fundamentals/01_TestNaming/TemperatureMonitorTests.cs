namespace TestNaming;

public class TemperatureMonitorTests
{
    // Method_Scenario_ExpectedBehavior
    
    private const double WaterBoilingTemperature = 100; // in Celsius
    
    private TemperatureMonitor monitor;

    public TemperatureMonitorTests()
    {
        // Arrange
         monitor = new TemperatureMonitor(WaterBoilingTemperature);
    }
    
    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsBelowThreshlod_ReturnsFalse()
    {
        // Act
        var result = monitor.IsAlertTriggered(50);
        
        // Assert
        Assert.False(result);
        Assert.False(monitor.IsAlarm);
    }

    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsAboveThreshlod_ReturnsTrue()
    {
        // Act & Assert
        Assert.True(monitor.IsAlertTriggered(120));
        Assert.True(monitor.IsAlarm);
        
    }

    [Fact]
    public void IsAlertTrigger_CurrentTemperaturIsEqualThreshlod_ReturnsFalse()
    {
        // Act
        var result = monitor.IsAlertTriggered(100);
        
        // Assert
        Assert.False(result);
        Assert.False(monitor.IsAlarm);
    }
}

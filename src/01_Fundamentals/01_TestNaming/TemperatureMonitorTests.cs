namespace TestNaming;

public class TemperatureMonitorTests
{
    // Method_Scenario_ExpectedBehavior
    
    private const double WaterBoilingTemperature = 100; // in Celsius
    
    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsBelowThreshlod_ReturnsFalse()
    {
        // Arrange
        var monitor = new TemperatureMonitor(WaterBoilingTemperature);
        
        // Act
        var result = monitor.IsAlertTriggered(50);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsAboveThreshlod_ReturnsTrue()
    {
        // Arrange
        var monitor = new TemperatureMonitor(WaterBoilingTemperature);
        
        // Act
        var result = monitor.IsAlertTriggered(120);
        
        // Assert
        Assert.True(result);
        
    }

    [Fact]
    public void IsAlertTrigger_CurrentTemperaturIsEqualThreshlod_ReturnsFalse()
    {
        // Arrange
        var monitor = new TemperatureMonitor(WaterBoilingTemperature);
        
        // Act
        var result = monitor.IsAlertTriggered(100);
        
        // Assert
        Assert.False(result);
    }
}

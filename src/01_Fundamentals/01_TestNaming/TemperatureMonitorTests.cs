namespace TestNaming;

public class TemperatureMonitorTests
{
    // Method_Scenario_ExpectedBehavior
    
    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsBelowThreshlod_ReturnsFalse()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void IsAlertTriggered_CurrentTemperaturIsAboveThreshlod_ReturnsTrue()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void IsAlertTrigger_CurrentTemperaturIsEqualThreshlod_ReturnsFalse()
    {
        var monitor = new TemperatureMonitor(10d);

        throw new NotImplementedException();

    }
}

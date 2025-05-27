namespace ArrangeActAssert;

public class Battery
{
    public double Level { get; set; }
    public double Capacity { get; set; }
}

public class WaterLevelSensor
{
    private Battery _battery;
    public bool IsEnabled { get; }
    public int MaxSafeWaterLevel { get; }

    public WaterLevelSensor(Battery battery, int maxSafeWaterLevel = 100)
    {
        _battery = battery;
        
        MaxSafeWaterLevel = maxSafeWaterLevel;
        
        if (_battery is not null && _battery.Level > 0)
           IsEnabled = true;
    }

    public bool IsFloodRisk(int currentWaterLevel)
    {
        return currentWaterLevel > MaxSafeWaterLevel;
    }
}

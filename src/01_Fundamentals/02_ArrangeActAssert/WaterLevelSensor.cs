namespace ArrangeActAssert;

public class WaterLevelSensor
{
    public bool IsEnabled { get; }
    public int MaxSafeWaterLevel { get; }

    public WaterLevelSensor(int maxSafeWaterLevel = 100)
    {
        IsEnabled = true;
        MaxSafeWaterLevel = maxSafeWaterLevel;
    }

    public bool IsFloodRisk(int currentWaterLevel)
    {
        return currentWaterLevel > MaxSafeWaterLevel;
    }
}

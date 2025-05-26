namespace TestingCollections;

public class SensorLog
{
    private readonly List<int> _readings = new();

    public void AddReading(int value)
    {
        _readings.Add(value);
    }

    public IReadOnlyList<int> GetReadings()
    {
        return _readings.AsReadOnly();
    }

    public bool ContainsReading(int value)
    {
        return _readings.Contains(value);
    }

    public int Count => _readings.Count;
}

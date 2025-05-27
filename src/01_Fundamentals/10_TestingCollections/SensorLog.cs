namespace TestingCollections;

public class SensorLog
{
    private readonly List<int> _measures = new();
    public DateTime? StartedAt { get; set; }

    public void AddMeasure(int value)
    {
        if (_measures.Count == 0)
        {
            StartedAt = DateTime.UtcNow;
        }
        
        _measures.Add(value);
    }

    public bool ContainsReading(int value)
    {
        return _measures.Contains(value);
    }

    public int Count => _measures.Count;
}

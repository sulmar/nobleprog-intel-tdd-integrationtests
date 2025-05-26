using System.Threading;

namespace AsyncTesting;

public class SensorDataService
{
    private readonly List<int> _data = new();

    public async Task PollSensorDataAsync(int probeCount, CancellationToken cancellationToken = default)
    {
        for (int probe = 0; probe < probeCount; probe++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // Symulacja pojedynczego pomiaru
            await Task.Delay(100, cancellationToken);

            var data = 10 + probe * 5;

            _data.Add(data);

            Console.WriteLine($"Probe: {probe}");
        }
    }

    public async Task<double> GetAverageAsync()
    {
        await Task.Delay(50);

        if (_data.Count == 0)
            throw new InvalidOperationException("No data loaded.");

        return _data.Average();
    }
}

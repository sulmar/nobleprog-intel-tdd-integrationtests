using System;
using System.Collections.Generic;
using System.Linq;
namespace TestNaming;

/// <summary>
/// Komponent, który monitoruje temperaturę, i generuje alert, gdy temperatura przekracza dozwolony próg.
/// </summary>
public class TemperatureMonitor
{
    private readonly double _threshold;

    public TemperatureMonitor(double threshold)
    {
        _threshold = threshold;
    }

    public bool IsAlertTriggered(double currentTemperature)
    {
        return currentTemperature > _threshold;
    }
}
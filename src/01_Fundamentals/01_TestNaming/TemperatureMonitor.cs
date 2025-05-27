using System;
using System.Collections.Generic;
using System.Linq;
namespace TestNaming;

/// <summary>
/// Komponent, który monitoruje temperaturę, i generuje alert, gdy temperatura przekracza dozwolony próg.
/// </summary>
public class TemperatureMonitor(double _threshold)
{
    public bool IsAlarm { get; private set; }
    public bool IsAlertTriggered(double currentTemperature)
    {
        var result = currentTemperature > _threshold;
        
        if (result)
            IsAlarm = true;
        
        return result;
    }
}
namespace BoundaryTesting;


/*
| Zakres          | Oczekiwany wynik | 
| --------------- | ---------------- | 
| `< 30`          | Green (🟢)       | 
| `30 <= T <= 60` | Orange (🟠)      | 
| `> 60`          | Red (🔴)        |
*/

public class TemperatureClassifier
{
    public void SignalColor(double temperature)
    {
        if (temperature < 30)
        {
            Console.WriteLine("🟢 Green");
        }
        else if (temperature >= 30 && temperature <= 60)
        {
            Console.WriteLine("🟠 Orange");
        }
        else if (temperature > 60)
        {
            Console.WriteLine("🔴 Red");
        }
    }
}
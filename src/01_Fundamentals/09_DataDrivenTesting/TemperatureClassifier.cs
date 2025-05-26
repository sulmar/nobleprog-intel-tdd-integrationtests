namespace DataDrivenTesting;

public class TemperatureClassifier
{
    public string Classify(int temperature)
    {
        if (temperature >= 85) return "Critical";
        if (temperature >= 65) return "Warning";
        if (temperature >= 50) return "Normal";
        return "Low";
    }
}

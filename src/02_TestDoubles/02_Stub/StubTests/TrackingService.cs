using System.Text.Json;

namespace StubTests;

public interface IFileReader
{
    string ReadAllText(string path); 
}

public class RealFileReader : IFileReader
{
    public string ReadAllText(string path) => File.ReadAllText(path);
}

public class StubValidFileReader : IFileReader
{
    public string ReadAllText(string _)
    {
        var location = new Location(21.01, 52.01);

        var json = JsonSerializer.Serialize(location);

        return json;
    }
}

public class StubInvalidFileReader : IFileReader
{
    public string ReadAllText(string path) => "a";
}

public class StubEmptyFileReader : IFileReader
{
    public string ReadAllText(string path) => String.Empty;
}

public class TrackingService
{
    private readonly IFileReader _fileReader;

    public TrackingService()
        : this(new RealFileReader())
    {
        
    }
    
    public TrackingService(IFileReader fileReader)
    {
        _fileReader = fileReader;
    }

    public Location Get()
    {
        string json = _fileReader.ReadAllText("tracking.json");

        try
        {
            return JsonSerializer.Deserialize<Location>(json);
        }
        catch (JsonException e)
        {
            throw new ApplicationException("Error parsing the location");
        }
    }
}


public class Location
{
    public Location(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override string ToString()
    {
        return $"{Latitude} {Longitude}";
    }

}
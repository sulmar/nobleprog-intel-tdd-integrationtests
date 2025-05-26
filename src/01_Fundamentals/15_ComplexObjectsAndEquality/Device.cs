namespace ComplexObjectsAndEquality;

public class Device
{
    public string Id { get; }
    public GpsLocation Location { get; }
    public DeviceStatus Status { get; }

    public Device(string id, GpsLocation location, DeviceStatus status)
    {
        Id = id;
        Location = location;
        Status = status;
    }
}



public enum DeviceStatus
{
    Online,
    Offline,
    Maintenance
}

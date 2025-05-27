namespace AdapterPatternTests;

public class HyteraRadio
{

    private RadioStatus status;

    public void Init()
    {
        status = RadioStatus.On;
    }

    public void SendMessage(byte channel, string content)
    {
        if (status == RadioStatus.On)
        {
            Console.WriteLine($"CHANNEL {channel}, MESSAGE {content}");
        }
    }

    public void Release()
    {
        status = RadioStatus.Off;
    }

    public enum RadioStatus
    {
        On,
        Off
    }

}

public class MotorolaRadio
{
    private bool enabled;

    private byte? selectedChannel;

    public MotorolaRadio()
    {
        enabled = false;
    }

    public void PowerOn(string pincode)
    {
        if (pincode == "1234")
        {
            enabled = true;
        }
    }

    public void SelectChannel(byte channel)
    {
        this.selectedChannel = channel;
    }

    public void Send(string message)
    {
        if (enabled && selectedChannel!=null)
        {
            Console.WriteLine($"<Xml><Send Channel={selectedChannel}><Message>{message}</Message></xml>");
        }
    }

    public void PowerOff()
    {
        enabled = false;
    }
}
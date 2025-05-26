namespace DefaultAndNullTesting;

public class VoltageProbe
{
    public ProbeState State { get; private set; }
    public double? LastVoltage { get; private set; }

    public VoltageProbe()
    {
        State = ProbeState.Idle;
        LastVoltage = null;
    }

    public void Sample(double voltage)
    {
        if (voltage < 0 || voltage > 24)
        {
            State = ProbeState.Error;
            LastVoltage = null;
            return;
        }

        LastVoltage = voltage;
        State = ProbeState.Measuring;
    }
}

public enum ProbeState
{
    Idle,
    Measuring,
    Error
}
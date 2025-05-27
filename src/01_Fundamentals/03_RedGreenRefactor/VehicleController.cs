namespace _RedGreenRefactor;

public class VehicleController
{
    // Cooler i Engine sa wlaczone
    public bool IsValid(VehicleState state) =>
        state.HasFlag(VehicleState.Cooler) && state.HasFlag(VehicleState.Engine);

}
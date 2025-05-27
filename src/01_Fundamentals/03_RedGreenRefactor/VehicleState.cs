namespace _RedGreenRefactor;

public enum VehicleState : byte
{
    None = 0,                   // 0000
    Opened =  1 << 0,  // 2^0 = 1  0001
    Cooler =  1 << 1,  // 2^1 = 2  0010
    Engine =  1 << 2,  // 2^2 = 4  0100
    Heating = 1 << 3  // 2^3 = 8   1000
}
namespace _RedGreenRefactor;

/*
🎯 Wymaganie: Aktywacja urządzenia na podstawie sygnałów wejściowych (GPIO)

Urządzenie otrzymuje sygnały wejściowe reprezentujące stan systemu (DeviceState). 
Sygnały te mogą pochodzić z czujników lub rejestrów wejściowych GPIO.

🧩 Wejściowe sygnały (bitowe):
- IsOverheated – temperatura przekroczyła dopuszczalny poziom
- IsMotionDetected – wykryto ruch w pobliżu urządzenia
- IsMaintenanceMode – urządzenie pracuje w trybie serwisowym

⚙️ Kontroler powinien aktywować urządzenie tylko wtedy, gdy:
- Wystąpiło przegrzanie
- Wykryto ruch 
- Jeśli urządzenie jest w trybie serwisowym (MaintenanceMode), to nie powinno się aktywować, niezależnie od innych sygnałów.

*/

public class GpioController
{
    public bool CanActivate(DeviceState state)
    {
        throw new NotImplementedException();
    }
}

public class DeviceState
{
 
}
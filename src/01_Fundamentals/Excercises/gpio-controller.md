# 🧪 Zadanie: Aktywacja urządzenia na podstawie sygnałów wejściowych (GPIO)

## Opis
Urządzenie otrzymuje sygnały wejściowe reprezentujące stan systemu (`DeviceState`). 
Sygnały te mogą pochodzić z czujników lub rejestrów wejściowych GPIO.

🧩 Wejściowe sygnały (bitowe):
- `IsOverheated` – temperatura przekroczyła dopuszczalny poziom
- `IsMotionDetected` – wykryto ruch w pobliżu urządzenia
- `IsMaintenanceMode` – urządzenie pracuje w trybie serwisowym


## 🎯 Wymagania

 Kontroler powinien aktywować urządzenie tylko wtedy, gdy:
- 1. Wystąpiło przegrzanie
- 2. Wykryto ruch 
- 3. Jeśli urządzenie jest w trybie serwisowym (`MaintenanceMode`), to nie powinno się aktywować, niezależnie od innych sygnałów.


## Przykładowy kod

```cs
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
```
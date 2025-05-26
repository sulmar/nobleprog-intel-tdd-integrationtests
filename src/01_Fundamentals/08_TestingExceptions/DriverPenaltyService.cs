using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExceptions;

// 🚗 Scenariusz: System punktów karnych z dodatkowymi ograniczeniami
/*

🎯 Wymagania:
- Punkty karne są przechowywane jako byte.
- Kierowca może dostać maksymalnie 10 punktów w jednej interwencji.
- Nie można dodawać punktów kierowcy, którego prawo jazdy już zostało zawieszone.
- Po przekroczeniu 24 punktów, system oznacza kierowcę jako „zawieszony”.

*/

public class DriverPenaltyService
{
    public const byte MaxPenaltyPerOffense = 10;
    public const byte SuspensionThreshold = 24;

    public byte AddPenalty(byte currentPoints, byte newPoints, bool isSuspended)
    {
        return (byte)(currentPoints + newPoints);
    }

    public bool ShouldSuspendLicense(byte totalPoints)
    {
        return totalPoints >= SuspensionThreshold;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexObjectsAndEquality;

public class GpsLocation
{
    public double Latitude { get; }
    public double Longitude { get; }

    public GpsLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

}

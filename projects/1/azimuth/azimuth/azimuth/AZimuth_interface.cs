using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azimuth
{
    internal interface IAZimuth
    {
        double Toradian(double degree);
        double Todegree(double radian);
        double Azimuth(double lat1, double long1, double lat2, double long2);
    }
}

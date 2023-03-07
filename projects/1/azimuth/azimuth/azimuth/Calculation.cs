using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azimuth
{
    class Calculation
    {

        static public double Toradian(double degree)
        {
            double radian = degree / 180 * Math.PI;
            return radian;
        }

        static public double Todegree(double radian)
        {
            double degree = radian / Math.PI * 180;
            return degree;
        }


        static public double Azimuth(double lat1 , double long1, double lat2, double long2)
        // this function works with radian values and caculate azimuth with latitude and longitude !
        {
                double D_long = long2 - long1;
                double G = Math.Sin(D_long) * Math.Cos(lat2);
                double V = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(D_long);
                double T = Math.Atan2(G, V);
                T = (T * 180 / Math.PI);
                if (T < 0)
                {
                    T = T + 360;
                }
                if (T > 360)
                {
                    T = T - 360;
                }
                return T;
        }

    }
}

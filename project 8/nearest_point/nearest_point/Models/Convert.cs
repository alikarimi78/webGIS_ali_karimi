using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nearest_point.Models
{
    public class Convert
    {
        public static double[] ConvertToCartesian(double phi ,  double lambda)
        {
            double earthRadius = 6378137; // in meters

            // converting phi and lambda to Radians
            phi = phi * Math.PI / 180;
            lambda = lambda * Math.PI / 180;

            double[] result = new double[2];
            result[0] = earthRadius * lambda * Math.Cos(phi);
            result[1] = earthRadius * phi;

            return result;
        }
    }
}
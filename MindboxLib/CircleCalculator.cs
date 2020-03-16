using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxLib
{
    public class CircleShape : IGeometricalShape
    {
        public double Radius { get; set; }
        public CircleShape(double radius)
        {
            Radius = radius;
        }
        public double CalculateAreaSize()
        {
            double aSize = 0;
            aSize = Math.PI * Math.Pow(Radius,2);
            return aSize;
        }
    }
}

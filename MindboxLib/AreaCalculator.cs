using System;

namespace MindboxLib
{
    public class AreaCalculator
    {
        public static double GetAreaSize(IGeometricalShape shape)
        {
            return shape.CalculateAreaSize();
        }
    }
}

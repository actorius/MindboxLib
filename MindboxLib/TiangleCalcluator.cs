using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxLib
{
    public class TriangleShape : IGeometricalShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double AngleA
        {
            get
            {
                var a = (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) / (2 * SideA * SideC);
                return Math.Acos(a) * 180 / Math.PI;
            }
        }
        public double AngleB
        {
            get
            {
                var b = (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) / (2 * SideA * SideB);
                return Math.Acos(b) * 180 / Math.PI;
            }
        }
        public double AngleC
        {
            get
            {
                var c = (Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) / (2 * SideC * SideB);
                return Math.Acos(c) * 180 / Math.PI;
            }
        }
        public TriangleShape(double aSide, double bSide, double cSide)
        {
            SideA = aSide;
            SideB = bSide;
            SideC = cSide;
        }

        public bool IsSquareAngle
        {
            get
            {
                return CheckIsSquareAngle();
            }
        }
        public double CalculateAreaSize()
        {
            double aSize = 0;
            var p = 1 / 2 * (SideA + SideB + SideC);
            aSize = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return aSize;
        }
        private bool CheckIsSquareAngle()
        {
            var a = 0;
            return AngleA == 90 || AngleB == 90 || AngleC == 90;
        }
    }
}

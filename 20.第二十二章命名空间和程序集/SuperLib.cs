using System;

namespace MyCrop.SuperLib
{
    public class SquareWidet
    {
        public double SideLength = 0;
        public double Area
        {
            get { return SideLength * SideLength; }
        }
    }
}
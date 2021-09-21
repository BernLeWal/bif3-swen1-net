using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes
{
    public class BetterRectangle : IBetterShapeComposition, IBetterShapeMath
    {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private int X2Coordinate { get; }
        private int Y2Coordinate { get; }

        public BetterRectangle(int x1, int y1, int x2, int y2) 
        {
            XOriginCoordinate = x1;
            YOriginCoordinate = y1;
            X2Coordinate = x2;
            Y2Coordinate = y2;
        }

        public double GetArea()
        {
            return (X2Coordinate - XOriginCoordinate) * (Y2Coordinate - YOriginCoordinate);
        }

        public double GetPerimeter()
        {
            return 11.2f;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a rect");
        }

        public void ShowOrigin()
        {
            Console.WriteLine($"X1={XOriginCoordinate}");
        }
    }
}
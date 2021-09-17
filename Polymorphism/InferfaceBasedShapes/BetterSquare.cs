using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes
{
    public class BetterSquare : IBetterShapeComposition
    {
        public int XOriginCoordinate { get; }
        public int YOriginCoordinate { get; }

        private int _diameter;

        public BetterSquare(int xOriginCoordinate, int yOriginCoordinate, int diameter)
        {
            XOriginCoordinate = xOriginCoordinate;
            YOriginCoordinate = yOriginCoordinate;
            _diameter = diameter;
        }

        public double GetArea()
        {
            return _diameter*_diameter;
        }

        public double GetPerimeter()
        {
            return 4 * _diameter;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a square");
        }

        public void ShowOrigin()
        {
            Console.WriteLine($"xOrigin={XOriginCoordinate}, YOrigin={YOriginCoordinate}");
        }
    }
}
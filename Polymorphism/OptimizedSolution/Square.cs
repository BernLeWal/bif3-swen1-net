using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    public class Square : Shape, IShapeComposition
    {
        private int _diameter;
        public Square(int x, int y, int diameter) : base(x, y)
        {
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
    }
}
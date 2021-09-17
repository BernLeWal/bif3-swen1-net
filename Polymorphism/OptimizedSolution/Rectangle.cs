using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Rectangle : Shape, IShapeComposition
    {
        private int _x2;
        private int _y2;

        public Rectangle(int x1, int y1, int x2, int y2) : base(x1,y1)
        {
            _x2 = x2;
            _y2 = y2;
        }

        public double GetArea()
        {
            return (_x2 - _x) * (_y2 - _y);
        }

        public double GetPerimeter()
        {
            return 34.56f;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a rectangle");
        }
    }
}

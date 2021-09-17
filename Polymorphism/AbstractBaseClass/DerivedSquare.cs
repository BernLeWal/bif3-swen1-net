using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedSquare : AbstractShape
    {
        private int _diameter;

        public DerivedSquare(int x, int y, int diameter) : base(x,y)
        {
            _diameter = diameter;
        }

        public override double GetArea()
        {
            return _diameter * _diameter;
        }

        public override double GetPerimeter()
        {
            return 4 * _diameter;
        }

        public override void PrintShapeType()
        {
            Console.WriteLine("I'm a square!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedRectangle : AbstractShape
    {
        private int _x2, _y2;

        public DerivedRectangle(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this._x2 = x2;
            this._y2 = y2;
        }


        public override double GetArea()
        {
            return (_x2 - _x) * (_y2 - _y);
        }

        public override double GetPerimeter()
        {
            return 0.1f;
        }

        public override void PrintShapeType()
        {
            Console.WriteLine("I'm a rectangle");
        }
    }
}
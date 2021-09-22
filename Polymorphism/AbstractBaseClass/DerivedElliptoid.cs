using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedElliptoid : AbstractShape
    {
        public DerivedElliptoid(int x, int y) : base(x, y)
        {
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void PrintShapeType()
        {
            Console.WriteLine("I'm a elliptoid");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedCylinder : AbstractShape
    {
        public DerivedCylinder(int x, int y) : base(x, y)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string GetJSON()
        {
            return base.GetJSON();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override void PrintShapeType()
        {
            throw new NotImplementedException();
        }

        public override void ShowOrigin()
        {
            base.ShowOrigin();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

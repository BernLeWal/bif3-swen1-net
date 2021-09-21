using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedPyramid : AbstractShape
    {
        public DerivedPyramid(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public override double GetArea()
        {
            return Width * Width;
        }

        public override string GetJSON()
        {
            return base.GetJSON();
        }

        public override double GetPerimeter()
        {
            return 4 * Width;
        }

        public override void PrintShapeType()
        {
            Console.WriteLine("I'm a pyramid");
        }

        public override void ShowOrigin()
        {
            base.ShowOrigin();
        }
    }
}

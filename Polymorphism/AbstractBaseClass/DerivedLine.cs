using System;
using System.Text;
using System.Text.Json;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    class DerivedLine : AbstractShape {

        private int _x2, _y2;

        public int X2 { get => _x2; set => _x2 = value; }
        public int Y2 { get => _y2; set => _y2 = value; }

        public DerivedLine(int x1, int y1, int x2, int y2) : base(x1, y1) {
            this.X2 = x2;
            this.Y2 = y2;
        }



        public override double GetArea() {
            return 2;
        }

        public override double GetPerimeter() {
            return 10;
        }

        public override void PrintShapeType() {
            Console.WriteLine("I'm a Line");
        }

        public override void ShowOrigin() {
            Console.WriteLine(
                string.Format("Origin: {0}, {1} End: {2}, {3}", X, Y, X2, Y2));
        }

        public override string GetJSON()
        {
            // use the System.Text.JsonSerializer
            return JsonSerializer.Serialize(this);
        }
    }
}

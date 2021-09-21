using System;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass {
    abstract class AbstractShape {
        private int _y;
        private int _x;

        public int X { get => _x; protected set => _x = value; }
        public int Y { get => _y; protected set => _y = value; }

        public AbstractShape(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public abstract void PrintShapeType();

        public virtual void ShowOrigin() {
            Console.WriteLine(string.Format("Origin: {0}, {1}", this.X, this.Y));
        }

        public virtual string GetJSON()
        {
            return "{\n" + GetJSONBase("  ") + "}\n";
        }

        protected string GetJSONBase(string indent)
        {
            // use plain old strings to create JSON 
            StringBuilder builder = new();
            builder.Append($"{indent}\"x\": \"{X}\",\n");
            builder.Append($"{indent}\"y\": \"{Y}\"\n");
            return builder.ToString();
        }
    }
}

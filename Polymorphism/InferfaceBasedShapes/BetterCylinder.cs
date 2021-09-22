using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bif3.Swe1.Oop.Polymorphism.InferfaceBasedShapes
{
    class BetterCylinder : IBetterShape
    {
        public int XOriginCoordinate => throw new NotImplementedException();

        public int YOriginCoordinate => throw new NotImplementedException();

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a cylinder!");
        }

        public void ShowOrigin()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //Signed by Jelier
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0}, the Circle", PetName);
        }
    }

    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0}, the Hexagon", PetName);
        }
        public void Draw3D()
        { Console.WriteLine("Drawing Hexagon in 3D!"); }

        public byte Points
        {
            get { return 6; }
        }
    }

    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0}, the Triangle", PetName);
        }

        public byte Points
        {
            get { return 3; }
        }
    }
}

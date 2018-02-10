using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        //Signed by Jelier
        static void Main(string[] args)
        {
            /*
             Hexagon hex = new Hexagon();
             Console.WriteLine("Points: {0}", hex.Points);
             Circle c = new CustomInterface.Circle("Lisa");
             IPointy itfPt = null;
             try
             {
                 itfPt = (IPointy)c;
                 Console.WriteLine(itfPt.Points);
             }
             catch (InvalidCastException e)
             {
                 Console.WriteLine(e.Message);
             }
             Hexagon hex2 = new Hexagon("Peter");
             IPointy itfPt2 = hex2 as IPointy;
             if (itfPt2 != null)
                 Console.WriteLine("Points: {0}", itfPt2.Points);
             else
                 Console.WriteLine("OOPS! Not pointy..."); */


            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy)
                    Console.WriteLine("==> Points: {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("==> {0}'s not pointy!", myShapes[i].PetName);
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("===> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
    }
}

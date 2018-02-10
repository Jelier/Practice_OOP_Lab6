using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //Signed by Jelier
        /*public void Draw()
        {
            Console.WriteLine("Drawing the Octagon...");
        }*/
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing the Octagon to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing the Octagon to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing the Octagon to a printer...");
        }
    }
}

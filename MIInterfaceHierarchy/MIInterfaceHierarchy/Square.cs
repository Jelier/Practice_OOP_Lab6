using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        void IPrintable.Draw()
        {
            Console.WriteLine("Рисуемый для печати Квадратец");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Рисуемый Квадратец");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Напечатал квадрат");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square();
            Rectangle rect = new Rectangle();
            rect.Draw();
            rect.Print();
            ((Square)sqr).Print();
            
            Console.ReadLine();
        }
    }
}

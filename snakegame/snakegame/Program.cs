﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.DrawSymbol();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            p2.DrawSymbol();

            Console.ReadLine();
        }
    }
}

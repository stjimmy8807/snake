using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    class Program
    {
        static void drawSymbol(int a, int b, char c)
        {
            Console.SetCursorPosition(a, b);
            Console.Write(c);
        }
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb = '*';
            drawSymbol(x1, y1, symb);

            int x2 = 4;
            int y2 = 5;
            char symb2 = '#';
            drawSymbol(x2, y2, symb2);


            Console.ReadLine();
        }
    }
}

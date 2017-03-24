using System;
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
            Point p1 = new Point(1,3,'*');
            p1.DrawSymbol();

            Point p2 = new Point(4,5,'#');
            p2.DrawSymbol();

            HorizontalLine lineH = new HorizontalLine(5,10,8,'+');
            lineH.Drow();

            VerticalLine lineV = new VerticalLine(12,3,10,'&');
            lineV.Drow();

            Console.ReadLine();
        }
    }
}

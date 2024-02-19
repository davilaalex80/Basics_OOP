using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EntryPoint
{
    static void Main()
    {
        Point point = new Point(5,3);

        //point.X = 5;
        //point.Y = 3;

        Point pointTwo = new Point();
        pointTwo.X = 5;

        Console.WriteLine(point.X);
        Console.WriteLine(point.Y);
    }
}
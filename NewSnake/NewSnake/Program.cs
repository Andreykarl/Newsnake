using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 4;
            p1.sym = '%';
            p1.Draw();

            Console.ReadLine();
        }
    }
}

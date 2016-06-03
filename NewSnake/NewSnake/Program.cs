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

            Console.SetBufferSize(80, 25);

            hLine upline = new hLine(0, 78, 0, '+');
            hLine downline = new hLine(0, 78, 24, '+');
            wLine leftline = new wLine(0, 24, 0, '+');
            wLine rightline = new wLine(0, 24, 78, '+');

            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();


            Console.ReadLine();
        }
    }
}

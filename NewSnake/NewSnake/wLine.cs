using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class wLine : Figure
    {

        public wLine(int yTop, int yBoth, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBoth; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

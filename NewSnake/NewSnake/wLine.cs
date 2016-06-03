using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class wLine
    {
        List<Point> pList;

        public wLine(int yTop, int yBoth, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBoth; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> pList;
        public VerticalLine(int yTop, int yBpttom, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBpttom; i++)
            {
                pList.Add(new Point(x, i, sym));
            };

        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            };
        }
    }
}

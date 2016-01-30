using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int yTop, int yBpttom, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBpttom; i++)
            {
                pList.Add(new Point(x, i, sym));
            };

        }
       
    }
}

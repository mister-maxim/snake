using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int i = xLeft; i <= xRight; i++)
            {
                pList.Add(new Point(i, y, sym));
            };

        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}

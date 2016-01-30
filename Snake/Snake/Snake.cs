﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int len, Direction direction)
        {
            for (int i = 0; i < len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            };

        }
    }
}

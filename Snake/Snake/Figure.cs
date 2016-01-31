﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        protected Figure()
        {
            pList = new List<Point>();
        }
        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            };
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p1 = new Point(1,3,'x');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            */
            HorizontalLine line = new HorizontalLine(3,15,7,'x');
            line.Draw();

            Console.ReadLine();
        }

    }
}

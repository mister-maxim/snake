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
            Console.SetBufferSize(80, 25);
            /*
            Point p1 = new Point(1,3,'x');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            */
            HorizontalLine line1 = new HorizontalLine(0,78,0,'+');
            VerticalLine line2 = new VerticalLine(0, 24, 78, '+');
            HorizontalLine line3 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine line4 = new VerticalLine(0, 24, 0, '+');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point( int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        
        public Point(Point p):this(p.x, p.y, p.sym)
        {
           
        }/*
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }*/

        public void Move(int length, Direction direction){
            if(direction == Direction.RIGHT)x += length;
            if(direction == Direction.LEFT)x -= length;
            if(direction == Direction.UP)y -= length;
            if(direction == Direction.DOWN)y += length;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private Direction direction; 

        public Snake(Point tail, int len, Direction _direction)
        {
            direction = _direction;
            for (int i = 0; i < len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                pList.Add(p);

            };

        }

        public void Move()
        {

            //throw new NotImplementedException();
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            };

        }

        internal bool Eat(Point food){
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                
                return true;
            }
            else
            {
                return false;
            };
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            head = new Point(head);
            head.Move(1, direction);
            return head;
           
        }
    }
}

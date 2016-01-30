using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction; 

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

        internal void Move()
        {

            //throw new NotImplementedException();
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
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

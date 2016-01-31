using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            /*
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            //Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(Figure f in figures){
                f.Draw();
            };
            */

            










            /*
            Point p1 = new Point(1,3,'x');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            */
            //отрисовка рамочки
            
            HorizontalLine line1 = new HorizontalLine(0,78,0,'+');
            VerticalLine line2 = new VerticalLine(0, 24, 78, '+');
            HorizontalLine line3 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine line4 = new VerticalLine(0, 24, 0, '+');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            //p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');//габариты экрана и значёк еды.
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                snake.Move();
                Thread.Sleep(100);
            };
            /**/
            //Console.ReadLine();
        }

        public static void Draw(Figure figure)
        {
            figure.Draw();
        }

    }
}

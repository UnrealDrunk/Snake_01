using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(180, 180);

            //Printig the frame
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
  
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            snake.Drow();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();

            Console.ReadLine();
            
 
        }
        
        
    }

}

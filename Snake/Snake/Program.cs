﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);


            
		}
	}
}

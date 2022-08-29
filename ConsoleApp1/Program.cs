using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp1
{
    internal class Program
    {
        static void WriteT(int x, int y, int size)
        {

            //TopT
            //Буква Т начало
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            //Turtle.Angle(270);
            Turtle.TurnLeft();
            Turtle.Move(size/3);
            Turtle.Angle = 90;
            Turtle.Move(size*2/3);
            // Буква Т конец

        }
        static void WriteO(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteR(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size/2);
            WriteO(size / 2);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
          
            WriteT(200, 200, 60);                                 
            WriteO(230, 200, 60);
            WriteR(300, 200, 60);            
            WriteT(360, 200, 60);






            //int i = 0;
            //while (i < 6)
            //{
            //    Turtle.Move(100);
            //    Turtle.TurnRight();
            //    Turtle.Move(100);
            //    Turtle.TurnRight();
            //    Turtle.Move(100);
            //    Turtle.TurnLeft();
            //    Turtle.Move(100);
            //    Turtle.TurnLeft();
            //    i++;
            //}

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechthoek
{
    class Program
    {
        public static void Main(string[] args)
        {
            var toets = true;
            var curx = Console.CursorLeft;
            var cury = Console.CursorTop;
            Console.WriteLine("┌┐");
            Console.WriteLine("└┘");



            while (toets == true)
            {
                var bla = Console.ReadKey();
                if (bla.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    curx = curx - 2;

                    Console.SetCursorPosition(curx, cury);
                    Console.WriteLine("┌┐");
                    Console.SetCursorPosition(curx, cury + 1);
                    Console.WriteLine("└┘");
                }
                else if (bla.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    curx = curx + 2;

                    Console.SetCursorPosition(curx, cury);
                    
                    Console.WriteLine("┌┐");
                    Console.SetCursorPosition(curx, cury + 1);
                    Console.WriteLine("└┘");
                }
                else if (bla.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    cury = cury + 2;

                    Console.SetCursorPosition(curx, cury);

                    Console.WriteLine("┌┐");
                    Console.SetCursorPosition(curx, cury +1);
                    Console.WriteLine("└┘");
                }
                else if (bla.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    cury = cury - 2;

                    Console.SetCursorPosition(curx, cury);

                    Console.WriteLine("┌┐");
                    Console.SetCursorPosition(curx, cury + 1);
                    Console.WriteLine("└┘");
                }
                else
                {
                    Console.WriteLine("Helaas.. je drukt op wat anders");
                }
            }
        }

        
    }
}

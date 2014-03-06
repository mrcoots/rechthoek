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
            Console.WriteLine("┌┐");
            Console.WriteLine("└┘");
            var vraag = true;
            while (vraag == true)
            {
                var bla = Console.ReadKey();
                Console.WriteLine(bla.Key.ToString());
                if (bla.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("Gelukt, de pijltjestoets links is ingedrukt");
                }
                else
                {
                    Console.WriteLine("Helaas.. je drukt op wat anders");
                }
            }
        }

        
    }
}

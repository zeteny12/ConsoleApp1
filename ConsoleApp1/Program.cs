using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Két szám bekérése, majd összeadása
            Console.WriteLine("Írj be egy számot, majd üss entert!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Írj be még egy számot, majd üss megint entert!");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("A beírt két szám összege: " + c);

            Console.ReadKey();
        }
    }
}

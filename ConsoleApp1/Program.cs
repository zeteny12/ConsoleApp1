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
            //Két szám bekérése
            int szam_1 = szamotKer("Írj be egy számot, majd üss entert!\t");
            int szam_2 = szamotKer("Írj be még egy számot, majd üss megint entert!\t");

            //Művelet
            int osszeg = szam_1 + szam_2;
            //Kiírás
            Console.WriteLine("\nA beírt két szám összege: " + osszeg);

            Console.ReadKey();
        }

        private static int szamotKer(string szoveg)
        {
            int BekertSzam;
            Console.Write(szoveg);
            BekertSzam = int.Parse(Console.ReadLine());
            return BekertSzam;
        }
    }
}

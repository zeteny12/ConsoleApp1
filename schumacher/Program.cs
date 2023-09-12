using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace schumacher
{
    internal class Program
    {
        static List<Schumi> adatok = new List<Schumi>();

        static void Main(string[] args)
        {
            AdatokBeolvasasa();
            Feladatok03();
            Feladatok04();
            Feladatok05();

            Console.ReadKey();
        }

        private static void Feladatok05()
        {
            Console.WriteLine("5. feladat: Hibastatisztika");
            foreach (var item in adatok.GroupBy(a => a.Status).Select(b => new {ok = b.Key, db=b.Count()}))
            {
                if (item.db > 2)
                {
                    Console.WriteLine("\t" + item.ok + " : " + item.db);
                }                
            }
        }

        private static void Feladatok04()
        {
            Console.WriteLine("4. feladat: Magyar Nagydíj helyezései");
            foreach (var item in adatok.FindAll(a => a.Grandprix.Equals("Hungarian Grand Prix") && a.Position > 0))
            {
                Console.WriteLine("\t" + item.Date.ToShortDateString() + " : " + item.Position + ". hely");    
            }
        }

        private static void Feladatok03()
        {
            Console.WriteLine("3. feladat: " + adatok.Count);
        }

        private static void AdatokBeolvasasa()
        {
            try {
                using (StreamReader file = new StreamReader("schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Schumi(file.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

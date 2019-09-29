using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {

        public static List<int> szamok = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg 10 számot!");
            int db = 10;

            try
            {
                int i = 0;
                while (i < db)
                {
                    Console.Write("Kérem adja meg az " + (i + 1) + ". számot: ");
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                    i++;
                }

                int legnagyobb = szamok[0];
                int legnagyobbhely = 0;
                


                for (int a = 0; a < szamok.Count; a++)
                {
                    if (szamok[a] > legnagyobb)
                    {
                        legnagyobb = szamok[a];
                        legnagyobbhely = a;
                    }
                   


                }
                Console.WriteLine("Legnagyobb: " + szamok[legnagyobbhely]);

            }
            catch
            {
                Console.WriteLine("Hiba");
            }
            Console.ReadLine();
        }


    }
}
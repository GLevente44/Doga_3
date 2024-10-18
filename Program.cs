using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_3
{
    internal class Program
    {
        public static void Diakpontszam()
        {
            string[] diakNevek = new string[5];
            int[] pontszamok = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. diák nevét: ");
                diakNevek[i] = Console.ReadLine();

                Console.Write($"Kérem a(z) {i + 1}. diák pontszámát: ");
                pontszamok[i] = int.Parse(Console.ReadLine());
            }


            int osszPontszam = 0;
            int maxPontszam = pontszamok[0];
            int minPontszam = pontszamok[0];
            string maxDiak = diakNevek[0];
            string minDiak = diakNevek[0];
            bool elegtelen = false;

            for (int i = 0; i < 5; i++)
            {
                osszPontszam += pontszamok[i];

                if (pontszamok[i] > maxPontszam)
                {
                    maxPontszam = pontszamok[i];
                    maxDiak = diakNevek[i];
                }
                if (pontszamok[i] < minPontszam)
                {
                    minPontszam = pontszamok[i];
                    minDiak = diakNevek[i];
                }

             
                if (pontszamok[i] < 50)
                {
                    elegtelen = true;
                }
            }

            
            int atlagPontszam = osszPontszam / 5;

            
            Console.WriteLine("\nÁtlagpontszám: {0}",atlagPontszam);
            Console.WriteLine($"Legmagasabb pontszám: {maxPontszam}, Diák: {maxDiak}");
            Console.WriteLine($"Legalacsonyabb pontszám: {minPontszam}, Diák: {minDiak}");

            if (elegtelen)
            {
                Console.WriteLine("Van elégtelen pontszám!");
            }



        }
        static void Main(string[] args)
        {
            Diakpontszam();
        }
    }
}

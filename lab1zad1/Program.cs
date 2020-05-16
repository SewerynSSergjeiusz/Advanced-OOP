using System;
using System.Linq;

namespace lab1zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1195, 843, 1950, 1044, 1374, 1218, 181, 1941, 669, 
                1770, 1515, 1393, 594, 93, 632, 1638, 1417, 1636, 973, 1821,
                682, 696, 1076, 898, 453, 167, 562, 339, 568, 281, 1074, 1213, 
                847, 849, 1268, 1089, 833, 28, 1347, 1526, 1129, 461, 1629, 1426, 
                670, 689, 712, 783, 742, 499 };
            int min = tab.Min();
            int max = tab.Max();
            Console.WriteLine("Lowest value = "+min+" Highset value = "+max);
            int x = 0;

            while (x < tab.Length)
            {
                if (tab[x] % 2 == 0)
                {

                    Console.WriteLine(tab[x]);
                    x++;

                }
                else
                    x++;
            }
            Console.WriteLine("przerwa ..........");
            int[] seven = new int [tab.Length];
            int y = 0;
            while(y < tab.Length)
            {

                if (tab[y] % 7 == 0)
                {
                    seven[y] = tab[y];
                    Console.WriteLine(seven[y]);
                    y++;

                }
                else
                y++;

            }
            int smax = seven.Max();
            Console.WriteLine("Najwieksza liczba podzielna przez 7 to: "+smax);
            int z = 0;
            while (z < tab.Length)
            {
                if (tab[z] % 2 == 0)
                {
                    Console.WriteLine("Pierwsza liczbę parzystą w zbiorze to: "+tab[z]);
                    break;
                }
                else
                    z++;
            }

            Array.Sort(tab, 0, tab.Length);
            Console.WriteLine(tab);

        }
    }
}

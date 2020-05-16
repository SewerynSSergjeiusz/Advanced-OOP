using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string points = "10,5,0,8,10,1,4,0,10,1";
            var wynik = points.Where(x => points.IndexOf(',') ,x + x);
            Console.WriteLine(wynik);
        }
    }
}

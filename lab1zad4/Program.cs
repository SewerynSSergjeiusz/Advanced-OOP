using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adam Malysz",
                    "Mariusz Pudzianowski",
                    "Steven Seagal",
                    "Chuck Norris",
                    "Gianluigi Buffon",
                    "Jan Kowalski",
                    "Tadeusz Iksinski",
                    "John Smith"
                  };

            
            
            foreach( string x in names)
            {

               string  justname = x.Substring(0, x.IndexOf(' '));
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
                int total = justname.Count(c => vowels.Contains(c));
                if (total >= 3)
                {
                    Console.WriteLine(justname);
                }
            }
            Console.ReadLine();
        }
    }
}

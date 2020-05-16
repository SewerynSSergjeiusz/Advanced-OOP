using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullNameList = new List<string>();
            fullNameList.Add("Joe Thompson");
            fullNameList.Add("Bob Jones");
            fullNameList.Add("Bob Smith");
            fullNameList.Add("Billy Smith");
            fullNameList.Add("Joe Williams");
            fullNameList.Add("Joe Joejoe");
            fullNameList.Add("Adam Malysz");
            fullNameList.Add("Bob Bobovich");

            var result1 = from s in fullNameList
                         where (s.Contains("Joe") || s.Contains("Bob"))
                         select s;

            foreach (var str in result1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Osoba z wystąpieniem Smith");

            var result2 = from x in fullNameList
                         where x.Contains("Smith")
                         select x;
            foreach (var str in result2)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}

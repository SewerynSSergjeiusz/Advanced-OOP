using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2zad1
{
    class Program
    {
     
        static void PrintItems<T>(T[] items)
        {
            // var newArray = Array.ConvertAll(items, item => item.ToString());
            if (items is IList<T>)
            {
                string concat = String.Join(" ", items.ToArray());
                Console.WriteLine(concat);
            }
            else
            {
                string[] table1 = new string[10];
                foreach (T word in items)
                {
                    for (int x = 0; x < items.Length; x++)
                    {
                        table1[x] = items[x].ToString();

                    }

                }

                string concatNumber = String.Concat(table1);

                Console.WriteLine(concatNumber);
            }
        }
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5 };
            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f' };
            List<string> strings = new List<string> { "This", " class", " is", " awesome" };

            PrintItems(integers);
            PrintItems(characters);
            PrintItems(strings);
            
            Console.ReadLine();
            //Console.WriteLine(ConcatenateCollection(integers));
        }
    }
}

using System;

namespace lab3zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 13;
            
            //Typ zmiennej d to: System.Int32

            d = "Napis";
            //Teraz typ zmiennej d to: Systems.String

            d--;    //BŁĄD zmienna jest aktualnie typu String
            Console.WriteLine(d.GetType());
            Console.ReadLine();
        }
    }
}

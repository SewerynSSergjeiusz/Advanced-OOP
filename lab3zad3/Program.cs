using System;
using System.Collections.Generic;
using System.Text;

namespace lab3zad3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Prostokat aa = new Prostokat(5,4,"Prostkat");
            //Console.WriteLine(aa.Pole()+" "+aa.Obwod()+" "+aa.Nazwa);
           
            
            List<Figura> listaFigura = new List<Figura>();
            listaFigura.Add(new Prostokat(2, 3, "P1"));
            listaFigura.Add(new Prostokat(5, 12, "P2"));
            listaFigura.Add(new Prostokat(90, 3, "P3"));

            foreach (Prostokat figura in listaFigura)
            {
                Console.WriteLine(figura.Pole() + " " + figura.Obwod() + " " + figura.Nazwa);
            }
            
        }
    }
}

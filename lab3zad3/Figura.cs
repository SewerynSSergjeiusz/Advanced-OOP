using System;
using System.Collections.Generic;
using System.Text;

namespace lab3zad3
{
    public abstract class Figura
    {
        public abstract string Nazwa { get; set; }
        public abstract double Pole();
        public abstract double Obwod();

    }
    public class Prostokat : Figura
    {
        private double a;
        private double b;
        private string name;
      
       

        public Prostokat(double a, double b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }

        public override double Pole() => a * b;
        public override double Obwod() => 2 * a + 2 * b;
       

        public override string Nazwa { get => name; set => name = value; }

       

    }
    /*
    public class Kolo : Figura
    {
        private int r;
        private string name;

        public Kolo (int r)
        {
            this.r = r;
        }

        public override string Nazwa { set => name = value; }

        public override double Pole()
        {
            return r * r * 3.14;
        }

        public override double Obwod()
        {
            return r * 2 * 3.14;
        }

        
    }
    public class Kwadrat : Figura
    {
        private int a;
        private string name;
        public override string Nazwa { set => name = value; }

        public Kwadrat(int a)
        {
            this.a = a;
        }
        public override double Obwod()
        {
            return 4 * a;
        }
        public override double Pole()
        {
            return a * a;
        }
        */
    
    
}

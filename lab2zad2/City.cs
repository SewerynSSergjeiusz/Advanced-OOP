using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2zad2
{
    public class City
    {
        private string name;
        private int[,] cityscopes;     

        public City(string name, int [,] cityscopes)
        {
            this.name = name;
            this.cityscopes = cityscopes;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int [,] CityScopes
        {
            get { return cityscopes; }
            set { cityscopes = value; }
           
        }
        
    }
}

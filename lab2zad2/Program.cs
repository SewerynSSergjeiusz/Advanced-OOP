using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2zad2
{
  

    class Program
    {
        static void Main()
        {
            int s = Convert.ToInt32(Console.ReadLine()); //liczba przypadków testowych
            int n = Convert.ToInt32(Console.ReadLine()); //liczba miast
            int p; //liczba miast sąsiednich do name
            
            string[] tokens = new string[100];
            int[,] cityscopes = new int[4, 2]; //tablica [id miasta, koszt połączenia]
            int[,] cityscopes1 = new int[4, 2];
            List<City> CityList = new List<City>();
             for( int x = 0; x < n;) 
             {
                string  name = Console.ReadLine(); //zczytuje nazwe miasta  gdansk
                 p = Convert.ToInt32(Console.ReadLine()); //liczba miast sąsiednich  2

                     tokens = Console.ReadLine().Split();
                     int nr = Convert.ToInt32(int.Parse(tokens[0]));
                     int cost = Convert.ToInt32(int.Parse(tokens[1]));
                     cityscopes[y, 0] = nr;
                     cityscopes[y, 1] = cost;
                     
                     CityList.Add(new City(name, cityscopes));
                 

                 

             }
             
             /*
            string name = "Gdansk";
            cityscopes[0, 0] = 1;
            cityscopes[0, 1] = 1;
            cityscopes[1, 0] = 2;
            cityscopes[1, 1] = 2;

            CityList.Add(new City(name, cityscopes));

            name = "Bydgoszcz";
            cityscopes[2, 0] = 3;
            cityscopes[2, 1] = 3;
            cityscopes[3, 0] = 4;
            cityscopes[3, 1] = 4;

            CityList.Add(new City(name, cityscopes));

            */


            /* 
             foreach(var city in CityList)
             {
                 Console.WriteLine(city.Name +" "+ city.CityScopes [1, 0] + " " + city.CityScopes[1, 1]);
             }
             */

            for (int i = 0; i < 2;)
            {
                for (int k = 0; k < cityscopes.Length;)
                {
                    Console.WriteLine(CityList[i].Name + ' ' + CityList[i].CityScopes[k, 0] +' '+CityList[i].CityScopes[k, 1]);
                    k++;
                    
                }
                i++;
            }
            



            Console.ReadKey();

        }
    }
}

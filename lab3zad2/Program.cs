using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace lab3zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj adres url strony !");
            var requestUri = CountSigns(Console.ReadLine());
            Waiting();
            requestUri.Wait();
            Console.ReadLine();


        }
        private static void Waiting()
        {
            int i = 0;
            while ( i < 10)
            {
                Console.WriteLine("Prosze czekać... trwa obliczanie");
                    i++;
            }
        }
        static async Task<string> CountSigns(string value)
        {
            Console.WriteLine("obliczanie rozpoczęte");
            Console.WriteLine("podany adres url to " + value);
            var client = new HttpClient();
            var result = await Task.Run(() => client.GetStringAsync("https://" + value));
            
            
            Console.WriteLine(result.Length.ToString());
           
            return result;


        }

    }
}

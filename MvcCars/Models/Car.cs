using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Pojemnosc { get; set; }
        public int Moc { get; set; }
        public int Rocznik { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCars.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcCars.Data
{
    public class MvcCarsContext : DbContext
    {
        public MvcCarsContext(DbContextOptions<MvcCarsContext> options) : base(options) { }
        public DbSet<Car> Car { get; set; }

    }
}

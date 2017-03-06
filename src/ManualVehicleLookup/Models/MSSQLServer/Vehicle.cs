using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ManualVehicleLookup.Models.MSSQLServer
{
    public class Vehicle : DbContext
    {
        public Vehicle(DbContextOptions<Vehicle> options)
            : base(options)
        { }
    }
}

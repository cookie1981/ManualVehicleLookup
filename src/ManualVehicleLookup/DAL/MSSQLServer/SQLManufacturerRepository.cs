using System;
using System.Collections.Generic;
using ManualVehicleLookup.Models;
using Microsoft.EntityFrameworkCore;
using Vehicle = ManualVehicleLookup.Models.MSSQLServer.Vehicle;

namespace ManualVehicleLookup.DAL
{
    public class SQLManufacturerRepository : DbContext, IManufacturerRepository
    {
//        private const string tableName = "Vehicles";

//        public SQLManufacturerRepository()
//        {
//        }

        public List<string> GetAllManufacturers()
        {
            //            DbSet<Vehicle> Vehicles;
            throw new NotImplementedException();
        }

        public List<string> GetAllManufacturers(string productClass)
        {
            throw new NotImplementedException();
        }
    }
}

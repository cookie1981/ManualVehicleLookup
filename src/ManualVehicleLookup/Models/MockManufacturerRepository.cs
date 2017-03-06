using System.Collections.Generic;

namespace ManualVehicleLookup.Models
{
    public class MockManufacturerRepository : IManufacturerRepository
    {
        public List<string> GetAllManufacturers()
        {
            return new List<string>()
            {
                "Alfa Romeo",
                "Aston Martin",
                "BMW",
                "Ford",
                "Honda"
            };
        }

        public List<string> GetAllManufacturers(string productClass)
        {
            return new List<string>()
            {
                "Alfa Romeo",
                "Aston Martin",
                "BMW",
                "Ford",
                "Honda"
            };
        }
    }
}

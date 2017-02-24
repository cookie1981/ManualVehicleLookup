using System.Collections.Generic;

namespace ManualVehicleLookup.Models
{
    public class MockManufacturerRepository : IManufacturerRepository
    {
        public List<string> GetAllManufactureres()
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

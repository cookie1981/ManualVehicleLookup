using System.Collections.Generic;

namespace ManualVehicleLookup.Models
{
    public class MockManufacturerModelRepository : IManufacturerModelRepository
    {
        public List<string> LoopupModelsByManufacturer(string manufacturerName)
        {
            if (manufacturerName == "ford")
            {
                return new List<string>()
                {
                    "B-max",
                    "C-max",
                    "Escort",
                    "Fiesta",
                    "Focus"
                };
            }

            return new List<string>()
            {
                "Accord",
                "Civic",
                "Jazz"
            };
        }
    }
}

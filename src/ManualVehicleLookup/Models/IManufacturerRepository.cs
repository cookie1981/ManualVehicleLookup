using System.Collections.Generic;

namespace ManualVehicleLookup.Models
{
    public interface IManufacturerRepository
    {
        List<string> GetAllManufactureres();
    }
}
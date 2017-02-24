using System.Collections.Generic;

namespace ManualVehicleLookup.Models
{
    public interface IManufacturerModelRepository
    {
        List<string> LoopupModelsByManufacturer(string manufacturerName);
    }
}
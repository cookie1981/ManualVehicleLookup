using Microsoft.AspNetCore.Mvc;

namespace ManualVehicleLookup.Models
{
    [Route("api/manufacturer")]
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerController(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_manufacturerRepository.GetAllManufactureres());
        }
    }
}
using ManualVehicleLookup.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManualVehicleLookup.Controllers
{
    [Route("api/model")]
    public class ModelController : Controller
    {
        private readonly IManufacturerModelRepository _modelRepository;

        public ModelController(IManufacturerModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        [HttpGet("{manufacturer}")]
        public JsonResult GetModelsByManufacturer(string manufacturer)
        {
            return new JsonResult( _modelRepository.LoopupModelsByManufacturer(manufacturer));
        }
    }
}
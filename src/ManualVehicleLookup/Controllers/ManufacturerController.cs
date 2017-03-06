using ManualVehicleLookup.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManualVehicleLookup.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerController(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        //        [HttpGet]
        [Route("api/manufacturer/getall")]
        public JsonResult GetAll()
        {
            return new JsonResult(_manufacturerRepository.GetAllManufacturers());
        }

        //        [HttpGet]
        [Route("api/manufacturer/getallbyproductclass/{productClass}")]
        public JsonResult GetAllByProductClass(string productClass)
        {
            return new JsonResult(_manufacturerRepository.GetAllManufacturers(productClass));
        }
    }
}
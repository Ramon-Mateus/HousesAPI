using Microsoft.AspNetCore.Mvc;
using HousesAPI.Contexts;
using HousesAPI.Models;

namespace HousesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly HouseContext _context;

        public HousesController(HouseContext context) => _context = context;

        [HttpGet]
        public ActionResult<List<House>> GetAllHouses()
        {
            var houses = _context.Houses.ToList();
            return houses;
        }

        [HttpGet("{id}")]
        public ActionResult<House> GetHouse(int id)
        {
            var house = _context.Houses.FirstOrDefault(house => house.Id == id);
            
            if (house == null) return NotFound();
            return house;
        }
    }
}

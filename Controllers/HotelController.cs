using Elekta.Model;
using Elekta.Service;
using Microsoft.AspNetCore.Mvc;


namespace Elekta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {            
            _hotelService = hotelService;
        }

        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return _hotelService.Get();
        }

        [HttpGet("search")]
        public IEnumerable<Hotel>? Search(string name)
        {
            if (string.IsNullOrEmpty(name)) { return null; }
            return _hotelService.Search(name) ?? null;
        }
    }
}

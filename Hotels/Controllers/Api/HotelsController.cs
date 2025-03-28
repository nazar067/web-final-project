using Hotels.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Hotels.Controllers.Api
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class HotelsApiController : ControllerBase
    {
        private readonly HotelsContext _context;

        public HotelsApiController(HotelsContext context)
        {
            _context = context;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotels()
        {
            return _context.Hotels.ToList();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);
            if (hotel == null)
                return NotFound();

            return hotel;
        }
    }
}

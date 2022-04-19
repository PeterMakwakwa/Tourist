using Microsoft.AspNetCore.Mvc;
using Tourist.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tourist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IIteamService iteamService;

        public ItemController(IIteamService iteamService)
        {
            this.iteamService = iteamService;
        }
        // GET: api/<ItemController>
        [HttpGet("GetTouristAllowedCarriedIteams")]
        public IActionResult GetTouristAllowedCarriedIteams()
        {
            return Ok(iteamService.MaximumkValidNapsackDetails());
        }

        //// GET api/<ItemController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ItemController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ItemController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ItemController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}



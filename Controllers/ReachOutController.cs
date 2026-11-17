using Microsoft.AspNetCore.Mvc;
using MUTALE_VE.Data;
using MUTALE_VE.Models;
using MUTALE_VE.ViewModels;



namespace MUTALE_VE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReachOutController : ControllerBase
    {
        private readonly AppDbContext _context;
        private ReachOuts value;

        public ReachOutController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ReachOutController>
        [HttpGet]
        public IEnumerable<Models.ReachOuts> Get()
        {
            return _context.ReachOuts.ToList();
        }

        // GET api/<ReachOutController>/5
        // [HttpGet("{getReachOut}")]
        // public Models.ReachOuts Get(int id)
        // {
        //     return _context.ReachOuts.Find(id);
        // }

        // POST api/<ReachOutController>
        [HttpPost("CreateReachout")]
        public IActionResult CreateReachout([FromBody] Models.ReachOuts vm)
        {
            try
            {
                var reachOut = new ReachOuts
                {
                    Name = vm.Name,
                    Email = vm.Email,
                    Date = DateTime.Now,
                    Message = vm.Message,
                    Phone = vm.Phone
                };

                _context.ReachOuts.Add(reachOut);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error. Please contact support.");
            }

        }
        // PUT api/<ReachOutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReachOutController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;
using Vehicle_tracking_App.RepositoryPattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle_tracking_App.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehicalController : ControllerBase
    {
        private readonly ILogger<VehicalController> _logger;
        private readonly IVehicalService _vehicalService;
        private readonly IMapper _mapper;

        public VehicalController(ILogger<VehicalController> logger, IVehicalService vehicalService, IMapper mapper)
        {
            _logger = logger;
            _vehicalService = vehicalService;
            _mapper = mapper;
        }


        // GET: api/<VehicalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VehicalController>/5
        [HttpGet]
        public async Task<IEnumerable<VehicalDto>> GetVehicalsByUserId(int userId)
        {   
            var vehicals = await _vehicalService.GetVehicals(userId);
            return vehicals;
        }

        // POST api/<VehicalController>
        [HttpPost]
        public async Task CreateVehical( VehicalDto vehical )
        {
            var vehicalmap = _mapper.Map<UseVehicleDetails>(vehical);
             await _vehicalService.CreateAsync(vehicalmap);
        }

        // PUT api/<VehicalController>/5
        [HttpPut("{id}")]
        public void UpdateVehical(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicalController>/5
        [HttpDelete("{id}")]
        public async Task DeleteVehical(int id)
        {
           await _vehicalService.SoftDelete(id);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;
using Vehicle_tracking_App.RepositoryPattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle_tracking_App.Controllers
{
    [Route("api/[controller]/action")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserAppservices _userAppservices;
        private readonly IMapper _mapper;

        public UserController(ILogger<WeatherForecastController> logger, IUserAppservices userAppservices, IMapper mapper)
        {
            _logger = logger;
            _userAppservices = userAppservices;
            _mapper = mapper;
        }
       
        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetAsync()
        {
            var abc = await _userAppservices.GetAllAsync<UserDto>();
            return abc;

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task PostAsync(UserDto value)
        {
            var account = _mapper.Map<Users>(value);
            await _userAppservices.CreateAsync(account);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

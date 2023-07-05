using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;
using Vehicle_tracking_App.RepositoryPattern;
using Vehicle_tracking_App.UserExceptions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle_tracking_App.Controllers
{
    [Route("api/[controller]/[action]")]
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
        public async Task<IEnumerable<UserDto>> GetAllUserAsync()
        {
            var abc = await _userAppservices.GetAllAsync<UserDto>();
            return abc;

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _userAppservices.GetByIdAsync<UserDto>(id);
            if(user == null)
            {
                return null;
            }
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task CreateUserAsync(UserDto value)
        {
            var account = _mapper.Map<Users>(value);
            await _userAppservices.CreateAsync(account);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void UpdateUserAsync(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
        }

        [HttpGet]
        public async Task<LoginResponce> Login(string Email, string password)
        {

            try
            {
                var user = await _userAppservices.LoginAsync(Email, password);
                return new LoginResponce() { Result = user, error = null };
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);

                return new LoginResponce() { Result = null, error = "Invalid Username or Password" };
                //throw new UserFriendlyException("Invalid Username or Password");
            }

        }


    }
    }

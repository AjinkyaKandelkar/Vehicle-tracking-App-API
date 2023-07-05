using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vehicle_tracking_App.Data_Access;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;
using Vehicle_tracking_App.Repository;

namespace Vehicle_tracking_App.RepositoryPattern
{
    public class UserAppService : Repository<Users>, IUserAppservices
    {
        private readonly VehicletrackingContext _db;
        private readonly IMapper _mapper;

        public UserAppService(VehicletrackingContext db, IMapper mapper) : base(db, mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<UserDto> LoginAsync(string username, string password)
        {
            var result =await _db.Users.FirstOrDefaultAsync(x=>x.EmailAddress == username && x.password == password);
            if(result != null)
            {
                return  _mapper.Map<UserDto>(result);
            }
            return null;
        }


    }

    public interface IUserAppservices : IRepository<Users>
    {
        Task<UserDto> LoginAsync(string username, string password);

    }
}

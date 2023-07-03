using AutoMapper;
using Vehicle_tracking_App.Data_Access;
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


    }

    public interface IUserAppservices : IRepository<Users>
    {

    }
}

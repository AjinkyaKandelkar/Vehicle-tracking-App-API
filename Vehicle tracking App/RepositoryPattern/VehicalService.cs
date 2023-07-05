using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vehicle_tracking_App.Data_Access;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;
using Vehicle_tracking_App.Repository;

namespace Vehicle_tracking_App.RepositoryPattern
{
    public class VehicalService : Repository<UseVehicleDetails> ,IVehicalService
    {
        private readonly VehicletrackingContext _db;
        
        private readonly IMapper _mapper;

        public VehicalService(VehicletrackingContext db, IMapper mapper) : base(db, mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<VehicalDto>> GetVehicals(int id)
        {
            var vehicals = await _db.UseVehicleDetails.Where(x => x.UserID == id && !x.IsDelete).ToListAsync();

            return _mapper.Map<List<VehicalDto>>(vehicals);
        }

        public async Task SoftDelete(int id)
        {
            var vehicals = await _db.UseVehicleDetails.FirstOrDefaultAsync(x => x.UserID == id);
            vehicals.IsDelete = true;
            await _db.SaveChangesAsync();
                 
        }

    }
    public interface IVehicalService : IRepository<UseVehicleDetails>
    {
        Task<List<VehicalDto>> GetVehicals(int id);
        Task SoftDelete(int id);

    }
}

using AutoMapper;
using Vehicle_tracking_App.Data_Access.DTO;
using Vehicle_tracking_App.Data_Access.Model;

namespace Vehicle_tracking_App
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UserDto>().ReverseMap();
            CreateMap<UseVehicleDetails, VehicalDto>().ReverseMap();
        }
    }
}

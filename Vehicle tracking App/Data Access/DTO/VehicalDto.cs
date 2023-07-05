using System.ComponentModel.DataAnnotations.Schema;
using Vehicle_tracking_App.Data_Access.Model;

namespace Vehicle_tracking_App.Data_Access.DTO
{
    public class VehicalDto:ViewModelBase
    {
        public string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public long Manufacturingyear { get; set; }
        public long Loadcarryingcapacity { get; set; }
        public string Makeofvehicle { get; set; }
        public string ModelNumber { get; set; }
        public Bodytype Bodytype { get; set; }
        public string Organisationname { get; set; }

        public int DeviceId { get; set; }

        public int UserID { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_tracking_App.Data_Access.Model
{
    [Table("UseVehicleDetails")]
    public class UseVehicleDetails : DataModelBase
    {

        public string VehicleNumber { get; set; }
        public VehicleType VehicleType  { get; set; }
        public string ChassisNumber  { get; set; }
        public string EngineNumber  { get; set; }
        public long Manufacturingyear  { get; set; }
        public long Loadcarryingcapacity   { get; set; }
        public long Makeofvehicle { get; set; }
        public long ModelNumber  { get; set; }
        public Bodytype Bodytype   { get; set; }
        public string Organisationname    { get; set; }
        public int DeviceId { get; set; }
        [ForeignKey( nameof(DeviceId))]
        public Device Device { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public Users Users { get; set; }


    }
}

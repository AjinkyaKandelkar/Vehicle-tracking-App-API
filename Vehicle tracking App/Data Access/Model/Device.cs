using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_tracking_App.Data_Access.Model
{
    [Table("Devices")]
    public class Device : DataModelBase
    {
        public string DeviceId { get; set; }
        public string MACAddress { get; set; }
      
    }
}

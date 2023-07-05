using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_tracking_App.Data_Access.Model
{
    [Table ("Users")]
    public class Users : DataModelBase
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Localtion { get; set; }
        public string? photopath { get; set; }
        public string password { get; set; }
    }
}

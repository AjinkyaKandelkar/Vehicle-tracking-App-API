namespace Vehicle_tracking_App.Data_Access.DTO
{
    public class UserDto :ViewModelBase
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Localtion { get; set; }
        public string photopath { get; set; }
       
    }
}

namespace Repair1.models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string RequestName { get; set; }
        public string Description { get; set; }
        public int ServiceID { get; set; }
        public int StaffId { get; set; }
        public int ClientId { get; set; } 
    }
}

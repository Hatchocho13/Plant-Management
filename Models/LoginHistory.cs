using System;

namespace PlantManagement.Models
{
    public class LoginHistory
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime LoginTime { get; set; }
        public string IPAddress { get; set; }
    }
}

using System;

namespace PlantManagement.Models
{
    public class CoSoSanXuat
    {
        public int ID { get; set; }
        public string TenCS { get; set; }
        public string ViTri { get; set; } // WKT cho GEOGRAPHY
        public int ID_Xa { get; set; }
    }
}

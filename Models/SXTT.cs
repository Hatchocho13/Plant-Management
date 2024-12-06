using System;

namespace PlantManagement.Models
{
    public class SXTT
    {
        public int ID { get; set; }
        public bool CSAnToanVietGap { get; set; }
        public string VungTrong { get; set; } // WKT (Well-Known Text) cho GEOGRAPHY
        public string SinhVatGayHai { get; set; }
        public int ID_Xa { get; set; }
    }
}


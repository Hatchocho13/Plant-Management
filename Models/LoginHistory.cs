using System;

public class LoginHistory
{
    public int ID { get; set; } // Khóa chính
    public int UserID { get; set; } // ID người dùng
    public DateTime LoginTime { get; set; } // Thời gian đăng nhập
    public string IPAddress { get; set; } // Địa chỉ IP
}

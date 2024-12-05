using PlantManagement.Models;

namespace PlantManagement.Controllers
{
    public class LoginController
    {
        public bool AuthenticateUser(User user)
        {
            // Kiểm tra đăng nhập (có thể thay thế bằng cơ sở dữ liệu)
            return user.Username == "admin" && user.Password == "admin";
        }
    }
}

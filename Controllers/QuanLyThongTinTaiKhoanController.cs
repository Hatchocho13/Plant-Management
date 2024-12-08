using System;
using System.Collections.Generic;
using System.Linq;
using PlantManagement.Models;

namespace PlantManagement.Controllers
{
    public class QuanLyThongTinTaiKhoanController
    {
        private List<User> _users;
        private List<Role> _roles;
        private List<UserGroup> _groups;

        public QuanLyThongTinTaiKhoanController()
        {
            // Dữ liệu mẫu, có thể thay bằng truy vấn từ cơ sở dữ liệu
            _users = new List<User>
            {
                new User { ID = 1, UserName = "admin", FullName = "Quản trị viên", Email = "admin@example.com", Password = "admin123", IsActive = true, CreatedAt = DateTime.Now, ID_Group = 1 },
                new User { ID = 2, UserName = "user1", FullName = "Nguyễn Văn A", Email = "user1@example.com", Password = "user123", IsActive = true, CreatedAt = DateTime.Now, ID_Group = 2 }
            };

            _roles = new List<Role>
            {
                new Role { ID = 1, RoleName = "Admin" },
                new Role { ID = 2, RoleName = "User" }
            };

            _groups = new List<UserGroup>
            {
                new UserGroup { ID = 1, GroupName = "Quản trị viên" },
                new UserGroup { ID = 2, GroupName = "Nhân viên" }
            };
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserByID(int id)
        {
            return _users.FirstOrDefault(u => u.ID == id);
        }

        public bool UpdateUserPassword(int userID, string oldPassword, string newPassword)
        {
            var user = _users.FirstOrDefault(u => u.ID == userID && u.Password == oldPassword);
            if (user != null)
            {
                user.Password = newPassword;
                return true;
            }
            return false;
        }

        public List<Role> GetUserRoles(int userID)
        {
            // Giả sử mỗi người dùng chỉ có một vai trò
            return _roles.Where(r => _users.Any(u => u.ID == userID && u.ID_Group == r.ID)).ToList();
        }
    }
}

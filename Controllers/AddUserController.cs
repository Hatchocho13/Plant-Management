using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PlantManagement.Helpers;
using PlantManagement.Models;

namespace PlantManagement.Controllers
{
    public class AddUserController
    {
        private readonly DatabaseHelper _dbHelper;

        // Constructor để khởi tạo đối tượng DatabaseHelper
        public AddUserController()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Phương thức lấy danh sách tên vai trò từ cơ sở dữ liệu
        public List<string> GetRoleNames()
        {
            List<string> roleNames = new List<string>();
            string query = "SELECT DISTINCT RoleName FROM Role";  // Sử dụng DISTINCT để chỉ lấy các vai trò không trùng lặp

            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu dưới dạng DataTable
                DataTable data = _dbHelper.ExecuteQuery(query, null);

                // Duyệt qua các dòng trong DataTable và lấy RoleName
                foreach (DataRow row in data.Rows)
                {
                    roleNames.Add(row["RoleName"].ToString()); // Lấy tên vai trò từ cột "RoleName"
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách vai trò: {ex.Message}");
            }

            return roleNames;
        }

        // Phương thức thêm người dùng mới vào cơ sở dữ liệu
        public bool AddUser(User user, string roleName)
        {
            // Kiểm tra tính hợp lệ của thông tin người dùng
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.FullName) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(roleName))
            {
                throw new ArgumentException("Tên người dùng, mật khẩu, họ tên, email và vai trò không thể rỗng.");
            }

            // Lấy RoleId từ bảng Role theo RoleName
            string roleIdQuery = "SELECT TOP 1 RoleId FROM Role WHERE RoleName = @RoleName";  // Sử dụng TOP 1 để lấy một RoleId duy nhất
            SqlParameter[] roleParameters = new SqlParameter[] {
                new SqlParameter("@RoleName", roleName)
            };

            int roleId = -1;
            try
            {
                roleId = Convert.ToInt32(_dbHelper.ExecuteScalar(roleIdQuery, roleParameters));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy RoleId: {ex.Message}");
                return false;
            }

            // Nếu không tìm thấy RoleId, trả về false
            if (roleId == -1)
            {
                Console.WriteLine("Không tìm thấy vai trò.");
                return false;
            }

            // Câu lệnh SQL để chèn người dùng mới vào bảng Users
            string query = "INSERT INTO Users (UserName, FullName, Password, Email, RoleId) " +
                           "VALUES (@UserName, @FullName, @Password, @Email, @RoleId)";

            // Tạo mảng các đối tượng SqlParameter
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@RoleId", roleId)
            };

            // Thực thi câu lệnh SQL thông qua DatabaseHelper
            try
            {
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; // Nếu thêm thành công, trả về true
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm người dùng: {ex.Message}");
                return false;
            }
        }
    }
}

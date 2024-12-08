using System;
using System.Data;
using System.Data.SqlClient;
using PlantManagement.Helpers;

namespace PlantManagement.Controllers
{
    public class LoginController
    {
        private readonly DatabaseHelper _dbHelper;

        public LoginController()
        {
            _dbHelper = new DatabaseHelper(); // Khởi tạo DatabaseHelper
        }

        // Phương thức xác thực người dùng (Đăng nhập)
        public User AuthenticateUser(string username, string password)
        {
            const string query = @"
                SELECT ID, UserName, FullName, [Password], Email, IsActive, CreatedAt, ID_Group
                FROM [User] 
                WHERE UserName = @UserName";

            var parameters = new[]
            {
                new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = username }
            };

            var dataTable = _dbHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                var user = new User
                {
                    ID = Convert.ToInt32(row["ID"]),
                    UserName = row["UserName"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Password = row["Password"].ToString(),
                    Email = row["Email"].ToString(),
                    IsActive = Convert.ToBoolean(row["IsActive"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    ID_Group = Convert.ToInt32(row["ID_Group"]) 
                };

                // So sánh mật khẩu (Nếu cần bảo mật, sử dụng phương thức mã hóa mật khẩu)
                if (user.IsActive && password == user.Password) // Cần mã hóa mật khẩu trong thực tế
                {
                    return user;  // Đăng nhập thành công
                }
            }

            return null;  // Đăng nhập thất bại
        }

        // Phương thức lấy mật khẩu theo username và email (cho chức năng quên mật khẩu)
        public string GetPasswordByUsernameAndEmail(string username, string email)
        {
            const string query = @"
                SELECT [Password]
                FROM [User]
                WHERE UserName = @UserName AND Email = @Email";

            var parameters = new[]
            {
                new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email }
            };

            var dataTable = _dbHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["Password"].ToString();  // Trả về mật khẩu
            }

            return null;  // Không tìm thấy người dùng hoặc email không đúng
        }
    }
}

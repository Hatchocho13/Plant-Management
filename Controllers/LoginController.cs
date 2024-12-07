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
            _dbHelper = new DatabaseHelper();
        }

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

                // Tạo đối tượng User từ dữ liệu trong bảng
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

                // So sánh mật khẩu (không mã hóa)
                if (user.IsActive && password == user.Password)
                {
                    return user; // Trả về đối tượng User nếu đăng nhập thành công
                }
            }

            return null; // Trả về null nếu không tìm thấy người dùng hoặc mật khẩu sai
        }
    }
}

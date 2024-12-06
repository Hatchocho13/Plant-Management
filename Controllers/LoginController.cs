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

        public bool AuthenticateUser(string username, string password)
        {
            const string query = @"
                SELECT PasswordHash, IsActive 
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
                var passwordHash = row["PasswordHash"].ToString();
                var isActive = Convert.ToBoolean(row["IsActive"]);

                return isActive && password == passwordHash;
            }

            return false;
        }
    }
}

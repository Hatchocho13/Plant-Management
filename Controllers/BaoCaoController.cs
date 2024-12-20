using System;
using System.Collections.Generic;
using System.Data;
using PlantManagement.Helpers;

namespace PlantManagement.Controllers
{
    public class BaoCaoController
    {
        private readonly DatabaseHelper _dbHelper;

        public BaoCaoController()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Lấy danh sách người dùng từ cơ sở dữ liệu
        public List<User> GetUserList()
        {
            var userList = new List<User>();

            try
            {
                string query = @"
                    SELECT 
                        u.ID,
                        u.UserName,
                        u.FullName,
                        u.Email,
                        u.IsActive,
                        u.CreatedAt,
                        u.ID_Group
                    FROM [User] u
                    ORDER BY u.UserName";

                using (var dataTable = _dbHelper.ExecuteQuery(query))
                {
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var user = new User
                            {
                                ID = Convert.ToInt32(row["ID"]),
                                UserName = row["UserName"].ToString(),
                                FullName = row["FullName"].ToString(),
                                Email = row["Email"].ToString(),
                                IsActive = Convert.ToBoolean(row["IsActive"]),
                                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                                ID_Group = Convert.ToInt32(row["ID_Group"])
                            };

                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user list: {ex.Message}");
            }

            return userList;
        }
    }
}

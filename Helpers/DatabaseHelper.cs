using System;
using System.Data;
using System.Data.SqlClient;

namespace PlantManagement.Helpers
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            _connectionString = "Server=DESKTOP-ICACP6G\\SQLEXPRESS;Database=QuanLyTrongTrot;Trusted_Connection=True;";
        }

        // Phương thức mở kết nối
        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Phương thức thực thi truy vấn trả về DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var dataTable = new DataTable();
                var adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                return dataTable;
            }
        }
    }
}

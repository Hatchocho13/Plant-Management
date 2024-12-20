using System;
using System.Data;
using System.Data.SqlClient;
using PlantManagement.Helpers;

namespace PlantManagement.Controllers
{
    public class DonViHanhChinhController
    {
        private readonly DatabaseHelper _dbHelper;

        public DonViHanhChinhController()
        {
            _dbHelper = new DatabaseHelper();
        }

        public DataTable GetDanhMucHuyen()
        {
            try
            {
                string query = "SELECT * FROM DonViHanhChinh WHERE ID_Cap = 1";
                DataTable dt = _dbHelper.ExecuteQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching Huyen data: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }

        public DataTable GetDanhMucXa()
        {
            try
            {
                string query = "SELECT * FROM DonViHanhChinh WHERE ID_Cap = 2";
                DataTable dt = _dbHelper.ExecuteQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching Xa data: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }

        public DataTable TimKiemHuyen(string keyword)
        {
            try
            {
                string query = "SELECT * FROM DonViHanhChinh WHERE ID_Cap = 1 AND TenDVHC LIKE @Keyword";
                var parameters = new[]
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = $"%{keyword}%" }
                };
                DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while searching Huyen: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }

        public DataTable TimKiemXa(string keyword)
        {
            try
            {
                string query = "SELECT * FROM DonViHanhChinh WHERE ID_Cap = 2 AND TenDVHC LIKE @Keyword";
                var parameters = new[]
                {
                    new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = $"%{keyword}%" }
                };
                DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while searching Xa: {ex.Message}");
                return new DataTable(); // Return empty DataTable in case of error
            }
        }
    }
}

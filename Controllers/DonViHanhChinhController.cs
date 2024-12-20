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

        // Lấy danh sách cấp hành chính
        public DataTable GetDanhMucCap()
        {
            try
            {
                string query = "SELECT * FROM Cap";  // Truy vấn tất cả các cấp hành chính
                DataTable dt = _dbHelper.ExecuteQuery(query);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching Cap data: {ex.Message}");
                return new DataTable(); // Trả về DataTable rỗng trong trường hợp lỗi
            }
        }

        // Lấy danh sách đơn vị hành chính theo cấp (cấp 1: huyện, cấp 2: xã)
        public DataTable GetDanhMucDonViHanhChinh(int capId)
        {
            try
            {
                string query = @"
                    SELECT D.ID, D.TenDVHC, C.TenCap, D.parent_id
                    FROM DonViHanhChinh D
                    JOIN Cap C ON D.ID_Cap = C.ID
                    WHERE D.ID_Cap = @CapId"; // Lọc theo cấp hành chính
                var parameters = new[] 
                {
                    new SqlParameter("@CapId", SqlDbType.Int) { Value = capId }
                };
                DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching DonViHanhChinh data: {ex.Message}");
                return new DataTable(); // Trả về DataTable rỗng trong trường hợp lỗi
            }
        }

        // Lấy danh sách xã theo huyện (Lấy xã theo parent_id)
        public DataTable GetDanhMucXaByHuyen(int huyenId)
        {
            try
            {
                string query = @"
                    SELECT D.ID, D.TenDVHC, C.TenCap
                    FROM DonViHanhChinh D
                    JOIN Cap C ON D.ID_Cap = C.ID
                    WHERE D.parent_id = @HuyenId AND D.ID_Cap = 3"; // Cấp 2 là xã
                var parameters = new[] 
                {
                    new SqlParameter("@HuyenId", SqlDbType.Int) { Value = huyenId }
                };
                DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching Xa data: {ex.Message}");
                return new DataTable(); // Trả về DataTable rỗng trong trường hợp lỗi
            }
        }

        // Thêm đơn vị hành chính mới
        public bool AddDonViHanhChinh(string tenDVHC, int capId, int parentId)
        {
            try
            {
                string query = @"
                    INSERT INTO DonViHanhChinh (TenDVHC, ID_Cap, parent_id)
                    VALUES (@TenDVHC, @CapId, @ParentId)";
                var parameters = new[]
                {
                    new SqlParameter("@TenDVHC", SqlDbType.NVarChar) { Value = tenDVHC },
                    new SqlParameter("@CapId", SqlDbType.Int) { Value = capId },
                    new SqlParameter("@ParentId", SqlDbType.Int) { Value = parentId }
                };
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; // Trả về true nếu thêm thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding DonViHanhChinh: {ex.Message}");
                return false; // Trả về false trong trường hợp lỗi
            }
        }

        // Sửa đơn vị hành chính
        public bool UpdateDonViHanhChinh(int id, string tenDVHC, int capId, int parentId)
        {
            try
            {
                string query = @"
                    UPDATE DonViHanhChinh
                    SET TenDVHC = @TenDVHC, ID_Cap = @CapId, parent_id = @ParentId
                    WHERE ID = @Id";
                var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = id },
                    new SqlParameter("@TenDVHC", SqlDbType.NVarChar) { Value = tenDVHC },
                    new SqlParameter("@CapId", SqlDbType.Int) { Value = capId },
                    new SqlParameter("@ParentId", SqlDbType.Int) { Value = parentId }
                };
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; // Trả về true nếu sửa thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating DonViHanhChinh: {ex.Message}");
                return false; // Trả về false trong trường hợp lỗi
            }
        }

        // Xóa đơn vị hành chính
        public bool DeleteDonViHanhChinh(int id)
        {
            try
            {
                string query = "DELETE FROM DonViHanhChinh WHERE ID = @Id";
                var parameters = new[]
                {
                    new SqlParameter("@Id", SqlDbType.Int) { Value = id }
                };
                int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting DonViHanhChinh: {ex.Message}");
                return false; // Trả về false trong trường hợp lỗi
            }
        }
    }
}
   

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace PlantManagement.Views
{
    public partial class QuanLyThongTinTaiKhoanView : UserControl
    {
        public ObservableCollection<UserAccount> Accounts { get; set; }

        public QuanLyThongTinTaiKhoanView()
        {
            InitializeComponent();
            Accounts = new ObservableCollection<UserAccount>();
            this.DataContext = this;

            LoadAccountData();
        }

        private void LoadAccountData()
        {
            string connectionString = "Server=DESKTOP-ICACP6G\\SQLEXPRESS;Database=QuanLyTrongTrot;Trusted_Connection=True;"; // Thay bằng chuỗi kết nối của bạn
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT 
                    U.ID,
                    U.UserName,
                    U.FullName,
                    U.Email,
                    U.CreatedAt,
                    UG.GroupName, -- Lấy GroupName thay vì ID_Group
                    U.IsActive
                FROM [User] U
                JOIN UserGroup UG ON U.ID_Group = UG.ID"; // Kết nối với bảng UserGroup để lấy GroupName

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Accounts.Add(new UserAccount
                    {
                        ID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        FullName = reader.GetString(2),
                        Email = reader.IsDBNull(3) ? null : reader.GetString(3), // Kiểm tra nếu Email là null
                        CreatedAt = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4), // Kiểm tra nếu CreatedAt là null
                        GroupName = reader.GetString(5), // Lấy GroupName từ câu truy vấn
                        IsActive = reader.GetBoolean(6)
                    });
                }
            }
        }
    }

    public class UserAccount
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; } // Sử dụng nullable DateTime
        public string GroupName { get; set; } // Thêm thuộc tính GroupName
    }
}

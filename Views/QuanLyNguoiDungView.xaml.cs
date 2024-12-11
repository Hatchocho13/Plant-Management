using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace PlantManagement.Views
{
    public partial class QuanLyNguoiDungView : UserControl
    {
        public ObservableCollection<UserAccount> Accounts { get; set; }
        public UserAccount SelectedAccount { get; set; } // Tài khoản được chọn
        public bool IsAdmin { get; set; } = true; // Đặt cờ để xác định quyền Admin

        public QuanLyNguoiDungView()
        {
            InitializeComponent();
            Accounts = new ObservableCollection<UserAccount>();
            this.DataContext = this;

            LoadAccountData();
        }

        private void LoadAccountData()
        {
            string connectionString = "Server=DESKTOP-ICACP6G\\SQLEXPRESS;Database=QuanLyTrongTrot;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = IsAdmin
                    ? @"SELECT U.ID, U.UserName, U.FullName, U.Email, U.CreatedAt, UG.GroupName, U.IsActive, U.Password
                         FROM [User] U
                         JOIN UserGroup UG ON U.ID_Group = UG.ID"
                    : @"SELECT U.ID, U.UserName, U.FullName, U.Email, U.CreatedAt, UG.GroupName, U.IsActive
                         FROM [User] U
                         JOIN UserGroup UG ON U.ID_Group = UG.ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var account = new UserAccount
                    {
                        ID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        FullName = reader.GetString(2),
                        Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                        CreatedAt = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        GroupName = reader.GetString(5),
                        IsActive = reader.GetBoolean(6)
                    };

                    if (IsAdmin && !reader.IsDBNull(7))
                    {
                        account.Password = reader.GetString(7);
                    }

                    Accounts.Add(account);
                }
            }
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DESKTOP-ICACP6G\\SQLEXPRESS;Database=QuanLyTrongTrot;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var account in Accounts)
                {
                    string updateQuery = @"UPDATE [User]
                                           SET UserName = @UserName, 
                                               FullName = @FullName, 
                                               Email = @Email, 
                                               IsActive = @IsActive" +
                                           (IsAdmin ? ", Password = @Password" : "") +
                                           " WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", account.ID);
                    cmd.Parameters.AddWithValue("@UserName", account.UserName);
                    cmd.Parameters.AddWithValue("@FullName", account.FullName);
                    cmd.Parameters.AddWithValue("@Email", (object)account.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", account.IsActive);
                    if (IsAdmin)
                        cmd.Parameters.AddWithValue("@Password", account.Password);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra nếu không có tài khoản được chọn
            if (SelectedAccount == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string connectionString = "Server=DESKTOP-ICACP6G\\SQLEXPRESS;Database=QuanLyTrongTrot;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Xoá tài khoản khỏi cơ sở dữ liệu
                string deleteQuery = "DELETE FROM [User] WHERE ID = @ID";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@ID", SelectedAccount.ID);
                deleteCmd.ExecuteNonQuery();
            }

            // 2. Xóa tài khoản khỏi danh sách trong giao diện
            Accounts.Remove(SelectedAccount);
            SelectedAccount = null;

            // Thông báo xóa tài khoản thành công
            MessageBox.Show("Tài khoản đã được xóa thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    public class UserAccount
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string GroupName { get; set; }
        public string Password { get; set; } // Mật khẩu, chỉ sử dụng cho Admin
    }
}

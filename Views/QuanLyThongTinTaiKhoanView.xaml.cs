using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PlantManagement.Controllers;
using PlantManagement.Models;

namespace PlantManagement.Views
{
    public partial class QuanLyThongTinTaiKhoanView : UserControl
    {
        private readonly QuanLyThongTinTaiKhoanController _controller;
        private readonly bool _isAdmin;  // Biến xác định nếu người dùng là admin

        public QuanLyThongTinTaiKhoanView(bool isAdmin)
        {
            InitializeComponent();

            _isAdmin = isAdmin;

            // Khởi tạo controller để lấy dữ liệu
            _controller = new QuanLyThongTinTaiKhoanController();

            // Lấy danh sách người dùng từ controller và gán vào DataGrid
            List<User> users = _controller.GetAllUsers();
            UserDataGrid.ItemsSource = users;

            // Cập nhật cột mật khẩu nếu người dùng là admin
            if (!_isAdmin)
            {
                PasswordColumn.Visibility = Visibility.Collapsed; // Ẩn mật khẩu nếu không phải admin
            }
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin người dùng đang được chọn trong DataGrid
            var selectedUser = (User)UserDataGrid.SelectedItem;
            if (selectedUser != null)
            {
                // Tạo cửa sổ mới để thay đổi mật khẩu và truyền userID
                var changePasswordWindow = new ChangePasswordWindow(selectedUser.ID); 
                changePasswordWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng cần thay đổi mật khẩu.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UserDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Logic xử lý khi lựa chọn người dùng trong DataGrid
        }
    }
}

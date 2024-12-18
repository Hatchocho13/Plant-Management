﻿using System.Windows;
using PlantManagement.Controllers;
using PlantManagement.Views;

namespace PlantManagement.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainController _controller;
        private bool _isAdmin; // Biến _isAdmin xác định nếu người dùng là Admin
        private bool _isAccountPageVisible = false;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new MainController();
            _isAdmin = false; // Mặc định là không phải admin
        }

        // Khi nhấn vào nút Đăng Nhập
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                // Giả sử nếu người dùng đăng nhập thành công và là Admin
                _isAdmin = true;
                LoadMainUI();
                UpdateUserName("Admin"); // Tên người dùng có thể thay đổi sau khi xác thực đăng nhập
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng thử lại.");
            }
        }

        // Khi nhấn vào nút Đăng Ký
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }

        // Tải giao diện sau khi đăng nhập thành công
        private void LoadMainUI()
        {
            // Ẩn giao diện đăng nhập và hiển thị giao diện chính
            InitialPanel.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
        }

        // Cập nhật tên người dùng khi đăng nhập thành công
        private void UpdateUserName(string userName)
        {
            // Thay đổi tên người dùng hiển thị (nếu cần)
        }

        // Khi nhấn vào nút "My Account"
        private void MyAccountButton_Click(object sender, RoutedEventArgs e)
        {
            if (_isAccountPageVisible)
            {
                // Nếu trang "My Account" đang hiển thị, ẩn trang và quay lại giao diện chính
                MainContent.Content = null; // Xóa nội dung trang hiện tại
                _isAccountPageVisible = false; // Đánh dấu là trang không còn hiển thị
            }
            else
            {
                // Nếu trang "My Account" chưa hiển thị, hiển thị trang
                QuanLyThongTinTaiKhoanView accountView = new QuanLyThongTinTaiKhoanView();
                MainContent.Content = accountView; // Thêm UserControl vào ContentControl
                _isAccountPageVisible = true; // Đánh dấu trang "My Account" đang hiển thị
            }
        }

        // Các sự kiện khi nhấn vào các nút tính năng
        private void ManageUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (_isAccountPageVisible)
            {
                // Nếu trang "My Account" đang hiển thị, ẩn trang và quay lại giao diện chính
                MainContent.Content = null; // Xóa nội dung trang hiện tại
                _isAccountPageVisible = false; // Đánh dấu là trang không còn hiển thị
            }
            else
            {
                // Nếu trang "My Account" chưa hiển thị, hiển thị trang
                QuanLyNguoiDungView accountView = new QuanLyNguoiDungView();
                MainContent.Content = accountView; // Thêm UserControl vào ContentControl
                _isAccountPageVisible = true; // Đánh dấu trang "My Account" đang hiển thị
            }
        }

        private void ManageAdministrativeUnitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện quản lý đơn vị hành chính.");
        }

        private void ManagePlantVarietyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện quản lý giống cây trồng.");
        }

        private void ManagePesticidesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện quản lý thuốc bảo vệ thực vật.");
        }

        private void ManageFertilizersButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện quản lý phân bón.");
        }

        private void ManageProductionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện quản lý sản xuất trồng trọt.");
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mở giao diện thống kê - báo cáo.");
        }

        // Khi nhấn vào nút Đăng Xuất
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            // Quay lại giao diện đăng nhập
            MainPanel.Visibility = Visibility.Collapsed;
            InitialPanel.Visibility = Visibility.Visible;
        }
    }
}

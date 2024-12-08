﻿using System.Windows;
using PlantManagement.Controllers;
using PlantManagement.Views;

namespace PlantManagement.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainController _controller;

        // Cờ để theo dõi trạng thái của các bảng tính năng
        private bool _isSystemButtonsVisible = false;
        private bool _isDatabaseButtonsVisible = false;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new MainController();
        }

        // Khi nhấn vào nút Đăng Nhập
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                LoadFeatureSelectionUI();
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

        private void LoadFeatureSelectionUI()
        {
            InitialPanel.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
        }

        // Khi người dùng chọn tính năng "Quản trị hệ thống"
        private void ManageSystemButton_Click(object sender, RoutedEventArgs e)
        {
            _isSystemButtonsVisible = !_isSystemButtonsVisible; // Chuyển trạng thái
            SystemButtons.Visibility = _isSystemButtonsVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        // Khi người dùng chọn tính năng "Quản lý CSDL trồng trọt"
        private void ManageDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            _isDatabaseButtonsVisible = !_isDatabaseButtonsVisible; // Chuyển trạng thái
            DatabaseButtons.Visibility = _isDatabaseButtonsVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        // Khi người dùng chọn "Quản lý người dùng"
        private void ManageUserButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyNguoiDungView());
        }

        // Khi người dùng chọn "Quản lý danh mục"
        private void ManageCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyDanhMucView());
        }

        // Khi người dùng chọn "Quản lý lịch sử"
        private void ManageHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyLichSuView());
        }

        // Khi người dùng chọn "Báo cáo"
        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new BaoCaoView());
        }

        // Khi người dùng chọn "Quản lý thông tin tài khoản"
        private void ManageAccountInfoButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyThongTinTaiKhoanView());
        }

        // Khi người dùng chọn tính năng "Quản lý CSDL"
        private void ManageDatabaseFeaturesButton_Click(object sender, RoutedEventArgs e)
        {
            _isDatabaseButtonsVisible = !_isDatabaseButtonsVisible; // Chuyển trạng thái
            DatabaseButtons.Visibility = _isDatabaseButtonsVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        // Hàm chung để hiển thị nội dung cho các mục Quản lý CSDL
        private void ShowContent(UIElement view)
        {
            // Ẩn các mục đang hiển thị
            SystemButtons.Visibility = Visibility.Collapsed;
            DatabaseButtons.Visibility = Visibility.Collapsed;
            MainContent.Visibility = Visibility.Visible;

            // Hiển thị nội dung trang mới
            MainContent.Content = view;
        }

        // Khi người dùng chọn "Quản lý giống cây trồng"
        private void ManagePlantVarietyButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyGiongCayTrongView());
        }

        // Khi người dùng chọn "Quản lý thuốc bảo vệ thực vật"
        private void ManagePesticidesButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyThuocBaoVeView());
        }

        // Khi người dùng chọn "Quản lý phân bón"
        private void ManageFertilizersButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLyPhanBonView());
        }

        // Khi người dùng chọn "Quản lý sản xuất trồng trọt"
        private void ManageProductionButton_Click(object sender, RoutedEventArgs e)
        {
            ShowContent(new QuanLySanXuatTrongTrotView());
        }

        // Khi người dùng nhấn nút "Quay lại"
        private void BackToFeatureSelection_Click(object sender, RoutedEventArgs e)
        {
            // Quay lại màn hình chọn tính năng ban đầu
            SystemButtons.Visibility = Visibility.Collapsed;
            DatabaseButtons.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
            MainContent.Visibility = Visibility.Collapsed;
        }

        // Khi nhấn vào nút Đăng Xuất
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            MainPanel.Visibility = Visibility.Collapsed;
            MainContent.Visibility = Visibility.Collapsed;
            InitialPanel.Visibility = Visibility.Visible;
        }
    }
}

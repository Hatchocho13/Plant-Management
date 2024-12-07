using System.Windows;
using PlantManagement.Controllers;
using PlantManagement.Views;  // Thêm namespace để sử dụng các UserControl

namespace PlantManagement.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainController _controller;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new MainController();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở cửa sổ đăng nhập và kiểm tra kết quả đăng nhập
            var loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)  // Nếu đăng nhập thành công (DialogResult = true)
            {
                // Cập nhật giao diện MainWindow để hiển thị tính năng
                LoadFeatureSelectionUI();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng thử lại.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở cửa sổ đăng ký
            var registerWindow = new RegisterWindow();
            registerWindow.ShowDialog(); // Đăng ký sau khi nhấn nút "Đăng Ký"
        }

        private void LoadFeatureSelectionUI()
        {
            // Ẩn các nút đăng nhập và đăng ký
            InitialPanel.Visibility = Visibility.Collapsed;

            // Hiển thị bảng chọn tính năng
            FeaturePanel.Visibility = Visibility.Visible;
        }

        // Khi người dùng chọn tính năng "Quản trị hệ thống"
        private void ManageSystemButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn bảng tính năng
            FeaturePanel.Visibility = Visibility.Collapsed;

            // Hiển thị các mục của tính năng quản trị hệ thống
            SystemManagementPanel.Visibility = Visibility.Visible;
        }

        // Khi người dùng chọn tính năng "Quản lý CSDL trồng trọt"
        private void ManageDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn bảng tính năng
            FeaturePanel.Visibility = Visibility.Collapsed;

            // Hiển thị các mục của tính năng quản lý CSDL trồng trọt
            DatabaseManagementPanel.Visibility = Visibility.Visible;
        }

        // Khi người dùng chọn "Quản lý người dùng" từ menu quản trị hệ thống
        private void ManageUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng khác
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;

            // Hiển thị UserControl quản lý người dùng
            QuanLyNguoiDungView manageUserView = new QuanLyNguoiDungView();
            MainContent.Content = manageUserView;
            MainContent.Visibility = Visibility.Visible;
        }

        // Các sự kiện cho các tính năng khác
        private void ManageCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng khác
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;

            // Hiển thị UserControl quản lý danh mục
            QuanLyDanhMucView manageCategoryView = new QuanLyDanhMucView();
            MainContent.Content = manageCategoryView;
            MainContent.Visibility = Visibility.Visible;
        }

        private void ManageHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng khác
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;

            // Hiển thị UserControl quản lý lịch sử
            QuanLyLichSuView manageHistoryView = new QuanLyLichSuView();
            MainContent.Content = manageHistoryView;
            MainContent.Visibility = Visibility.Visible;
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng khác
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;

            // Hiển thị UserControl báo cáo
            BaoCaoView reportView = new BaoCaoView();
            MainContent.Content = reportView;
            MainContent.Visibility = Visibility.Visible;
        }

        private void ManageAccountInfoButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng khác
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;

            // Hiển thị UserControl quản lý thông tin tài khoản
            QuanLyThongTinTaiKhoanView manageAccountInfoView = new QuanLyThongTinTaiKhoanView();
            MainContent.Content = manageAccountInfoView;
            MainContent.Visibility = Visibility.Visible;
        }

        // Khi người dùng nhấn nút "Quay lại"
        private void BackToFeatureSelection_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn các bảng tính năng quản lý và quay lại bảng chọn tính năng
            SystemManagementPanel.Visibility = Visibility.Collapsed;
            DatabaseManagementPanel.Visibility = Visibility.Collapsed;
            FeaturePanel.Visibility = Visibility.Visible;
        }
    }
}

using System.Windows;
using PlantManagement.Controllers;
using PlantManagement.Views;

namespace PlantManagement.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainController _controller;
        private bool _isAdmin;  // Khai báo biến _isAdmin

        public MainWindow()
        {
            InitializeComponent();
            _controller = new MainController();
            _isAdmin = false;  // Mặc định là không phải admin
        }

        // Khi nhấn vào nút Đăng Nhập
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                LoadMainUI();
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
            InitialPanel.Visibility = Visibility.Collapsed;  // Ẩn giao diện đăng nhập
            MainPanel.Visibility = Visibility.Visible;  // Hiển thị các tính năng chính
        }

        // Khi người dùng chọn tính năng "Quản trị hệ thống"
        private void ManageSystemButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleVisibility(SystemButtons);
        }

        // Khi người dùng chọn tính năng "Quản lý CSDL trồng trọt"
        private void ManageDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleVisibility(DatabaseButtons);
        }
        // Khi người dùng chọn "Quản lý người dùng"
        private void ManageUserButton_Click(object sender, RoutedEventArgs e)
        {
            //ShowContent(new QuanLyNguoiDungView());
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

        // Hàm toggle để ẩn/hiện các bảng tính năng
        private void ToggleVisibility(UIElement element)
        {
            element.Visibility = element.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
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

        // Khi người dùng chọn "Quản lý thông tin người dùng"
        private void ManageUserInfoButton_Click(object sender, RoutedEventArgs e)
        {
            // Truyền _isAdmin vào QuanLyThongTinTaiKhoanView
            ShowContent(new QuanLyThongTinTaiKhoanView(_isAdmin));
        }
    }
}

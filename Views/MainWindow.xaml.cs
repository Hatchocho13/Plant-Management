using System.Windows;
using PlantManagement.Controllers;

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
            // Mở cửa sổ đăng nhập
            var loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true) // Nếu đăng nhập thành công
            {
                // Cập nhật giao diện MainWindow
                MessageBox.Show("Đăng nhập thành công!");
                LoadFeatureSelectionUI(); // Hiển thị giao diện các tính năng
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng thử lại.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở cửa sổ đăng ký (có thể thêm logic nếu cần)
            MessageBox.Show("Chức năng đăng ký sẽ được triển khai sau!");
        }

        private void LoadFeatureSelectionUI()
        {
            // Ẩn hoặc thay đổi giao diện ban đầu thành giao diện bảng chọn tính năng
            LoginButton.Visibility = Visibility.Collapsed;
            RegisterButton.Visibility = Visibility.Collapsed;

            // Thêm các tính năng chính
            FeaturePanel.Visibility = Visibility.Visible; // Hiển thị bảng chọn các tính năng
        }
    }
}

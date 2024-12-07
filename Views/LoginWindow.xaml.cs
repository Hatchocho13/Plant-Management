using System.Windows;
using PlantManagement.Controllers;


namespace PlantManagement.Views
{
    public partial class LoginWindow : Window
    {
        private readonly LoginController _loginController;

        public LoginWindow()
        {
            InitializeComponent();
            _loginController = new LoginController();  // Khởi tạo đối tượng LoginController
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy tên đăng nhập và mật khẩu từ giao diện người dùng
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Gọi phương thức AuthenticateUser để kiểm tra thông tin đăng nhập
            User user = _loginController.AuthenticateUser(username, password);

            if ( user != null)  //tam bo qua dang nhap
            {
                MessageBox.Show($"Đăng nhập thành công! Chào mừng {user.FullName}.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                // Đặt DialogResult = true để MainWindow nhận biết đăng nhập thành công
                DialogResult = true;
                this.Close();  // Đóng cửa sổ đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Đóng cửa sổ đăng nhập
            this.Close();
        }
    }
}

using System.Windows;
using PlantManagement.Controllers;

namespace PlantManagement.Views
{
    public partial class LoginWindow : Window
    {
        private readonly LoginController _controller;

        public LoginWindow()
        {
            InitializeComponent();
            _controller = new LoginController();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text.Trim();
            var password = PasswordBox.Password.Trim();

            if (_controller.AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                DialogResult = true; // Đăng nhập thành công
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Thoát mà không đăng nhập
            Close();
        }
    }
}

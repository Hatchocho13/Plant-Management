using PlantManagement.Controllers;
using PlantManagement.Models;
using System.Windows;

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
            var user = new User
            {
                Username = UsernameTextBox.Text,
                Password = PasswordBox.Password
            };

            if (_controller.AuthenticateUser(user))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();  // Đóng cửa sổ đăng nhập
            }
            else
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu!");
            }
        }
    }
}

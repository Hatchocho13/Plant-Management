﻿using System.Windows;
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

            if (user != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Chào mừng {user.FullName}.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
            this.Close(); // Đóng cửa sổ đăng nhập
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn phần đăng nhập, nút quên mật khẩu và hiển thị phần quên mật khẩu
            LoginPanel.Visibility = Visibility.Collapsed;
            ForgotPasswordPanel.Visibility = Visibility.Visible;
            ForgotPasswordButton.Visibility = Visibility.Collapsed; // Ẩn nút "Quên mật khẩu"

            // Làm mới các trường thông tin
            ForgotUsernameTextBox.Clear();
            ForgotEmailTextBox.Clear();
        }

        private void BackToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Quay lại giao diện đăng nhập
            ForgotPasswordPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;
            ForgotPasswordButton.Visibility = Visibility.Visible; // Hiển thị lại nút "Quên mật khẩu"
        }

        private void SubmitForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            string username = ForgotUsernameTextBox.Text;
            string email = ForgotEmailTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Kiểm tra tài khoản và email
            string password = _loginController.GetPasswordByUsernameAndEmail(username, email);

            if (!string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Mật khẩu của bạn là: {password}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                BackToLoginButton_Click(sender, e);  // Quay lại màn hình đăng nhập
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc email không chính xác!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

using System.Windows;

namespace PlantManagement.Views
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        // Username TextBox GotFocus event
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Ẩn placeholder khi người dùng click vào TextBox
            if (sender == UsernameTextBox)
                UsernamePlaceholder.Visibility = Visibility.Collapsed;

            if (sender == FullNameTextBox)
                FullNamePlaceholder.Visibility = Visibility.Collapsed;

            if (sender == EmailTextBox)
                EmailPlaceholder.Visibility = Visibility.Collapsed;
        }

        // Username TextBox LostFocus event
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Hiện lại placeholder khi người dùng không nhập liệu
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernamePlaceholder.Visibility = Visibility.Visible;
            }

            if (string.IsNullOrEmpty(FullNameTextBox.Text))
            {
                FullNamePlaceholder.Visibility = Visibility.Visible;
            }

            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                EmailPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // PasswordBox GotFocus event
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Ẩn placeholder khi người dùng click vào PasswordBox
            PasswordPlaceholder.Visibility = Visibility.Collapsed;
        }

        // PasswordBox LostFocus event
        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Hiện lại placeholder khi người dùng không nhập liệu
            if (string.IsNullOrEmpty(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Confirm PasswordBox GotFocus event
        private void ConfirmPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Ẩn placeholder khi người dùng click vào ConfirmPasswordBox
            ConfirmPasswordPlaceholder.Visibility = Visibility.Collapsed;
        }

        // Confirm PasswordBox LostFocus event
        private void ConfirmPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Hiện lại placeholder khi người dùng không nhập liệu
            if (string.IsNullOrEmpty(ConfirmPasswordBox.Password))
            {
                ConfirmPasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        // Register Button Click event
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string fullName = FullNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            // Kiểm tra tính hợp lệ của các trường
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            // Kiểm tra mật khẩu và xác nhận mật khẩu có khớp không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            // Đăng ký thành công
            MessageBox.Show("Đăng ký thành công!");
        }

        // Kiểm tra định dạng email hợp lệ
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

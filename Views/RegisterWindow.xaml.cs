using System.Windows;

namespace PlantManagement.Views
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Ẩn placeholder khi người dùng click vào TextBox
            UsernamePlaceholder.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Hiện lại placeholder khi người dùng không nhập liệu
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Ẩn placeholder khi người dùng click vào PasswordBox
            PasswordPlaceholder.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Hiện lại placeholder khi người dùng không nhập liệu
            if (string.IsNullOrEmpty(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Xử lý đăng ký ở đây, ví dụ kiểm tra tính hợp lệ
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            MessageBox.Show("Đăng ký thành công!");
        }
    }
}

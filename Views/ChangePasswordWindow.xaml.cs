using System.Windows;
using PlantManagement.Controllers;

namespace PlantManagement.Views
{
    public partial class ChangePasswordWindow : Window
    {
        private readonly QuanLyThongTinTaiKhoanController _controller;
        private readonly int _userID; // ID của người dùng cần thay đổi mật khẩu

        public ChangePasswordWindow(int UserID)
        {
            InitializeComponent();
            _controller = new QuanLyThongTinTaiKhoanController();
            _userID = UserID; // Lưu ID người dùng (thông thường sẽ lấy từ phiên đăng nhập)
        }

        private void ConfirmChangePassword(object sender, RoutedEventArgs e)
        {
            string oldPassword = OldPasswordBox.Password;
            string newPassword = NewPasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            // Lấy thông tin người dùng từ CSDL
            var user = _controller.GetUserByID(_userID);

            // Kiểm tra mật khẩu cũ
            if (user != null && user.Password == oldPassword)
            {
                // Kiểm tra mật khẩu mới và xác nhận
                if (newPassword == confirmPassword)
                {
                    // Cập nhật mật khẩu mới vào CSDL
                    bool success = _controller.UpdateUserPassword(_userID, oldPassword, newPassword);

                    if (success)
                    {
                        MessageBoxResult result = MessageBox.Show("Mật khẩu đã được thay đổi thành công! Bạn có muốn ở lại ứng dụng?",
                            "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);

                        if (result == MessageBoxResult.Yes)
                        {
                            this.Close(); // Đóng cửa sổ đổi mật khẩu và tiếp tục sử dụng ứng dụng
                        }
                        else
                        {
                            // Đóng cửa sổ và chuyển về màn hình đăng nhập
                            Application.Current.MainWindow.Visibility = Visibility.Collapsed;
                            new LoginWindow().Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi thay đổi mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác. Vui lòng thử lại.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}

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
            _controller.OpenLoginWindow(); // Mở cửa sổ đăng nhập
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.OpenRegisterWindow(); // Mở cửa sổ đăng ký
        }
    }
}

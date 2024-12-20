using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using PlantManagement.Controllers;
using PlantManagement.Models;

namespace PlantManagement.Views
{
    public partial class BaoCaoView : UserControl
    {
        private BaoCaoController _baoCaoController;

        public BaoCaoView()
        {
            InitializeComponent();
            _baoCaoController = new BaoCaoController();
        }

        private void NguoiDung_Click(object sender, RoutedEventArgs e)
        {
            // Lấy danh sách người dùng từ controller
            List<User> userList = _baoCaoController.GetUserList();

            // Gán danh sách người dùng vào DataGrid
            UserDataGrid.ItemsSource = userList;
        }

        private void LichSuTruyCap_Click(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Lịch Sử Truy Cập
            MessageBox.Show("Lịch sử truy cập được hiển thị.");
        }

        private void LichSuTacDong_Click(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Lịch Sử Tác Động
            MessageBox.Show("Lịch sử tác động được hiển thị.");
        }

        private void TongHop_Click(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn nút Tổng Hợp
            MessageBox.Show("Tổng hợp được hiển thị.");
        }
    }
}

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
        private Button _currentButton; // Biến lưu nút hiện tại đã được chọn

        public BaoCaoView()
        {
            InitializeComponent();
            _baoCaoController = new BaoCaoController();
            _currentButton = null; // Không có nút nào được chọn ban đầu
        }

        // Ẩn tất cả các giao diện
        private void HideAllViews()
        {
            UserDataGrid.Visibility = Visibility.Collapsed;
            LoginHistoryDataGrid.Visibility = Visibility.Collapsed;
            ImpactHistoryDataGrid.Visibility = Visibility.Collapsed;
            TongHopDataGrid.Visibility = Visibility.Collapsed;
            MessagePlaceholder.Visibility = Visibility.Collapsed;
        }

        // Thay đổi màu nền của nút
        private void SetButtonBackground(Button clickedButton)
        {
            if (_currentButton != null)
            {
                _currentButton.Background = System.Windows.Media.Brushes.LightGreen; // Trở về màu gốc của nút trước
            }

            clickedButton.Background = System.Windows.Media.Brushes.LightBlue; // Đặt màu xanh cho nút hiện tại
            _currentButton = clickedButton; // Lưu lại nút hiện tại
        }

        // Hiển thị giao diện người dùng
        public void NguoiDung_Click(object sender, RoutedEventArgs e)
        {
            HideAllViews();
            SetButtonBackground(NguoiDungButton); // Thay đổi màu nền cho nút người dùng

            // Lấy danh sách người dùng từ controller
            List<User> userList = _baoCaoController.GetUserList();

            // Gán danh sách vào DataGrid
            UserDataGrid.ItemsSource = userList;
            UserDataGrid.Visibility = Visibility.Visible;
        }

        // Hiển thị giao diện lịch sử truy cập
        private void LichSuTruyCap_Click(object sender, RoutedEventArgs e)
        {
            HideAllViews();
            SetButtonBackground(LichSuTruyCapButton); // Thay đổi màu nền cho nút lịch sử truy cập

            // Lấy danh sách lịch sử truy cập từ controller (bao gồm FullName từ bảng User)
            List<LoginHistory> loginHistoryList = _baoCaoController.GetLoginHistoryWithFullName();

            // Gán danh sách vào DataGrid
            LoginHistoryDataGrid.ItemsSource = loginHistoryList; // Tự động tạo cột FullName
            LoginHistoryDataGrid.Visibility = Visibility.Visible;
        }

        // Hiển thị giao diện lịch sử tác động
        private void LichSuTacDong_Click(object sender, RoutedEventArgs e)
        {
            HideAllViews();
            SetButtonBackground(LichSuTacDongButton); // Thay đổi màu nền cho nút lịch sử tác động

            // Lấy danh sách số lần đăng nhập của người dùng từ controller
            List<LoginHistoryCount> loginHistoryCountList = _baoCaoController.GetLoginHistoryCount();

            // Gán danh sách vào DataGrid
            ImpactHistoryDataGrid.ItemsSource = loginHistoryCountList;
            ImpactHistoryDataGrid.Visibility = Visibility.Visible;
        }


        // Hiển thị giao diện tổng hợp
        // Hiển thị giao diện tổng hợp
        private void TongHop_Click(object sender, RoutedEventArgs e)
        {
            HideAllViews();
            SetButtonBackground(TongHopButton); // Thay đổi màu nền cho nút tổng hợp

            // Lấy dữ liệu tổng hợp từ controller
            List<TongHopData> tongHopData = _baoCaoController.GetTongHopData();

            // Gán danh sách vào DataGrid
            TongHopDataGrid.ItemsSource = tongHopData;
            TongHopDataGrid.Visibility = Visibility.Visible;
        }

    }
}

using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using PlantManagement.Controllers;

namespace PlantManagement.Views
{
    public partial class DonViHanhChinhView : UserControl
    {
        private readonly DonViHanhChinhController _controller;

        public DonViHanhChinhView()
        {
            InitializeComponent();
            _controller = new DonViHanhChinhController();
            LoadData();
        }

        private void LoadData()
        {
            // Tải dữ liệu huyện
            DataTable huyenTable = _controller.GetDanhMucHuyen();
            HuyenDataGrid.ItemsSource = huyenTable.DefaultView;

            // Tải dữ liệu xã
            DataTable xaTable = _controller.GetDanhMucXa();
            XaDataGrid.ItemsSource = xaTable.DefaultView;
        }

        private void TimKiemHuyen_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchHuyenTextBox.Text;
            HuyenDataGrid.ItemsSource = _controller.TimKiemHuyen(keyword).DefaultView;
        }

        private void TimKiemXa_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchXaTextBox.Text;
            XaDataGrid.ItemsSource = _controller.TimKiemXa(keyword).DefaultView;
        }

        private void ThemHuyen_Click(object sender, RoutedEventArgs e)
        {
            // Code thêm huyện (ví dụ: hiển thị popup để nhập liệu)
            MessageBox.Show("Thêm huyện mới (Code bổ sung ở đây).");
        }

        private void SuaHuyen_Click(object sender, RoutedEventArgs e)
        {
            // Code sửa huyện
            MessageBox.Show("Sửa thông tin huyện (Code bổ sung ở đây).");
        }

        private void XoaHuyen_Click(object sender, RoutedEventArgs e)
        {
            // Code xóa huyện
            MessageBox.Show("Xóa huyện (Code bổ sung ở đây).");
        }

        private void ThemXa_Click(object sender, RoutedEventArgs e)
        {
            // Code thêm xã
            MessageBox.Show("Thêm xã mới (Code bổ sung ở đây).");
        }

        private void SuaXa_Click(object sender, RoutedEventArgs e)
        {
            // Code sửa xã
            MessageBox.Show("Sửa thông tin xã (Code bổ sung ở đây).");
        }

        private void XoaXa_Click(object sender, RoutedEventArgs e)
        {
            // Code xóa xã
            MessageBox.Show("Xóa xã (Code bổ sung ở đây).");
        }
    }
}

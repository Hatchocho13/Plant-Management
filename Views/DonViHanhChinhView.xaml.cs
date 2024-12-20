using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using PlantManagement.Controllers;

namespace PlantManagement.Views
{
    public partial class DonViHanhChinhView : UserControl
    {
        private readonly DonViHanhChinhController _controller;

        private bool isSlideAnimationDone = false; // Biến flag để theo dõi hiệu ứng trượt


        public DonViHanhChinhView()
        {
            InitializeComponent();
            _controller = new DonViHanhChinhController();
        }

        // Khi bấm nút "Đơn Vị Hành Chính Huyện"
        private void HuyenButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo hiệu ứng trượt (Slide)
            var slideAnimation = new DoubleAnimation
            {
                From = 0,
                To = 200, // Chiều cao cần trượt ra
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            HuyenStackPanel.Visibility = Visibility.Visible;
            HuyenStackPanel.BeginAnimation(HeightProperty, slideAnimation);

            LoadHuyenData();
        }

        // Tải dữ liệu huyện (cấp 1)
        private void LoadHuyenData()
        {
            // Lấy danh sách các cấp từ controller (danh sách cấp hành chính)
            DataTable capTable = _controller.GetDanhMucCap();
            foreach (DataRow row in capTable.Rows)
            {
                if (row["TenCap"].ToString() == "Huyện")  // Lọc cấp "Huyện"
                {
                    int capId = Convert.ToInt32(row["ID"]);
                    DataTable huyenTable = _controller.GetDanhMucDonViHanhChinh(2);
                    HuyenListBox.ItemsSource = huyenTable.DefaultView;
                    HuyenListBox.DisplayMemberPath = "TenDVHC"; // Hiển thị tên huyện
                }
            }
        }

        // Khi người dùng chọn một huyện
        private void HuyenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HuyenListBox.SelectedItem != null)
            {
                try
                {
                    // Lấy ID của huyện đã chọn
                    var selectedHuyen = (DataRowView)HuyenListBox.SelectedItem;
                    int selectedHuyenId = Convert.ToInt32(selectedHuyen["ID"]);

                    // Tải danh sách xã theo huyện
                    LoadXaData(selectedHuyenId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy thông tin huyện: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        // Tải danh sách xã theo huyện đã chọn
        private void LoadXaData(int huyenId)
        {
            try
            {
                // Nếu hiệu ứng trượt chưa được thực hiện, thực hiện hiệu ứng
                if (!isSlideAnimationDone)
                {
                    // Ẩn XaStackPanel trước khi thực hiện hiệu ứng trượt lại
                    XaStackPanel.Visibility = Visibility.Collapsed;

                    // Lấy danh sách xã (ID_Cap = 3 và parent_id = huyenId)
                    DataTable xaTable = _controller.GetDanhMucXaByHuyen(huyenId);
                    XaListBox.ItemsSource = xaTable.DefaultView;
                    XaListBox.DisplayMemberPath = "TenDVHC"; // Hiển thị tên xã

                    // Tạo hiệu ứng trượt cho danh sách xã
                    var slideAnimation = new DoubleAnimation
                    {
                        From = 0,
                        To = 200, // Chiều cao cần trượt ra
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    XaStackPanel.Visibility = Visibility.Visible; // Đảm bảo StackPanel là Visible
                    XaStackPanel.BeginAnimation(HeightProperty, slideAnimation);

                    // Đánh dấu hiệu ứng đã thực hiện
                    isSlideAnimationDone = true;
                }
                else
                {
                    // Nếu hiệu ứng đã thực hiện, chỉ cần hiển thị danh sách xã mà không có animation
                    DataTable xaTable = _controller.GetDanhMucXaByHuyen(huyenId);
                    XaListBox.ItemsSource = xaTable.DefaultView;
                    XaListBox.DisplayMemberPath = "TenDVHC"; // Hiển thị tên xã
                    XaStackPanel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách xã: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Các hàm xử lý nút "Thêm", "Sửa", "Xóa" (ví dụ)
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic thêm đơn vị hành chính
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic sửa đơn vị hành chính
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic xóa đơn vị hành chính
        }

        // Tìm kiếm
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic tìm kiếm đơn vị hành chính
        }

        // Khi TextBox tìm kiếm nhận được focus
        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            WatermarkText.Visibility = Visibility.Collapsed;
        }

        // Khi TextBox tìm kiếm mất focus
        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                WatermarkText.Visibility = Visibility.Visible;
            }
        }


    }
}

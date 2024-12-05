using System.Windows;

namespace PlantManagement.Views
{
    public partial class ManagePlantsWindow : Window
    {
        public ManagePlantsWindow()
        {
            InitializeComponent();
        }

        // Phương thức xử lý sự kiện AddPlantButton_Click
        private void AddPlantButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic xử lý khi nhấn nút "Thêm Cây Trồng"
            MessageBox.Show("Thêm cây trồng!");
        }
    }
}

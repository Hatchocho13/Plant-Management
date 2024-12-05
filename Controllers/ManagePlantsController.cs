using PlantManagement.Views; // Thêm dòng này để tham chiếu đến không gian tên chứa cửa sổ ManagePlantsWindow

namespace PlantManagement.Controllers
{
    public class ManagePlantsController
    {
        public void ShowManagePlantsWindow()
        {
            // Tạo cửa sổ ManagePlantsWindow và hiển thị
            ManagePlantsWindow managePlantsWindow = new ManagePlantsWindow();
            managePlantsWindow.Show();
        }
    }
}

   M S B A M L   `   `   `  ����  PlantManagement&     PlantManagement.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quản lý trồng trọt��5   	   $	��600��6$   $
��1168��61    � WindowStartupLocation$ CenterScreen=�6>   .��5      � .+�5   
   �� -   5         ��Name$ InitialPanel��5      $��Center=�6+   $��Center=�6F   $y�Visible=�6c   .+�5	      �� -   5         ��Name$ LoginButton��5	      $��Đăng Nhập��6*   $	��250��6>   $��50��6J   $
��0,15q�6p   ���#4CAF50
�������$
��Bold"�6�   ���#388E3C$��2q�6�    � Cursor$
 Hand��6�   �� 5
      -   5        $ RegisterButton��5
      $��
Đăng Ký��6-   $	��250��6?   $��50��6K   $
��0,15q�6t   ���#2196F3
�������$
��Bold"�6�   ���#1976D2$��2q�6�   $
 Hand��6�   5      � 5   
   -   5         �Name$ 	MainPanel��5      $y�	Collapsed=�6"   ���#E8F5E9$��20q�6N    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��2��6    ���#00FA9A$��80��6I    5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $
��Left=�6Q   $
��10,0q�6l   .+�5       �� $��Quản Lý Trồng Trọt��6    $��24(�6:   $
��Bold"�6H   ���#006400$��Center=�6o   $
��10,0q�6�   5!      �� 5#      $ 
Horizontal=�6   $��Center=�66   $��Right=�6Q   $
��20,0q�6m   $��1��6{   .+�5$      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\istockphoto-1200064755-612x612-removebg-preview.png��6   $��30��6�   $��30��6�   $��5,0,0,0q�6�   �� 5%      -   5        $��Tài Khoản��5%      $��16(�61   $��80��6?   $��35��6J   
������ 
���   �$
��Bold"�5&   )   $��0q�6;   $
 Hand��6O   $��0,0,10,0q�5'   4   �� 5)      -   5        $��Đăng Xuất��5)      $��16(�61   $	��100��6?   $��25��6K   ���#FF7F50
���   �$
��Bold"�6   ���#D84315$��1q�6�   $
 Hand��6�   $��0,0,10,0q�6�   5*      5+      �� 5.      $��1��6   $��0��6&   
�������.+�50      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\cropped-logo-vingarden-removebg-preview.png��6   $	��200��6�   $	��Top=�6�   $��Center=�6  $��	0,10,0,10q�6  �� 53      $ Vertical=�6   $��Stretch=�64   $��20q�6R   .+�54      �� -   5        $ ManageUserButton��54         SidebarButtonStyle#��[  67   $��40��6�   $��0,0,0,10q�6�   $
��Left=�6�   .��55      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�56      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\8fe930e6-9048-47c8-b398-6fb9825796a4-removebg-preview.png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 57      $��Quản lý người dùng��6(   $��Center=�6B   $
��Left=�6]   58      59      �� 5;      -   5        $$ ManageAdministrativeUnitButton��5;      #��[  6E   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5<      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5=      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e7b4e0df-bbe4-43b4-afdd-6ef572b538b5-removebg-preview.png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5>      $��Đơn vị hành chính��6(   $��Center=�6A   $
��Left=�6\   5?      5@      �� 5B      -	   5        $ ManagePlantVarietyButton��5B      #��[  6?   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5C      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5D      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e5e2b72b-e0f0-4547-b973-33c8207b0d88-removebg-preview (1).png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5E      $%��Quản lý giống cây trồng��6(   $��Center=�6G   $
��Left=�6b   5F      5G      �� 5I      -
   5        $ ManagePesticidesButton��5I      #��[  6=   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5J      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5K      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\9bfecbae-f085-4a77-b408-e0c68a3ac55c-removebg-preview (1).png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5L      $%��Thuốc bảo vệ thực vật��6(   $��Center=�6E   $
��Left=�6`   5M      5N      �� 5P      -   5        $ ManageFertilizersButton��5P      #��[  6>   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5Q      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5R      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\855d3b8c-a1f4-47c0-bd32-1390330186ed-removebg-preview.png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5S      $��Quản lý phân bón��6(   $��Center=�6@   $
��Left=�6[   5T      5U      �� 5W      -   5        $ ManageProductionButton��5W      #��[  6=   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5X      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5Y      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\57866269-2bd8-4869-bf57-c06cafaf6df7-removebg-preview (1).png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5Z      $!��Sản xuất trồng trọt��6(   $��Center=�6C   $
��Left=�6^   5[      5\      �� 5^      -   5        $ ReportButton��5^      #��[  63   $��40��6z   $��0,5,0,10q�6�   $
��Left=�6�   .��5_      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5`      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\31c8f5c5-ab91-484b-9d7c-d28f05c1eb59-removebg-preview.png��6$   $��20��6�   $��20��6  $��5,0,10,0q�6  �� 5a      $��Thống kê - Báo cáo��6(   $��Center=�6B   $
��Left=�6]   5b      5c      5d      5e      �� 5h      $��1��6   $��1��6"   
�������	 �� CornerRadius$	 5��6E   $��40q�6W   ���#4CAF50$��1q�5i   +   ._�5j      �� -   5        
 ��Name$
 MainContent��5j   !   $��Stretch=�66   $��Stretch=�6R   5k      5l      5m      5n      
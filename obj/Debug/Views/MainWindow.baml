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
   -   5         �Name$ 	MainPanel��5      $y�	Collapsed=�6"   
�������$��20q�6Q    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��2��6    $	��100��64   ��5      �� 5       �� Color$ #A7D8E8��6&    5       �� 5!      $��* �6'   �� 5"      $
��Auto �6'   .+�5%      �� 	 �� Orientation$	 
Horizontal=�6   $��Center=�66   $
��Left=�6Q   $
��10,0q�6l   .+�5&      �� $��Quản Lý Trồng Trọt��6    $��28(�6:   $
��Bold"�6H   
���OO/�$��Center=�6u   $
��10,0q�6�   5'      �� 5)      $	 
Horizontal=�6   $��Center=�66   $��Right=�6Q   $
��20,0q�6m   $��1��6{   .+�5*      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\istockphoto-1200064755-612x612-removebg-preview.png��6   $��30��6�   $��30��6�   $��5,0,0,0q�6�   �� 5+      -   5        $��Tài Khoản��5+      $��16(�61   $��80��6?   $��35��6J   
������ 
���   �$
��Bold"�5,      $��0q�6/   $
 Hand��6C   $��0,0,10,0q�5-   (   �� 5/      -   5        $��Đăng Xuất��5/      $��16(�61   $	��100��6?   $��25��6K   ���#FF7F50
���   �$
��Bold"�6   ���#D84315$��1q�6�   $
 Hand��6�   $��0,0,10,0q�6�   50      51      �� 55      $��1��6   $��0��6&   .+�57      �� 
����·�5:      �� 5>      $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\logo-removebg-preview.png��6   $	��200��6�   $	��Top=�6�   $��Center=�6�   $��0,20,1,0q�6  �� 5A      $	 Vertical=�6   $��Stretch=�64   $��20q�6R   .+�5B      �� -   5        $ ManageUserButton��5B      
������    SidebarButtonStyle#��[  6P   $��40��6�   $��0,0,0,10q�6�   $
��Left=�6�   .��5C      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5D      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\8fe930e6-9048-47c8-b398-6fb9825796a4-removebg-preview.png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5E      $��Quản lý người dùng��6(   $��15(�6B   $��Center=�6P   $
��Left=�6k   5F      5G      �� 5I      -   5        $$ ManageAdministrativeUnitButton��5I      
������ #��[  6^   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5J      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5K      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e7b4e0df-bbe4-43b4-afdd-6ef572b538b5-removebg-preview.png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5L      $��Đơn vị hành chính��6(   $��15(�6A   $��Center=�6O   $
��Left=�6j   5M      5N      �� 5P      -	   5        $ ManagePlantVarietyButton��5P      
������ #��[  6X   $��40��6�   $	��270��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5Q      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5R      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e5e2b72b-e0f0-4547-b973-33c8207b0d88-removebg-preview (1).png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5S      $%��Quản lý giống cây trồng��6(   $��15(�6G   $��Center=�6U   $
��Left=�6p   5T      5U      �� 5W      -
   5        $ ManagePesticidesButton��5W      
������ #��[  6V   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5X      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5Y      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\9bfecbae-f085-4a77-b408-e0c68a3ac55c-removebg-preview (1).png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5Z      $%��Thuốc bảo vệ thực vật��6(   $��15(�6E   $��Center=�6S   $
��Left=�6n   5[      5\      �� 5^      -   5        $ ManageFertilizersButton��5^      
������ #��[  6W   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5_      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5`      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\855d3b8c-a1f4-47c0-bd32-1390330186ed-removebg-preview.png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5a      $��Quản lý phân bón��6(   $��15(�6@   $��Center=�6N   $
��Left=�6i   5b      5c      �� 5e      -   5        $ ManageProductionButton��5e      
������ #��[  6V   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5f      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5g      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\57866269-2bd8-4869-bf57-c06cafaf6df7-removebg-preview (1).png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5h      $!��Sản xuất trồng trọt��6(   $��15(�6C   $��Center=�6R   $
��Left=�6m   5i      5j      �� 5l      -   5        $ ReportButton��5l      
������ #��[  6L   $��40��6�   $��0,5,0,10q�6�   $
��Left=�6�   .��5m      �� $	 
Horizontal=�6%   $
��Left=�6>   .+�5n      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\31c8f5c5-ab91-484b-9d7c-d28f05c1eb59-removebg-preview.png��6$   $��25��6�   $��25��6  $��5,0,10,0q�6  �� 5o      $��Thống kê - Báo cáo��6(   $��15(�6C   $��Center=�6Q   $
��Left=�6l   5p      5q      5r      5s      �� 5w      $��1��6   $��1��6"   
�������$��1q�6E   
 �� CornerRadius$
 10��6Y   
�������._�5x      �� -   5         ��Name$ MainContent��5x   !   $
��Auto��66   5y      5{      5|      5}      
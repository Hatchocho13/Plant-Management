   M S B A M L   `   `   `  ����   PlantManagement&     PlantManagement.Views.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Quản lý trồng trọt��$	��600��$
��1168�� � WindowStartupLocation$ CenterScreen=�.��� .+��� -    ��Name$ InitialPanel��$��Center=�$��Center=�$y�Visible=�.+��� -    ��Name$ LoginButton��$��Đăng Nhập��$	��250��$��50��$
��0,15q����#4CAF50
�������$
��Bold"����#388E3C$��2q� � Cursor$
 Hand���� -   $ RegisterButton��$��
Đăng Ký��$	��250��$��50��$
��0,15q����#2196F3
�������$
��Bold"����#1976D2$��2q�$
 Hand��� -    �Name$ 	MainPanel��$y�	Collapsed=�
�������$��20q� � RowDefinitions �� $
��Auto ��� $��* � � ColumnDefinitions �� $	��250 ��� $��* �.+�� $��0��$��2��$	��100������  �� ImageSource$� �C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\pngtree-green-grass-and-blue-sky-background-image_15697980.jpg��	 j� Stretch$	 UniformToFill=� �� $��* ��� $
��Auto �.+��� 
 �� Orientation$
 
Horizontal=�$��Center=�$
��Left=�$
��10,0q�.+��� $��Quản Lý Trồng Trọt��$��28(�$
��Bold"����#006400$��Center=�$
��10,0q��� $
 
Horizontal=�$��Center=�$��Right=�$
��20,0q�$��1��.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\istockphoto-1200064755-612x612-removebg-preview.png��$��30��$��30��$��5,0,0,0q��� -   $��Tài Khoản��$��16(�$��80��$��35��
������ 
���   �$
��Bold"�$��0q�$
 Hand��$��0,0,10,0q��� -   $��Đăng Xuất��$��16(�$	��100��$��25�����#FF7F50
���   �$
��Bold"����#D84315$��1q�$
 Hand��$��0,0,10,0q��� $��1��$��0������ $� �C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\mau.jpg��$	 UniformToFill=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\cropped-logo-vingarden-removebg-preview.png��$	��200��$	��Top=�$��Center=�$��	0,10,0,10q��� $
 Vertical=�$��Stretch=�$��20q�.+��� -   $ ManageUserButton��
������    SidebarButtonStyle#��[  $��40��$��0,0,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\8fe930e6-9048-47c8-b398-6fb9825796a4-removebg-preview.png��$��20��$��20��$��5,0,10,0q��� $��Quản lý người dùng��$��Center=�$
��Left=��� -   $$ ManageAdministrativeUnitButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e7b4e0df-bbe4-43b4-afdd-6ef572b538b5-removebg-preview.png��$��20��$��20��$��5,0,10,0q��� $��Đơn vị hành chính��$��Center=�$
��Left=��� -	   $ ManagePlantVarietyButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\e5e2b72b-e0f0-4547-b973-33c8207b0d88-removebg-preview (1).png��$��20��$��20��$��5,0,10,0q��� $%��Quản lý giống cây trồng��$��Center=�$
��Left=��� -
   $ ManagePesticidesButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\9bfecbae-f085-4a77-b408-e0c68a3ac55c-removebg-preview (1).png��$��20��$��20��$��5,0,10,0q��� $%��Thuốc bảo vệ thực vật��$��Center=�$
��Left=��� -   $ ManageFertilizersButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\855d3b8c-a1f4-47c0-bd32-1390330186ed-removebg-preview.png��$��20��$��20��$��5,0,10,0q��� $��Quản lý phân bón��$��Center=�$
��Left=��� -   $ ManageProductionButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\57866269-2bd8-4869-bf57-c06cafaf6df7-removebg-preview (1).png��$��20��$��20��$��5,0,10,0q��� $!��Sản xuất trồng trọt��$��Center=�$
��Left=��� -   $ ReportButton��
������ #��[  $��40��$��0,5,0,10q�$
��Left=�.���� $
 
Horizontal=�$
��Left=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\31c8f5c5-ab91-484b-9d7c-d28f05c1eb59-removebg-preview.png��$��20��$��20��$��5,0,10,0q��� $��Thống kê - Báo cáo��$��Center=�$
��Left=��� $��1��$��1��
�������$��1q� �� CornerRadius$ 10��
�������._��� -    ��Name$ MainContent��$
��Auto��
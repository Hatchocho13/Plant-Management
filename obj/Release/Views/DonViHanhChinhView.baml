   M S B A M L   `   `   `  ����   PlantManagement.    (PlantManagement.Views.DonViHanhChinhView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� ���#FFFFFF  � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $��0��$
��Left=�$	��Top=�$��10q�
������ $��0q� � ToolTip$ 
Quay lại��.����  �� Orientation$ 
Horizontal=�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\pngtree-back-icon-arrow-photo-png-image_13614689-removebg-preview.png��$��30��$��30��$��Uniform=��� $ 
Horizontal=�$��Center=�$��	0,50,0,50q�.+��� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\pngtree-icon-location-png-image_4386689-removebg-preview.png��$��40��$��40��$��Center=�$
��10,0q��� $��Đơn vị hành chính��$��28(�$
��Bold"�$��Center=��� $��0��$ 
Horizontal=�$��Center=�$��0,0,0,10q�.+��� $ 
Horizontal=�$��Right=�$��
800,50,0,0q�.+��� -    ��Name$ SearchTextBox��$	��200��$��20��$��5q��� -    ��Name$ WatermarkText��
���   �$��-195,10,0,0q� J� IsHitTestVisible .  �� -    ��Name$ SearchButton��$��Tìm kiếm��
�������$	��100��$��20��$��5q�
�����_�� $��1��� $��2��$��	50,0,50,0q� � ColumnDefinitions �� $��1* ��� $��0.02* ��� $
��0.5* �.+��� -    ��Name$ HuyenStackPanel��$��0��
�������$y�Visible=�$	��460��.+��� $��Danh sách Huyện��$
��Bold"�$��14(�$��5q��� -   	 ��Name$	 HuyenListBox��$��1q�
�������$��5q�$��50��$	��400���� -   $ XaStackPanel��$��2��
�������$y�	Collapsed=�$��0��.+��� $��Danh sách Xã��$
��Bold"�$��14(�$��5q��� -   $	 	XaListBox��$��1q�
�������$��5q�$	��100��$	��130��
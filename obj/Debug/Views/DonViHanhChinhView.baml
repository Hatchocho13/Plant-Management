   M S B A M L   `   `   `  ����  PlantManagement.    (PlantManagement.Views.DonViHanhChinhView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � 
�������  � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Stretch=�6;   $��0,0,0,10q�6Y   .+�5      �� -   5         ��Name$ HuyenButton��5      $%��Đơn Vị Hành Chính Huyện��6*   $	��200��5   /   $��30��6;   $��5q�6G   �� 5      -   5        $ 	AddButton��5      $��Thêm��6(   $	��100��6O   $��30��6[   $��5q�6g   �� 5      -   5        $ 
EditButton��5      $��Sửa��6)   $	��100��6P   $��30��6\   $��5q�6h   �� 5      -   5        $ DeleteButton��5      $
��Xóa��6+   $	��100��6T   $��30��6`   $��5q�6l   �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��200��61   $��30��6=   $��5q�6I   5   <   �� 5      -   5         ��Name$ WatermarkText��5      $��Tìm kiếm...��63   
�������$��
-195,5,0,0q�5   .    J� IsHitTestVisible .  6B   �� 5      -   5        $ SearchButton��5      $��Tìm kiếm��6/   $	��100��6]   $��30��6i   $��5q�6u   5       5!      � 5$   
   $��1��6    � ColumnDefinitions 5%      �� 5&      $
��1.5* �6#   �� 5(      $
��0.5* �6#   .+�5-      �� -   5         ��Name$ HuyenStackPanel��5-      $��0��62   ���#F5F5F5$y�	Collapsed=�5.      $��0��60   .+�5/      �� $��Danh sách Huyện��6   $
��Bold"�63   $��14(�6E   $��5q�6S   �� 50      -	   5         ��Name$ HuyenListBox��50      $��1q�51      
�������$��5q�6A   52      �� 55      -
   5        $ XaStackPanel��55      $��1��6/   ���#EFEFEF$y�	Collapsed=�56      $��0��60   .+�57      �� $��Danh sách Xã��6   $
��Bold"�60   $��14(�6B   $��5q�6P   �� 58      -   5        $ 	XaListBox��58      $��1q�6-   
�������$��5q�6T   59      5:      5;      5<      
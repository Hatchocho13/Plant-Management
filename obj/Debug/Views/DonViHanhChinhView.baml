   M S B A M L   `   `   `  ����  PlantManagement.    (PlantManagement.Views.DonViHanhChinhView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � 
����İ�  � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��0��5      $
��Left=�5      $	��Top=�5      $��10q�5      
������ $��0q�5       � ToolTip$ 
Quay lại��5       .��5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\pngtree-back-icon-arrow-photo-png-image_13614689-removebg-preview.png��6   $��30��5#      $��30��5$      $��Uniform=�5%      5'      5(      �� 5*   
   $ 
Horizontal=�6   $��Center=�6.   $��	0,50,0,50q�6K   .+�5,      �� $����C:\Users\AD\Desktop\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Plant-Management-07a638d8414b7f224d525f816d8a96a3db0a58d0\Images\pngtree-icon-location-png-image_4386689-removebg-preview.png��6   $��40��6�   $��40��6�   $��Center=�6   $
��10,0q�6  �� 5.      $��Đơn vị hành chính��6   $��28(�61   $
��Bold"�6?   $��Center=�6Q   5/      �� 52   
   $��0��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�55      �� $ 
Horizontal=�6   $��Right=�62   $��
800,50,0,0q�6N   .+�56      �� -   5         ��Name$ SearchTextBox��56      $	��200��61   $��20��6=   $��5q�6I   57   <   �� 58      -   5         ��Name$ WatermarkText��58      
���   �$��-195,10,0,0q�59   /    J� IsHitTestVisible .  6D   �� 5:      -   5         ��Name$ SearchButton��5:      $��Tìm kiếm��6/   
�������$	��100��6p   $��20��6|   $��5q�6�   ���	#FF008EFA6�   5;      5<      � 5>   
   $��1��6   5@      � 5B   
   $��2��6   $��	50,0,50,0q�6    � ColumnDefinitions 5D      �� 5E      $��1* �6#   �� 5F      $��0.02* �6#   �� 5H      $
��0.5* �6#   .+�5M      �� -   5         ��Name$ HuyenStackPanel��5M      $��0��62   
�������$y�Visible=�5N      $	��460��6"   .+�5O      �� $��Danh sách Huyện��6   $
��Bold"�63   $��14(�6E   $��5q�6S   �� 5P      -   5        	 ��Name$	 HuyenListBox��5P      $��1q�5Q      
�������$��5q�65   $��50��5R      $	��400��6   5S      �� 5W      -   5        $ XaStackPanel��5W      $��2��6/   
�������$y�	Collapsed=�5X      $��0��60   .+�5Y      �� $��Danh sách Xã��6   $
��Bold"�60   $��14(�6B   $��5q�6P   �� 5Z      -   5        $	 	XaListBox��5Z      $��1q�6-   
�������$��5q�6T   $	��100��6_   $	��130��6l   5[      5\      5]      5^      
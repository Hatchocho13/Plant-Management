   M S B A M L   `   `   `  ����  PlantManagement&     PlantManagement.Views.BaoCaoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      
����İ�.��5      � .+�5   
   9� -   5          9�Name$  BaoCaoExpander��5      $��Báo Cáo - Thống Kê��5      $
��Left=�5	      $	��Top=�5
      $��10q�5      
���   �$	��150��5      
����·�$
��Bold"�5       9� 
IsExpanded .   K� ZIndex$	 100��5      .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ NguoiDungButton��5      $��Người Dùng��5      
�������$��5q�5      �� 5      -   5        $ LichSuTruyCapButton��5      $��Lịch Sử Truy Cập��5      
�������$��5q�5      �� 5      -   5        $ LichSuTacDongButton��5      $��Lịch Sử Tác Động��5      
�������$��5q�5!      �� 5"      -   5        $ TongHopButton��5"      $��Tổng Hợp��5#      
�������$��5q�5&      5'      5(      � 5+   
   $��0,40,0,0q�6   .+�5,      &   System.Windows.Controls.DataGrid  -   5          Name$ UserDataGrid��5,         AutoGenerateColumns . $��Stretch=�5.      $��Stretch=�5/         
IsReadOnly . $y�	Collapsed=�51        53      -   5        $ LoginHistoryDataGrid��53       . $��Stretch=�55      $��Stretch=�56       . $y�	Collapsed=�58        59      -   5        $ ImpactHistoryDataGrid��59       .  $��Stretch=�5;      $��Stretch=�5<       . $y�	Collapsed=�5>         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Tên người dùng��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *
UserName+  5A      $	 Số lần đăng nhập��6)   
 6C   �� *
LoginCount+5C        5G      -	   5        $ TongHopDataGrid��5G       . $��Stretch=�5I      $��Stretch=�5J       . $y�	Collapsed=�5L      5M      �� 5P   
   -
   5         ��Name$ MessagePlaceholder��5P      $9��3Thông báo sẽ được hiển thị tại đây.��5Q      $��Center=�5R      $��Center=�5S      $��16(�5T      $y�	Collapsed=�5U      
����  �5V      5W      5X      
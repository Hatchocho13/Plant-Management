   M S B A M L   `   `   `  ����   PlantManagement&     PlantManagement.Views.BaoCaoView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     
������.��� .+�9� -     9�Name$  BaoCaoExpander��$��Báo Cáo - Thống Kê��$
��Left=�$	��Top=�$��10q�
���   �$	��150��
����d�$
��Bold"� 9� 
IsExpanded .   K� ZIndex$	 100��.����  �� Orientation$ Vertical=�.+��� -    ��Name$ NguoiDungButton��$��Người Dùng��
�������$��5q��� -   $ LichSuTruyCapButton��$��Lịch Sử Truy Cập��
�������$��5q��� -   $ LichSuTacDongButton��$��Lịch Sử Tác Động��
�������$��5q��� -   $ TongHopButton��$��Tổng Hợp��
�������$��5q�� $��0,40,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ UserDataGrid��   AutoGenerateColumns . $��Stretch=�$��Stretch=�   
IsReadOnly . $y�	Collapsed=�  -   $ LoginHistoryDataGrid�� . $��Stretch=�$��Stretch=� . $y�	Collapsed=�  -   $ ImpactHistoryDataGrid�� .  $��Stretch=�$��Stretch=� . $y�	Collapsed=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Tên người dùng��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
UserName+  $	 Số lần đăng nhập��
 �� *
LoginCount+  -	   $ TongHopDataGrid�� . $��Stretch=�$��Stretch=� . $y�	Collapsed=��� -
    ��Name$ MessagePlaceholder��$9��3Thông báo sẽ được hiển thị tại đây.��$��Center=�$��Center=�$��16(�$y�	Collapsed=�
����  �
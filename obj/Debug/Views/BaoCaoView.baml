   M S B A M L   `   `   `  ����  PlantManagement&     PlantManagement.Views.BaoCaoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $	��600��5      $
��1168��6   
�������.��5      � .+�5   
   ��   �� Orientation$  
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��
15,10,10,5q�6a   .+�5      �� -   5         ��Name$ NguoiDungButton��5      $��Người Dùng��6.   
������$	��100��6s   $��25��6   $��5q�6�   �� 5	      -   5        $ LichSuTruyCapButton��5	      $��Lịch Sử Truy Cập��62   
������$	��120��6�   $��25��6�   $��5q�6�   �� 5
      -   5        $ LichSuTacDongButton��5
      $��Lịch Sử Tác Động��62   
������$	��120��6�   $��25��6�   $��5q�6�   �� 5      -   5        $ TongHopButton��5      $��Tổng Hợp��6,   
������$	��100��6m   $��25��6y   $��5q�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ UserDataGrid��5         AutoGenerateColumns . $
��1145��6D   $	��535��6Q   $��	0,0,0,-30q�6^   $��Center=�5      $��Center=�60      CanUserReorderColumns .     CanUserResizeColumns .    CanUserSortColumns .     
IsReadOnly . $y�	Collapsed=�5   z     5   
   -   5        $ LoginHistoryDataGrid��5       . $
��1145��6L   $	��535��6Y   $��	0,0,0,-30q�6f   $��Center=�5      $��Center=�60    .   .  .   . $y�	Collapsed=�5   z     5   
   -   5        $ ImpactHistoryDataGrid��5       . $
��1145��6M   $	��535��6Z   $��	0,0,0,-30q�6g   $��Center=�5      $��Center=�6(    .   .  .   . $y�	Collapsed=�5   r     5   
   -   5        $ TongHopDataGrid��5       . $
��1145��6G   $	��535��6T   $��	0,0,0,-30q�6a   $��Center=�5      $��Center=�6(    .   .  .   . $y�	Collapsed=�5    r   �� 5%   
   -	   5         ��Name$ MessagePlaceholder��5%      $9��3Thông báo sẽ được hiển thị tại đây.��60   $��Center=�5&      $��Center=�61   $��16(�6L   $y�	Collapsed=�5'      
����  �6+   5(      5)      
   M S B A M L   `   `   `  ����  PlantManagement/    )PlantManagement.Views.QuanLyNguoiDungView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $��Stretch=�5      $��Stretch=�6,   
�������.��5      � .+�5
   
   �� $��Thông tin người dùng��6   $��24(�60   $
��Bold"�6>   $��Center=�5      $��	0,10,0,20q�61   &   System.Windows.Controls.DataGrid  5   
       AutoGenerateColumns  .  $��10,50,10,50q�5         
IsReadOnly .  $��Stretch=�6;   $��Stretch=�6W   ��5      �� *
Accounts+ �� SelectedItem 5      �� *SelectedAccount+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6S     5      $ Tên đăng nhập��6%   $ * 6Y    6<   �� *
UserName+6Y     5      $ Họ và tên��6%   $ * 6U    68   �� *
FullName+6U     5      $ Email��6%   $ * 6N    64   �� *Email+6N     5      $ Ngày tạo tài khoản��6%   $	 150 6_    .  6A   �� *	CreatedAt+6k     5      $ ID nhóm��6%   $	 100 6T    66   �� *	GroupName+6T     5       $ Mật khẩu��6%   $	 150 6T    67   �� *
Password+6T   4  .System.Windows.Controls.DataGridCheckBoxColumn  5"      $ Trạng thái��6)   $	 100 6Z    6=   �� *
IsActive+6Z   5$      �� 5'   
   	 �� Orientation$	 
Horizontal=�6   $��Right=�6.   $��Bottom=�6J   $��10q�6e   .+�5(      �� -   5        $
��Lưu��5(      $��60��6#   $��30��6.   $��0,0,10,0q�6:   5)      �� 5*      -   5        $
��Xóa��5*      $��60��6#   $��30��6.   5+      5,      5-      5.      
   M S B A M L   `   `   `  ����   PlantManagement/    )PlantManagement.Views.QuanLyNguoiDungView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $��Stretch=�$��Stretch=�
�������.��� .+��� $��Thông tin người dùng��$��24(�$
��Bold"�$��Center=�$��	0,10,0,20q�&   System.Windows.Controls.DataGrid      AutoGenerateColumns  .  $��10,50,10,50q�   
IsReadOnly .  $��Stretch=�$��Stretch=����� *
Accounts+ �� SelectedItem �� *SelectedAccount+ �� Mode$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $ Tên đăng nhập��$ *  �� *
UserName+  $ Họ và tên��$ *  �� *
FullName+  $ Email��$ *  �� *Email+  $ Ngày tạo tài khoản��$	 150  .  �� *	CreatedAt+  $ ID nhóm��$	 100  �� *	GroupName+  $ Mật khẩu��$	 150  �� *
Password+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Trạng thái��$	 100  �� *
IsActive+�� 	 �� Orientation$	 
Horizontal=�$��Right=�$��Bottom=�$��10q�.+��� -   $
��Lưu��$��60��$��30��$��0,0,10,0q��� -   $
��Xóa��$��60��$��30��
   M S B A M L   `   `   `  ����  PlantManagement6    0PlantManagement.Views.QuanLyThongTinTaiKhoanView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $��Stretch=�5      $��Stretch=�6,   .��5      � $��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Thông tin tài khoản��6   $��24(�6/   $
��Bold"�6=   $��Center=�5      $��0,0,0,20q�61   �� 5   
   $��1��6   $��20q�6"   .+�5      �� $��Tên đăng nhập:��6   $
��Bold"�6.   �� 5      $��0,0,0,10q�62   ��6   �� *
UserName+62   �� 5      $��Họ và tên:��6   $
��Bold"�6*   �� 5      $��0,0,0,10q�62   ��6   �� *
FullName+62   �� 5      $��Email:��6   $
��Bold"�6&   �� 5      $��0,0,0,10q�6/   ��6   �� *Email+6/   �� 5      $��Ngày tạo tài khoản:��6   $
��Bold"�63   �� 5      $��0,0,0,10q�63   ��6   �� *	CreatedAt+63   �� 5      $��Nhóm người dùng:��6   $
��Bold"�60   �� 5      $��0,0,0,10q�63   ��6   �� *	GroupName+63   �� 5       $��Trạng thái:��6   $
��Bold"�6+   �� 5!      $��0,0,0,10q�6d   ��6   �� *
IsActive+   BoolToStatusConverter �� 	Converter# [  6d   5"      5#      5$      
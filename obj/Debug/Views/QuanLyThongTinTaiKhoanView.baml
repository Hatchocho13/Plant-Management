   M S B A M L   `   `   `  ����  PlantManagement6    0PlantManagement.Views.QuanLyThongTinTaiKhoanView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ���#FFFFFF.��5	      � .+�5   
   ��   �� Orientation$  
Horizontal=�6   $��Center=�6.   $	��Top=�6K   $��0,30,0,0q�6c   .+�5      �� $��Assets/Logo.png��6   $��40��6-   $��40��68   $��Center=�6D   $��	10,0,20,0q�6_   �� 5      $��20(�6   $
��Bold"�6&   $��Thông Tin Tài Khoản��68   $��
-80,0,20,0q�6S   $��Center=�6g   5      � 5   
   $��	0,100,0,0q�6   $��Center=�6"    � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $	��300 �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5       �� -   5         ��Name$ AccountInfoPanel��5       $��0��63   $��2��6@   $  Vertical=�6T   $��0,10,0,0q�6k   .+�5"      �� $��Tên đăng nhập:��6   $
��Bold"�62   $��	0,10,10,0q�6D   $��Center=�6W   $
��Left=�6r   �� 5#      -   5         ��Name$ UserNameTextBlock��5#      $��15(�68   $��	75,10,0,0q�6F   �� 5&      $��Họ và tên:��6   $
��Bold"�6.   $��	0,10,10,0q�6@   $��Center=�6S   $
��Left=�6n   �� 5'      -   5         ��Name$ FullNameTextBox��5'      $��0,10,0,0q�63   $	��300��6E   $��Center=�6Q   �� 5*      $��Email:��6   $
��Bold"�6*   $��	0,10,10,0q�6<   $��Center=�6O   $
��Left=�6j   �� 5+      -   5        $ EmailTextBox��5+      $��0,10,0,0q�60   $	��300��6B   $��Center=�6N   �� 5.      $��Quyền:��6   $
��Bold"�6*   $��	0,10,10,0q�6<   $��Center=�6O   $
��Left=�6j   �� 5/      -   5         ��Name$ RoleComboBox��5/      $��0,10,0,0q�61   $	��300��6C   $��Center=�6O   �� 52      $��Ngày tạo tài khoản:��6   $
��Bold"�67   $��	0,20,10,0q�6I   $��Center=�6\   $
��Left=�6w   �� 53      -   5        $ CreatedAtTextBlock��53      $��15(�68   $��	75,10,0,0q�6F   $��Center=�6Y   54      �� 57      $  
Horizontal=�6   $��5��62   $��2��6?   $��Center=�6S   $��0,50,0,0q�6p   .+�58      �� -   5         ��Name$ 
SaveButton��58      $
��Lưu��6-   
��� � �
�������$��16(�6a   $	��100��6o   $��30��6{   $��	10,0,10,0q�59      6,   �� 5:      -   5        $ ForgotPasswordButton��5:      $��Đổi mật khẩu��67   
����  �
�������$��16(�6s   $	��121��6�   $��30��6�   $��	10,0,10,0q�5;      6,   5<      5=      �� 5@   
   -	   5         ��Name$ ResetPasswordContent��5@      $y�	Collapsed=�67   5B      5D      5E      
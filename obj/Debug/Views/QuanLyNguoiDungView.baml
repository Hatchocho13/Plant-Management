   M S B A M L   `   `   `  ����  PlantManagement/    )PlantManagement.Views.QuanLyNguoiDungView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      
����İ�.��5      � .+�5   
   9� -   5          9�Name$  QuanLyNguoiDungExpander��5      $��Quản Lý Người Dùng��5      $
��Left=�5	      $	��Top=�5
      $��10q�5      
���   �$	��150��5      
����·�$
��Bold"�5       9� 
IsExpanded .   K� ZIndex$	 100��5      .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ 
UserButton��5      $��Người Dùng��6-   
�������$��5q�6r   �� 5      -   5        $ PermissionButton��5      $��Quản Lý Quyền��63   
�������$��5q�6{   �� 5      -   5        $ AccessHistoryButton��5      $��Lịch Sử Truy Cập��66   
�������$��5q�6�   �� 5      -   5        $ ActionHistoryButton��5      $��Lịch Sử Tác Động��66   
�������$��5q�6�   5      5      �� 5   
   -   5         ��Name$ SearchUserPanel��5      $ 
Horizontal=�6.   $��Right=�6G   $	��Top=�6c   $��	10,8,10,0q�6{   $y�	Collapsed=�6�   .+�5      �� -   5         ��Name$ SearchUserTextBox��5      $	��300��61   $��25��6=   $��Center=�6I    �� TextAlignment$
 Left=�6k   $��0q�6�   6�   �� 5      -   5        $��Tìm kiếm��5      $	��100��6(   $��25��64   $��5,0,0,0q�6@   ���#0078D7
�������$
��Bold"�6y   6�   5      �� 5!   
   -	   5        $ SearchAccessHistoryPanel��5!      $ 
Horizontal=�67   $��Right=�6P   $	��Top=�6l   $��	10,8,10,0q�6�   $y�	Collapsed=�6�   .+�5"      �� -
   5        $  SearchAccessHistoryTextBox��5"      $	��300��6:   $��25��6F   $��Center=�6R   $
 Left=�6t   $��0q�6�   6�   �� 5#      -   5        $��Tìm kiếm��5#      $	��100��6(   $��25��64   $��5,0,0,0q�6@   ���#0078D7
�������$
��Bold"�6y   6�   5$      �� 5&   
   -   5        $ SearchActionHistoryPanel��5&      $ 
Horizontal=�67   $��Right=�6P   $	��Top=�6l   $��	10,8,10,0q�6�   $y�	Collapsed=�6�   .+�5'      �� -   5        $  SearchActionHistoryTextBox��5'      $	��300��6:   $��25��6F   $��Center=�6R   $
 Left=�6t   $��0q�6�   6�   �� 5(      -   5        $��Tìm kiếm��5(      $	��100��6(   $��25��64   $��5,0,0,0q�6@   ���#0078D7
�������$
��Bold"�6y   6�   5)      � 5,   
   $��0,40,0,0q�6   .+�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ UserGroupDataGrid��5-      	   AutoGenerateColumns	 . $��Stretch=�6M   $��Stretch=�6k   
   
IsReadOnly
 . $y�	Collapsed=�6�   � 5/      .+�50        -   5        $ UserDataGrid��50      	 . $��Stretch=�6L   $��Stretch=�6j   
 .  $y�	Collapsed=�6�   �� 53      -   5        $ UpdateDeleteUserPanel��53      $ 
Horizontal=�6<   $��Right=�6U   $��Bottom=�6q   $��20q�6�   $y�	Collapsed=�6�   .+�54      �� -   5        $ UpdateUserButton��54      $��Cập nhật��67   $��80��6J   $��30��6U   ���	#FF0B930B
�������$
��Bold"�6�   $��20q�6�   6�   �� 55      -   5        $ DeleteUserButton��55      $
��Xóa��67   $��60��6E   $��30��6P   ���	#FFE32B2B
�������$
��Bold"�6�   6�   56      �� 58      -   5        $ AddNewUserPanel��58      $ 
Horizontal=�66   $
��Left=�6O   $��Bottom=�6j   $��20q�6�   $y�	Collapsed=�6�   .+�59      �� -   5        $ AddNewUserButton��59      $��+ Thêm mới��67   $��80��6L   $��30��6W   ���	#FF008EFA
�������$
��Bold"�6�   $��20q�6�   6�   5:      5;        5=      -   5        $ PermissionDataGrid��5=      	 . $��Stretch=�6N   $��Stretch=�6l   
 . $y�	Collapsed=�6�     5>      -   5        $ AccessHistoryDataGrid��5>      	 . $��Stretch=�6Q   $��Stretch=�6o   
 . $y�	Collapsed=�6�     5?      -   5        $ ActionHistoryDataGrid��5?      	 . $��Stretch=�6Q   $��Stretch=�6o   
 . $y�	Collapsed=�6�   �� 5B      -   5         ��Name$ AddUserContentControl��5B      $��Stretch=�5C      $��Stretch=�5D      $y�	Collapsed=�5E      5G      5H      5I      
   M S B A M L   `   `   `  ����  PlantManagement&     PlantManagement.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quản lý trồng trọt��5   	   $	��600��6$   $
��1168��61    � WindowStartupLocation$ CenterScreen=�6>   .��5      � .+�5   
   �� -   5         ��Name$ InitialPanel��5      $��Center=�6+   $��Center=�6F   $y�Hidden=�6c   .+�5	      �� -   5         ��Name$ LoginButton��5	      $��Đăng Nhập��6*   $	��250��6>   $��50��6J   $
��0,15q�6p   ���#4CAF50
�������$
��Bold"�6�   ���#388E3C$��2q�6�    � Cursor$
 Hand��6�   �� 5
      -   5        $ RegisterButton��5
      $��
Đăng Ký��6-   $	��250��6?   $��50��6K   $
��0,15q�6t   ���#2196F3
�������$
��Bold"�6�   ���#1976D2$��2q�6�   $
 Hand��6�   5      � 5   
   -   5         �Name$ 	MainPanel��5      $y�Visible=�6"   ���#E8F5E9$��20q�6L    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��2��6    ���#4CAF50$��80��6I    5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5       ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $
��Left=�6Q   $
��10,0q�6l   .+�5!      �� $��Quản Lý Trồng Trọt��6    $��24(�6:   $
��Bold"�6H   
�������$��Center=�6m   $
��10,0q�6�   5"      �� 5%      $ 
Horizontal=�6   $��Center=�66   $��Right=�6Q   $
��20,0q�6m   $��1��6{   .+�5&      �� -   5        $��
My Account��5&      $	��100��62   $��35��6>   ���#E8F5E9
���   �$
��Bold"�5'   )   $��1q�6;   $
 Hand��6O   $��0,0,10,0q�5(   4   �� 5*      -   5        $��Đăng Xuất��5*      $	��100��61   $��35��6=   ���#FF5722
�������$
��Bold"�6q   ���#D84315$��1q�6�   $
 Hand��6�   $��	10,0,10,0q�6�   5+      5,      �� 5/      $��1��6   $��0��6&   ���#E8F5E9.+�51      �� $T��NC:\Users\AD\Desktop\PlantManagement\PlantManagement\cropped-logo-vingarden.png��6   $	��200��6p   $	��Top=�6}   $��Center=�6�   $��	0,20,0,20q�6�   �� 54      $ Vertical=�6   $��Stretch=�64   $��20q�6R   .+�56      �� -   5        $ ManageUserButton��56         SidebarButtonStyle#��[  67   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��57      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�58      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 59      $��Quản lý người dùng��6(   $��Center=�6B   $
��Left=�6]   5:      5;      �� 5>      -   5        $$ ManageAdministrativeUnitButton��5>      #��[  6E   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��5?      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5@      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5A      $��Đơn vị hành chính��6(   $��Center=�6A   $
��Left=�6\   5B      5C      �� 5F      -	   5        $ ManagePlantVarietyButton��5F      #��[  6?   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��5G      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5H      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5I      $%��Quản lý giống cây trồng��6(   $��Center=�6G   $
��Left=�6b   5J      5K      �� 5N      -
   5        $ ManagePesticidesButton��5N      #��[  6=   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��5O      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5P      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5Q      $%��Thuốc bảo vệ thực vật��6(   $��Center=�6E   $
��Left=�6`   5R      5S      �� 5V      -   5        $ ManageFertilizersButton��5V      #��[  6>   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��5W      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5X      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5Y      $��Quản lý phân bón��6(   $��Center=�6@   $
��Left=�6[   5Z      5[      �� 5^      -   5        $ ManageProductionButton��5^      #��[  6=   $��40��6�   $��	0,10,0,10q�6�   $
��Left=�6�   .��5_      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5`      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5a      $!��Sản xuất trồng trọt��6(   $��Center=�6C   $
��Left=�6^   5b      5c      �� 5f      -   5        $ ReportButton��5f      #��[  63   $��40��6z   $��	0,10,0,10q�6�   $
��Left=�6�   .��5g      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5h      �� $O��IC:\Users\AD\Desktop\PlantManagement\PlantManagement\Images\realmadrid.png��6$   $��20��6w   $��20��6�   $��5,0,10,0q�6�   �� 5i      $��Thống kê - Báo cáo��6(   $��Center=�6B   $
��Left=�6]   5j      5k      5l      5m      �� 5p      $��1��6   $��1��6"   
�������	 �� CornerRadius$	 5��6E   
 �� Padding$
 10q�6V   $��20q�6c   ���#4CAF50$��1q�5q      ._�5r      �� -   5         ��Name$ MainContent��5r   !   $��Stretch=�66   $��Stretch=�6R   5s      5u      5v      5w      
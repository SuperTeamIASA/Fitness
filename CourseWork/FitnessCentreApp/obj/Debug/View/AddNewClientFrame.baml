   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      I)clr-namespace:FitnessCentreApp.PropertiesFitnessCentreApp.Properties  5      -    'FitnessCentreApp.View.AddNewClientFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5      9res)clr-namespace:FitnessCentreApp.Properties     5        N� Title$  AddNewClientFrame��5
       � DataContext 5      ;  5FitnessCentreApp.ViewModel.AddNewClientFrameViewModel  5   
   6-    � 	Resources 5         	TextStyle �� 
TargetType �� Property �� Value  BoxStyle��%�  &	        &	 �     �� 5   
   " ��6"   .�5      ��  � ��$ 25(�6)   66   �� 5       � ��$ Verdana)�6+   6>   �� 5       � ��$	 200��6&   64   �� 5       � ��$ 40��6'   64   5      �� 5   
   " ��6!   .�5      ��  � ��$ 16(�6)   66   �� 5       � ��$ 30��6'   64   �� 5       � ��$ 10q�6'   64   �� 5       � ��$	 150��6&   64   �� 5       � ��$ 2q�60   6<   �� 5       � ��
 �   �6=   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5       $��8* �6   6*   �� 5!      $	��19* �6   6+   �� 5"      $��8* �6   6*    � ColumnDefinitions 5$   
   �� 5%      $	��20* �6   6-   �� 5&      $	��49* �6   6-   �� 5'      $	��20* �6   6-   .+�5)   
   �� $��1��6   $��0��6$   $2��,Добавить нового клиента��61   $��Center=�6P   $��Bottom=�6m   $��40(�6�   6�   �� 5*   
   $��1��6   $��1��6%   .+�5+      �  � Orientation$ Vertical=�6   $��30q�6/   .+�5,      �� 	 �� Orientation$	 
Horizontal=�6   .+�5-      �� $��Имя��6    #��[  6+   6P   �� 5.      #��[ 6   ��6A   �� 
 �� Path$
 CurrentClient.Name� �� UpdateSourceTrigger$ PropertyChanged=�5/      �� 50      $	 
Horizontal=�6   .+�51      �� $��Фамилия��6    #��[  6/   6T   �� 52      #��[ 6   ��6A   �� $
 CurrentClient.Surname�$ PropertyChanged=�53      �� 54      $	 
Horizontal=�6   .+�55      �� $��Email��6    #��[  6-   6R   �� 56      #��[ 6   ��6A   �� $
 CurrentClient.Email�$ PropertyChanged=�57      �� 58      $	 
Horizontal=�6   .+�59      �� $��Телефон��6    #��[  6/   6U   �� 5:      #��[ 6   ��6@   �� $
 CurrentClient.Phone�$ PropertyChanged=�5;      5>      �� 5?      $	 
Horizontal=�6   $��Center=�62   .+�5@      �� $��Center=�6   $��40��6[   $	��100��6g   $��20q�6s   $��
Сброс��6   ��66   �� *DeleteRowCommand+6   �� 5A      $��Center=�6   $��40��66   $	��100��6g   $��20q�6s   $��Добавть��6   ��6B   �� *AddClientCommand+6   5B      5C      �� 5D   
   $��Center=�6,   
��� � �$	��200��6\   $��25(�6h   $��125,41,164.6,89q�6v   $��1��6�   $��2��6�   ��6   �� *Result+6�   5E      5F      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      %    FitnessCentreApp.View.ChatFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5        N� Title$  	ChatFrame��5
       � DataContext 5      3  -FitnessCentreApp.ViewModel.ChatFrameViewModel  5   
   6%    � 	Resources 5         MessegeStyle �� 
TargetType �� Property �� Value  MessageAuthor��%�   &	        &	 M     �� 5   
   " ��6%   .�5      ��  � ��$ 15(�6)   66   5      �� 5   
   " ��6&   .�5      ��  � ��$ 15(�6)   66   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��295* �6   �� 5      $
��594* �6   .+�5   
   �� $��0��6   $��50 100 35 120q�6"   ��69   ��  �� Path$ 	ChatUsers���5      �� 5       .R�5!      �� $��80��6!    �� Orientation$ 
Horizontal=�6-   .+�5"      �� $ Vertical=�6%   .+�5#      �� ��6(   �� $
 Name��� 5$      ��6(   �� $ Surname�5%      5'      5(      5*      �� 5+   
   $��1��6   $��50q�6%   .+�5,      �� $	��400��6   $��
40 40 95 0q�6#   ��67   �� $ MessagesWithUser�	 �� UpdateSourceTrigger$	 PropertyChanged=���5-      �� 5.      .R�5/      �� ._�50      �� $ 
Horizontal=�6%   ��6?   �� $ 	alignment�.+�51   "   �� $ Vertical=�6-   .+�52   &   �� #��[ 6V   ��60   �� $ CurrentUserName�6V   �� 53   &   $
��Wrap=�60   #��[  6f   ��6D   �� $ MessageText�6f   54   #   �� 55   "   $��Center=�6,   ��6G   �� $ Timeofmessage�
 �� StringFormat$
 {0:MM/dd/yy H:mm}��56      57      58      5:      �� 5;      $ 
Horizontal=�6   $��	40 0 0 0 q�62   .+�5<      �� $��60��6   
���   �$��3q�6:   $	��250��6N    �� TextWrapping$
 Wrap=�6Z   ��6p   �� $ Message�$	 PropertyChanged=��� 5=      $ Vertical=�6   $��10 10q�64   .+�5>      �� $��Очистить��6   $	��100��60   $��25��6<   $��0 0 0 5q�6H   ��6Y   �� *ClearCommand+�� 5?      $��Отправить��6   $��25��61   ��6=   �� *SendCommand+5@      5A      5B      5D      5E      
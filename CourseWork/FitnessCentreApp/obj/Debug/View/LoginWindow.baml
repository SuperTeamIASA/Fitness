   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5   	   '    !FitnessCentreApp.View.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:FitnessCentreApp.ViewModel     5   	   -   5        $��loginWin��5        � Title$  Аунтификация��6   $	��200��6+   $	��300��68    � 
ResizeMode$ NoResize=�6D    � ShowInTaskbar .   � Topmost .  � WindowStartupLocation$ CenterOwner=�6    � WindowStyle$ 
ToolWindow=�6�    � DataContext 5	      5  /FitnessCentreApp.ViewModel.LoginWindowViewModel  5
   
   6'   .��5      �� $��10q�6   .+�5   
   �� -   5        $��Text1��5      $4��.Введите пароль директора��6!   $��Center=�6A   ��6^   ��  �� ElementName$ Password�� �� Path$ BorderBrush�	 �� Mode$	 TwoWay=�G� 5   
   -   5        $��Password��5      $��40 10 40 0 q�6&   
 G� 	MaxLength$
 16��6;   
���   �6`   �� 5   
   $��Подтвердить��6   $��Center=�6'   $
��0 8 q�6c   $��Center=�6�   ��6B   �� *LoginCommand+��6q   �� $ loginWin��6�   �� 5   
   -   5        $��Cancel��5      $��Отмена��6   $��Center=�60   $��Center=�6�   ��6M   �� *CancelCommand+��6o   �� $ loginWin��6�   5      5      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FitnessCentreApp.ViewFitnessCentreApp.View  5      G(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      *    $FitnessCentreApp.View.Controls_Admin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FitnessCentreApp.View     5      6q(clr-namespace:FitnessCentreApp.ViewModel     5        N� Title$  Controls_Admin��5
       N� ShowsNavigationUI .   � DataContext 5      8  2FitnessCentreApp.ViewModel.Controls_AdminViewModel  5   
   6&    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6$   .�5      ��  � ��$
 20 5q�6'   66   �� 5       � ��$	 200��6&   64   �� 5       � ��$ 55��6'   64   5      5      .��5      �� .+�5   
   �� -   5        $��DirectorMode��5      $��Директор��6%   #��[  6b   ��68   �� *DirectorModeCommand+6b   �� 5   
   $2��,Добавить нового клиента��6   #��[  6[   ��63   �� *AddNewClientCommand+6[   �� 5    
   $,��&Операции с клиентами��6   #��[  6\   ��61   �� *OperationClientCommand+6\   �� 5!   
   $%��Довавить новость��6   #��[  6L   ��6,   �� *NewsCommand+6L   �� 5"   
   $��Расписание��6   #��[  6J   ��6&   �� *ScheduleCommand+6J   �� 5#   
   $��Чат��6   #��[  6?   ��6   �� *ChatCommand+6?   5$      5&      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      $    FitnessCentreApp.View.Schedule   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5        N� Title$  Schedule��5	      $
��auto��6   $
��auto��6%    � DataContext 5
      2  ,FitnessCentreApp.ViewModel.ScheduleViewModel  5   
   6$   ��5      � 5      
������� � ColumnDefinitions 5   
   �� 5      $
��501* �6   6.   �� 5      $
��389* �6   6.   .+�5   
   �� $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ ��Выберите дату:��6   64   (  "System.Windows.Controls.DatePicker  5      $	��100��6      SelectedDate 6,   ��  �� Path$ SelectedDate�6Y   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ ScheduleGrid��5         CanUserAddRows .     AutoGenerateColumns .  	   CanUserDeleteRows	 .  $	��500��6|   
   HeadersVisibility$	
 All=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Время��6)   6;   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Зал1��6-      CellTemplate 5      �� 5      .R�5   "   �� .+�5    &   �� 62   �� 5!   &   62   5"   #   5#      5%      5'      5(      �� 5)   
   $��1��6   .+�5*      �� $%��Добавить занятие��6   62   �� 5+      $ 
Horizontal=�6   .+�5,      �� $	��100��6   $��Занятие:��6+   6=   �� 5-      $	��100��6   6,   5.      �� 5/      $ 
Horizontal=�6   .+�50      �� $	��100��6   $��Тренер:��6+   6<   �� 51      $	��100��6   6,   53      �� 54      $ 
Horizontal=�6   .+�55      �� $	��100��6   $��Зал:��6+   69   �� 56      $	��100��6   6,   57      �� 58      $��Добавить��6   $�� ��6(   65   �� 59      $��Удалить��6   6)   �� 5:      $��Изменить��6   6*   5;      5<      5>      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      +    %FitnessCentreApp.View.IncomeCashFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5        N� Title$  IncomeCashFrame��5	       � DataContext 5
      9  3FitnessCentreApp.ViewModel.IncomeCashFrameViewModel  5   
   6+    � 	Resources 5         	TextStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6"   .�5      ��  � ��$ 20(�6)   66   �� 5       � ��$ 10q�6'   64   �� 5       � ��$	 210��6)   67   5      5      .��5      � 
�������.+�5   
   �� $	��40 q�6   .+�5      �� $!��Доходы/расходы��6   $��Center=�6.   $��40(�6K   $��20q�6Y   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $(��"Выбрать период: ОТ ��6   $��20(�67   6G   (  "System.Windows.Controls.DatePicker  5      $��2 0 0 0q�6      SelectedDate 6.   �� *
DateFrom+�� 5      $	��5 0q�6   $��20(�6)   $
��ДО��68     5      $��2 0 0 0q�6    6.   �� *DateTo+5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Доходы:��6   #��[  6+   �� 5      $	��100��6   ��6+   ��  �� Path$ CashInfo.allincash�5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $.��(Зарплата сотрудников:��6   #��[  6:   �� 5#      $	��100��6   ��6+   �� $ CashInfo.salarycash�5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Налоги:��6   #��[  6+   �� 5'      $	��100��6   ��6+   �� $ CashInfo.podatok�5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $"��Чистая прибиль:��6   #��[  63   �� 5+      $	��100��6   ��6+   �� $ CashInfo.flowcash�5,      �� 5-      $	��100��6   $
��Left=�6;   $��10 40q�6V   $
��5 10q�6e   
�������$��Печать��6�   ��6!   �� *Print+6�   5.      5/      50      
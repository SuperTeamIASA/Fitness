   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      ,    &FitnessCentreApp.View.PostSettingFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5        N� Title$  PostSettingFrame��5	       � DataContext 5
      :  4FitnessCentreApp.ViewModel.PostSettingFrameViewModel  5   
   6,    � 	Resources 5         TextStle �� 
TargetType �� Property �� Value��%W   &	        �� 5   
   " ��6!   .�5      ��  � ��$ 14(�6)   66   5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   .+�5      �� $��Должность��6   $��Center=�6)   $��30(�6F   $
��0 30q�6T   �� 5      $��100 0 100 0q�6   $	��400��6,    �� SelectedIndex 6<   �� *SelectedPostIndex+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=���5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6%   .+�5      �� $
 Vertical=�6)   .+�5   "   �� #��[  6L   ��6-   ��  �� Path$ postName�6L   �� 5   "   ��6,   �� $ salary�5       5!      5"      5$      5%      �� 5&   
   $��1��6   $��	0 100 0 0q�6%    J� RenderTransformOrigin$ 0.5,0.5&�68   z�5'      V� 5(      .~�5)      �� �� 5*       �� AngleY$ -0.718Q�6$   �� 5+      T� 5,       T� Y$ 2.787Q�6)   5-      .+�5/      �� $
 
Horizontal=�6   $��10q�62   .+�50      �� $��Назавние��6   #��[  6,   �� 51      $	��100��6   $��10 0 0 0q�6)   ��6;   �� *SelectedPost.postName+52      �� 53      $
 
Horizontal=�6   $��10q�62   .+�54      �� $��Зарплата��6   #��[  6,   �� 55      $	��100��6   $��10 0 0 0q�6O   ��6*   �� *SelectedPost.salary+6O   56      �� 57      $
 
Horizontal=�6   $��10q�62   .+�58      �� $3��-Количевство сотрудников��6   #��[  6;   �� 59      $��10 0 0 0q�6   ��6/   �� *
EmpCount+5;      �� 5<      $!��Доп информация��6   $��10 0 0 0q�6.   #��[  6@   �� 5=      $��10,10,9.8,10q�6    �� TextWrapping$
 Wrap=�6,   $	��154��6�   {�6A   ��  �� ElementName$ 
CanChanged��$ 	IsChecked���6}   �� *SelectedPost.description+6�   �� 5>      $
 
Horizontal=�6   $��10q�62   .+�5?      �� $��Сохранить��6   $
��10 0q�6M   ��6-   �� *SaveCommand+6M   �� 5@      $��Добавить��6   $
��10 0q�6K   ��6,   �� *
AddCommand+6K   �� 5A      $��Удалить��6   $
��10 0q�6J   ��6+   �� *
DelCommand+6J   5B      5C      5D      5E      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5      %    FitnessCentreApp.View.NewsFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:FitnessCentreApp.ViewModel     5        N� Title$  	NewsFrame��5	       � DataContext 5
      3  -FitnessCentreApp.ViewModel.NewsFrameViewModel  5   
   6%    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6$   .�5      ��  � ��$ 60��6'   64   �� 5       � ��$ 20q�6'   64   �� 5       � ��$	 160��6&   64   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��329* �6   6.   �� 5      $
��561* �6   6.   .+�5   
   �� $��0��6   $��Center=�6&   $��Center=�6C   .+�5      �� $%��Добавить новость��6   #��[  60   ��6U   �� *AddNewCommand+�� 5      $ ��Редактировать��6   #��[  6-   ��6R   �� *NewSettingCommand+�� 5      $��Удалить��6   #��[  6'   ��6L   �� *DeleteCommand+5      �� 5   
   $��1��6   $��30q�6"   ��6.   ��  �� Path$
 NEWS� �� SelectedIndex 6P   �� $ SelectedListItem���5      �� 5       .R�5!      �� $��2q�6   
���   �$	��450��6E   ._�5"      � $��5q�6   	 � RowDefinitions	 5#      �� 5$   "   62   �� 5%   "   62   .+�5(      �� $��0��6(   $��20(�65   $
��Left=�6C   $	��Top=�6^   $��DemiBold"�6v   $��Verdana)�6�   ��6�   �� $ Title�9� 5)      $��1��6'   ��5*   "   �� 5+   &   .+�5,   &   �� $��Center=�60   $
��Left=�6K   ��6f   �� $ NewText��� 5-   *   ��60   �� $ Image�51   '   53      58      59      5:      5<      5=      5>      
   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FitnessCentreAppFitnessCentreApp  5   	   =#clr-namespace:FitnessCentreApp.ViewFitnessCentreApp.View  5   	   G(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5   	   !    FitnessCentreApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FitnessCentreApp     5   	   1a#clr-namespace:FitnessCentreApp.View     5   	   6q(clr-namespace:FitnessCentreApp.ViewModel     5   	     � Title$  Fitness Center��5
   	   $	��720��6    $
��1280��6-    � Icon$ Images/icon.png��6:    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6$   .�5      ��  � ��$
 20 5q�6'   66   �� 5       � ��$	 200��6&   64   �� 5       � ��$ 55��6'   64   5      5       � DataContext 5      4  .FitnessCentreApp.ViewModel.MainWindowViewModel  5   
   6"   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��363* �6   �� 5      $
��910* �6   6.   .+�5   
    � -   5          �Name$ 	FlameMain��5      $��1��6$   $��10q�64   	  � NavigationUIVisibility$	 Hidden=�6@   ��6`   �� 
 �� Path$
 	MainFrame� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      � 5   
   $��0��6   $��0,0,2.2,0.4q�6    5      �� 5       $	��43* �6#   61   �� 5!      $��265.6 �6#   63   �� 5$      $	��52* �6#   61    � RowDefinitions 5&      �� 5'      $	��85* �6    6/   �� 5(      $��421.6 �6    61   �� 5+      $	��49* �6    6/   .+�5-      �� $��2��6   $
��Left=�6&   $��Bottom=�6A    �� Orientation$ 
Horizontal=�6\   $��2��6u   $��43,0,0,-0.4q�6�   $
��auto��6�   .+�5.      �� $��40��6   $
��auto��6(   $��20(�65   $��Server connection:��6C   $��10q�6]   6k   �� 5/      $��online��6   $��20(�6*   
��� � �$��40��6K   6Y   51       � 53      -   5        $��ControlsFrame��53      $��1��6)   $��1��69   $	 Hidden=�6F   ��6g   �� $
 Controls�$ PropertyChanged=�$ TwoWay=�6�   55      57      58      
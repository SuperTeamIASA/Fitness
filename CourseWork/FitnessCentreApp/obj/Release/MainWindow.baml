   M S B A M L   `   `   `  ���� K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FitnessCentreAppFitnessCentreApp  =#clr-namespace:FitnessCentreApp.ViewFitnessCentreApp.View  G(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  !    FitnessCentreApp.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:FitnessCentreApp     1a#clr-namespace:FitnessCentreApp.View     6q(clr-namespace:FitnessCentreApp.ViewModel       � Title$  Fitness Center��$	��720��$
��1280�� � Icon$ Images/icon.png�� � 	Resources    ButtonStyle �� 
TargetType �� Property �� Value��%\   &	        �� " ��.���  � ��$
 20 5q���  � ��$	 200����  � ��$ 55�� � DataContext 4  .FitnessCentreApp.ViewModel.MainWindowViewModel  .���  � ColumnDefinitions �� $
��363* ��� $
��910* �.+� � -     �Name$ 	FlameMain��$��1��$��10q�	  � NavigationUIVisibility$	 Hidden=����� 
 �� Path$
 	MainFrame� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�� $��0��$��0,0,2.2,0.4q� �� $	��43* ��� $��265.6 ��� $	��52* � � RowDefinitions �� $	��85* ��� $��421.6 ��� $	��49* �.+��� $��2��$
��Left=�$��Bottom=� �� Orientation$ 
Horizontal=�$��2��$��43,0,0,-0.4q�$
��auto��.+��� $��40��$
��auto��$��20(�$��Server connection:��$��10q��� $��online��$��20(�
��� � �$��40�� � -   $��ControlsFrame��$��1��$��1��$	 Hidden=����� $
 Controls�$ PropertyChanged=�$ TwoWay=�
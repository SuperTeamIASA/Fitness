   M S B A M L   `   `   `  ���� K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  3clr-namespace:FitnessCentreAppFitnessCentreApp  %    FitnessCentreApp.View.NewsFrame   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:FitnessCentreApp.ViewModel     .resclr-namespace:FitnessCentreApp       N� Title$  	NewsFrame�� � DataContext 3  -FitnessCentreApp.ViewModel.NewsFrameViewModel   � 	Resources    ButtonStyle �� 
TargetType �� Property �� Value��%Z   &	        �� " ��.���  � ��$ 60����  � ��$ 20q���  � ��$	 160��.���  � ColumnDefinitions �� $
��329* ��� $
��561* �.+��� $��0��$��Center=�$��Center=�.+���   FitnessCentreApp.Strings   addNew#��Z #��[  ���� *AddNewCommand+��    	doChanges#��Z #��[  ���� *NewSettingCommand+�� 	   
delete_new#��Z	 #��[  ���� *DeleteCommand+�� $��1��$��30q����� 
 �� Path$

 NEWS� �� SelectedIndex �� $
 SelectedListItem����� .R��� $��2q�
���   �$	��450��._�� $��5q� � RowDefinitions �� �� .+��� $��0��$��20(�$
��Left=�$	��Top=�$��DemiBold"�$��Verdana)����� $
 Title�9� $��1������ .+��� $��Center=�$
��Left=����� $
 NewText��� 
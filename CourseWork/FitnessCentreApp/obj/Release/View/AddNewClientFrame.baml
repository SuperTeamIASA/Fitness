   M S B A M L   `   `   `  ���� K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  3clr-namespace:FitnessCentreAppFitnessCentreApp  -    'FitnessCentreApp.View.AddNewClientFrame   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:FitnessCentreApp.ViewModel     .resclr-namespace:FitnessCentreApp       N� Title$  AddNewClientFrame�� � DataContext ;  5FitnessCentreApp.ViewModel.AddNewClientFrameViewModel   � 	Resources    	TextStyle �� 
TargetType �� Property �� Value  BoxStyle��%  &	        &	 k     �� " ��.���  � ��$ 25(���  � ��$ Verdana)���  � ��$	 200����  � ��$ 40���� " ��.���  � ��$ 16(���  � ��$ 30����  � ��$ 10q���  � ��$	 150����  � ��$ 2q���  � ��
 �   �.��� 
������� � RowDefinitions �� $��8* ��� $	��19* ��� $��8* � � ColumnDefinitions �� $	��20* ��� $	��49* ��� $	��20* �.+��� $��1��$��0��  FitnessCentreApp.Strings   addnewclient#��Z $��Center=�$��Bottom=�$��40(��� $��1��$��1��.+�� 	 � Orientation$	 Vertical=�$��30q�.+��� 
 �� Orientation$
 
Horizontal=�.+���    name#��Z #��[  �� #��[ ����  �� Path$ CurrentClient.Name� �� UpdateSourceTrigger$ PropertyChanged=��� $
 
Horizontal=�.+���    lastname#��Z #��[  �� #��[ ���� $ CurrentClient.Surname�$ PropertyChanged=��� $
 
Horizontal=�.+���    email#��Z #��[  �� #��[ ���� $ CurrentClient.Email�$ PropertyChanged=��� $
 
Horizontal=�.+���    phone#��Z #��[  �� #��[ ���� $ CurrentClient.Phone�$ PropertyChanged=��� $
 
Horizontal=�$��Center=�.+��� $��Center=�$��40��$	��100��$��20q�   _break#��Z ���� *DeleteRowCommand+�� $��Center=�$��40��$	��100��$��20q�
   add#��Z ���� *AddClientCommand+�� $��Center=�
��� � �$	��200��$��30��$��25(����� $ Result� �� Mode$ TwoWay=�
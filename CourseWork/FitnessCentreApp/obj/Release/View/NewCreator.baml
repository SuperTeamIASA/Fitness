   M S B A M L   `   `   `  ���� K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  3clr-namespace:FitnessCentreAppFitnessCentreApp  &     FitnessCentreApp.View.NewCreator   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:FitnessCentreApp.ViewModel     .resclr-namespace:FitnessCentreApp       � Title$#  Создать новость��$	��300��$	��450��.���� $��20q�.+���   FitnessCentreApp.Strings   title#��Z $	��Top=�$
��Left=�$��10 5 5 5q�$��13(��� -    ��Name$ 
Titleblock�� �� TextAlignment$
 Left=�$
��Left=�$��20��$��10 0 0 0q�$	��150��
���   �$��1q�$��1������  �� Path$ CurrentNew.Title� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=���    maintext#��Z $
��Left=�$��10 5 5 5q�$��13(��� -   $ 	TextBlock��$��10q�$��70��$��1q�
���   �$��16(�$��2������ $ CurrentNew.NewText�$ PropertyChanged=�$ OneWay=���  �� Orientation$ 
Horizontal=�.+��� 	   attachimage#��Z	 $��Stretch=�$
��Left=�$��	20 0 0 0 q�$��30��$��3������ *AttachPhotoCommand+�� 
   addNew#��Z
 $��Right=�$��150 10 10 10q�$��30��$��4������ *AddNewCommand+
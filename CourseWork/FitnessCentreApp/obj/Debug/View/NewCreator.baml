   M S B A M L   `   `   `  ����K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  5   	   &     FitnessCentreApp.View.NewCreator   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:FitnessCentreApp.ViewModel     5   	     � Title$#  Создать новость��5   	   $	��300��6!   $	��450��6.   .��5	      �� $��20q�6   .+�5
   
   �� $��Заголовок��6   $	��Top=�6&   $
��Left=�6>   $��10 5 5 5q�6Y   $��13(�6k   �� 5   
   -   5         ��Name$ 
Titleblock��5       �� TextAlignment$
 Left=�6&   $
��Left=�6;   $��20��6V   $��10 0 0 0q�6b   $	��150��6t   
���   �$��1q�6�   $��1��6   ��6�   ��  �� Path$ CurrentNew.Title� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=�6   �� 5   
   $!��Основной текст��6   $
��Left=�6+   $��10 5 5 5q�6F   $��13(�6X   �� 5   
   -   5        $ 	TextBlock��5      $��10q�6%   $��70��61   $��1q�6=   
���   �$��16(�6e   $��2��6�   ��6s   �� $ CurrentNew.NewText�$ PropertyChanged=�$ OneWay=�6�   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��Attach��5      $'��!Вставить картинку��6#   $��Stretch=�6?   $
��Left=�6�   $��	20 0 0 0 q�6�   $��30��6�   $��3��6�   ��6[   �� *AttachPhotoCommand+6�   �� 5      $%��Добавить новость��6   $��Right=�60   $��150 10 10 10q�6L   $��30��6b   $��4��6�   ��6n   �� *AddNewCommand+6�   5      5      5      
   M S B A M L   `   `   `  ���� K  GFitnessCentreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:FitnessCentreApp.ViewModelFitnessCentreApp.ViewModel  3clr-namespace:FitnessCentreAppFitnessCentreApp  0    *FitnessCentreApp.View.ClientOperationFrame   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:FitnessCentreApp.ViewModel     .resclr-namespace:FitnessCentreApp       N� Title$  ClientOperationFrame�� � DataContext >  8FitnessCentreApp.ViewModel.ClientOperationFrameViewModel   � 	Resources    	TextStyle �� 
TargetType  TextBoxStyle  TextBindStyle  ButtonStyle  TextInfoStyle  TextBindInfoStyle��%x   &	        &	 
     &	      &	      &	 (     &	 2     �� " ���� " ���� " ���� " ���� " ���� " ��.��� 
������� � ColumnDefinitions �� $
��700* ��� $
��290* �.+�� $��0�� � RowDefinitions �� $
��119* ��� $
��238* ��� $
��342* �.+��� $��0��.+��� $��Найти клиента��$��Center=�$��30(���  �� Orientation$ 
Horizontal=�.+��� $��Имя��$��10q��� $��	10 0 10 0q�$��20��$	��100��
���   �$��1q��� $��Фамилия��$��10q��� $��	10 0 10 0q�$��20��$	��100��
���   �$��1q��� $��Center=�$	��120��$��0 10 0 0q��� $��1��.+��� $��Абонимент���� $ 
Horizontal=�.+��� $'��!Текущий абонимент��#��[  �� #��[ �� $ 
Horizontal=�.+��� $��Осталось дней��#��[  �� #��[ �� $ 
Horizontal=�.+��� $6��0Осталось груповых занятий��#��[  �� #��[ �� $P��JКупить дополнительные груповые занятия:��#��[  �� $ 
Horizontal=�.+��� $,��&Количевство занятий:��#��[  �� #��[ �� $H��BКупить абонимент на следующий месяц��#��[  �� $ 
Horizontal=�.+��� $)��#Выберите абонимент��#��[  �� �� $ 
Horizontal=�.+��� $!��Всего к оплате:��#��[  �� �� $ 
Horizontal=�.+��� #��[ $��Оплатить���� $��2��.+��� $"��Индивидуальные���� $ 
Horizontal=�.+��� $,��&Выберите тип занятия��#��[  �� �� $ 
Horizontal=�.+��� $%��Выберите тренера��#��[  �� �� $ 
Horizontal=�.+��� $��Дата��#��[  (  "System.Windows.Controls.DatePicker  �� $��
Время���� �� $ 
Horizontal=�.+��� $!��Всего к оплате:��#��[  �� �� $ 
Horizontal=�.+��� #��[ $��Оплатить���� $��1��$��5q�.+��� $,��&Информация о клиенте��$��Center=�$	��Top=�$��10q�$��20(��� $ 
Horizontal=�.+��� $��Имя��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��Фамилия��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��Гендер��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��Email��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��Phone��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��
Город��#��[ �� #��[ �� $ 
Horizontal=�.+��� $��
Адрес��#��[ �� #��[ 9� $7��1Дополнительная информация��.���� �� 
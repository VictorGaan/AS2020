   M S B A M L   `   `   `  ����E  AAtomSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AtomSkills
AtomSkills  5          AtomSkills.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:AtomSkills     5      ^ ZSharpVectors.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  6.     N� Title$  
OrdersPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��2��6.   .+�5      �� -   5        $��Filter��5   H   
������ 
������ .��5      (  "SharpVectors.Converters.SvgViewbox     Source$ icon-svg/filter.svg?�6"   6A   5      �� 5      -   5        $��
CmbStatusF��5   A    �� SelectedIndex$ 0��6   $	��200��6)   $��40��65    �� DisplayMemberPath$
 Name��6S   6n   (  "System.Windows.Controls.DatePicker  5      -   5        $��DpStart��5   L   $��Center=�6   $��10q�64   $	��150��6@   6]     5      -   5        $��DpFinish��5   M   $��Center=�6   $��10q�64   $	��150��6@   6_   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��OrdersDataGrid��5   5   $��1��6   ���#800080   AutoGenerateColumns .     
IsReadOnly . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6y   
   AlternatingRowBackground
 �#991199   RowBackground �#800080 � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � �� �#8000806E   �� 5        � ��
 �����6C   �� 5!       � ��$
 Bold"�63   6B   �� 5"       � ��$ 14(�61   6>   5#      5$         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&         
Foreground
 �����,  &System.Windows.Controls.DataGridColumn   Header$ Рег. Дата��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *Date+ �� StringFormat$ 
dd/MM/yyyy��6~     5'      
 �����$ Заказчик��68    6J   �� *
Supplier+6i     5(      
 �����$ Отправление��68    6M   �� *AddressFrom+6o     5)      
 �����$ Назначение��68    6L   �� *	AddressTo+6l     5*      
 �����$ Статус��68    6H   �� *Statuses.Name+6l     5+      
 �����$ Оператор��68    6J   �� *
Operator+6i   4	  .System.Windows.Controls.DataGridTemplateColumn	  5,       	  CellTemplate 5-      �� 5.      .R�5/      �� $��BtnEdit��6o   -   5        
������ 
������ $��50��5/   X   $��50��6d   .��50   "     $ icon-svg\edit.svg?�62   6P   51      52      54      56      � 57   
   -   5        $��grid1��57   ,   $��1��6   $��1��6    58      �� 59      �� 5:       5<      �� 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      .+�5F      �� 
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   	Дата:6�   �� 5G      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��1��6�   Заказчик:6�   �� 5H      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��2��6�   $"Пункт отправления:6�   �� 5I      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��3��6�   " Пункт назначения:6�   �� 5J      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��4��6�   Транспорт:6�   �� 5K      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��5��6�   Оператор:6�   �� 5L      
�������$
��Bold"�6+   $��Right=�6=   $��Center=�6Y   $��0 0 10 0q�6t   $��6��6�   Статус:6�     5M      -   5        $��TbDate��5M   �   $��1��6      normalDatePicker#��[  6)   $��Center=�6S      SelectedDate 6n   �� *Date+6�   �� 5N      -	   5        $��CmbSuppliers��5N   )   $ 0��6   $��1��6=   $��1��6M   $��Center=�6Z   ��5O      �� 5P      .R�5Q      �� ��5R      `� 5S   "   $ {0} {1} {2}��6/   .1�5T   &   ��  �� Path$ LastName�6.   6@   �� 5U   &   $ 	FirstName�6.   6A   �� 5V   &   $ 
MiddleName�6.   6B   5W   #   5Y      5Z      5\      �� 5]      -
   5        $��TbFrom��5]   ^   $��1��6   $��2��6&     normalPlaceHolder#��[ 63   $	��180��6l   ��6x   �� *AddressFrom+6�   �� 5^      -   5        $
��TbTo��5^   ^   $��1��6   $��3��6&   #��[ 63   $	��180��6j   ��6v   �� *	AddressTo+6�   �� 5_      -   5        $��CmbTransports��5_   a   $��1��6   $��4��6'   $��Center=�64   $ 0��6O   $ Number��6v   6�   �� 5`      -   5        $��	CmbStatus��5`   O   $��1��6   $��6��6'   $��Center=�64   $ 0��6`   $
 Name��6r   6�   �� 5a      -   5        $��CmbOperators��5a   )   $ 0��6   $��1��6=   $��5��6M   $��Center=�6Z   ��5b      �� 5c      .R�5d      �� ��5e      `� 5f   "   $ {0} {1} {2}��6/   .1�5g   &   �� $ LastName�6.   6@   �� 5h   &   $ 	FirstName�6.   6A   �� 5i   &   $ 
MiddleName�6.   6B   5j   #   5l      5m      5o      �� 5p      -   5        $��BtnSave��5p   2   $��7��6   $��1��6"     GreenButton#��[ 6W   $	��180��6|   .��6�   Сохранить6�   5q      5r      5s      
   M S B A M L   `   `   `  ����E  AAtomSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AtomSkills
AtomSkills  5   	       AtomSkills.InsertImages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AtomSkills     5   	     � Title$  InsertImages��5   	   $	��250��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�6\    � WindowStyle$
 None=�6r   .��5	      � 
���� �� � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� 
�������$��Right=�6'   $��Center=�6C   $��0 0 10 0q�6^   Транспорт:6|   �� 5   
   
�������$��Right=�6'   $��Center=�6C   $��1��6^   $��0 0 10 0q�6k   Картинка:6�   �� 5   
   -   5        $��CmbTransport��5   P    �� SelectedIndex$ 0��6   $��1��6%   $��Center=�65    �� DisplayMemberPath$ Number��6d   6�   �� 5   
   -   5        $��	BtnUpdate��5   U      AddBlueButton#��[  6   $��1��68   $��1��6H   .��6~   Обновить6�   �� 5   
   -   5        $��BtnSave��5   E   $��2��6   #��[  6   .��6j   Сохранить6u   �� 5   
   -   5        $��	BtnCancel��5   U   $��1��6   $��2��6!   #��[  6.   .��6~   Закрыть6�   5      5      
   M S B A M L   `   `   `  ����E  AAtomSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AtomSkills
AtomSkills  5          AtomSkills.UsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:AtomSkills     5      ^ ZSharpVectors.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  6.     N� Title$  	UsersPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��Filter��5   H   
������ 
������ .��5      (  "SharpVectors.Converters.SvgViewbox     Source$ icon-svg/filter.svg?�6"   6A   5      �� 5      -   5        $��
TbLastName��5   I      placeHolder#��[  6   
 � Tag$ Фамилия��6;   6]   (  "System.Windows.Controls.DatePicker  5      -   5        $��TbDate��5   ^   $��Center=�6     normalDatePicker#��[ 64   6n   �� 5      -   5        $��BtnAdd��5   O     AddBlueButton#��[ 6   $��	100 0 0 0q�6<   .��5      �� $ 
Horizontal=�6   .+�5        $��30��6&   $��0 0 0 0q�62   $ icon-svg/add-button.svg?�6C   6f   �� 5      $��Center=�6    $��14(�6;   $
��Bold"�6I   Добавить6e   5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��UsersDataGrid��5   (   ���#800080   AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6k   $��1��6{      AlternatingRowBackground �#991199	   RowBackground	 �#800080
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5       ��  � �� �#8000806E   �� 5!       � ��
 �����6C   �� 5"       � ��$
 Bold"�63   6B   �� 5#       � ��$ 14(�61   6>   5$      5%         Columns 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Фото��6)      CellTemplate 5(      �� 5)      .R�5*      �� $��50��6$   $��50��60   ��6;   �� *Image+6V   5+      5-        5.      $, &Фамилия Имя Отчество��6)    5/      �� 50      .R�51      �� 
���������52   "   `� 53   &    �� StringFormat$ {0} {1} {2}��63   .1�54   *   ��  �� Path$ LastName�62   6D   �� 55   *   $ 	FirstName�62   6E   �� 56   *   $ 
MiddleName�62   6F   57   '   59      5:      5<      0  *System.Windows.Controls.DataGridTextColumn  5=      $ Дата рождения��6%      
Foreground
 �����1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6O   �� *	BirthDate+$ 
dd/MM/yyyy��6�     5>      $' !Электронная форма��6%   
 ����� 6T   �� *Email+6p     5?       5@      �� 5A      .R�5B      �� $��	BtnDelete��6<   -   5        $��50��5B   %   $��50��61   
������ 
������ .��5C   "     $ icon-svg\delete.svg?�62   6R   5D      5E      5G        5H       5I      �� 5J      .R�5K      �� $��BtnEdit��6o   -   5        
������ 
������ $��50��5K   X   $��50��6d   .��5L   "     $ icon-svg\edit.svg?�62   6P   5M      5N      5P      5R      5S      5T      
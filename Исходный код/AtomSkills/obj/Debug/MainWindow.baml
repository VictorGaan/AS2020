   M S B A M L   `   `   `  ����E  AAtomSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AtomSkills
AtomSkills  5   	       AtomSkills.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AtomSkills     5   	   ^ ZSharpVectors.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  60   -   5          � Title$  
MainWindow��5   	    � WindowStyle$
 None=�6   $	��800��6/   $
��1200��6<    � WindowStartupLocation$ CenterScreen=�6I    � 
ResizeMode$ NoResize=�6n   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   �� $��2��6   $
��Fill=�6!   $��img/flying-taxi.jpg��60   6O   �� 5   
   ���	#FF935087 J� Opacity$	 0.7Q�6%   $��2��63   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   .+�5      (  "SharpVectors.Converters.SvgViewbox     Source$! icon-svg/Logo Dron Taxi.svg?�6   6E   �� 5      
�������$��Center=�6+   $��10q�6F   $��16(�6R   $/��)/AtomSkills;component/fonts/#Roboto Black)�6`   	DRON TAXI6�   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5      �� $��	0 100 0 0q�6   $ Vertical=�6,   .+�5      �� 
�������$��Center=�6/   $��10q�6J   $��16(�6V   $/��)/AtomSkills;component/fonts/#Roboto Black)�6d   АВТОРИЗАЦИЯ6�   �� 5      
�������$��Center=�6/   $��10q�6J   $��12(�6V   $)��#/AtomSkills;component/fonts/#Roboto)�6d   
Логин6�   �� 5      -   5        $��TbLogin��5   S      placeHolder#��[  6   
	 � Tag$	 Введите логин��6?   6d   �� 5      
�������$��Center=�6/   $��10q�6J   $��12(�6V   $)��#/AtomSkills;component/fonts/#Roboto)�6d   Пароль6�   �� 5      -   5        $��
TbPassword��5   T   #��[  6   $!	 Введите пароль��6?   6h   �� 5      $
��0 10q�6   $ 
Horizontal=�6+   .+�5       �� -   5        $��CbSing��5    +   $��10q�6   .��69   Запомнить6D   �� 5!      -   5        $��BtnEnter��5!   W   $��	129 0 0 0q�6     AddBlueButton#��[ 60   .��6~   
Войти6�   5"      �� 5#      -   5        $��BtnReg��5#   >     GreenButton#��[ 6   .��6a   Регистрация6n   5$      5%      5&      5'      
   M S B A M L   `   `   `  ����E  AAtomSkills, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AtomSkills
AtomSkills  5   	       AtomSkills.StartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AtomSkills     5   	   ^ ZSharpVectors.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  60   -   5          � Title$  StartWindow��5   	    � WindowStyle$
 None=�6   $	��800��61   $
��1200��6>    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ NoResize=�6p   .��5	      � ���#800080 � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $
��auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   .+�5      (  "SharpVectors.Converters.SvgViewbox     Source$! icon-svg/Logo Dron Taxi.svg?�6   6E   �� 5      
�������$��Center=�6+   $��10q�6F   $��16(�6R   $/��)/AtomSkills;component/fonts/#Roboto Black)�6`   	DRON TAXI6�   5      � 5   
   $��1��6   $��	0,100,0,0q�6    5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    .+�5       �� -   5        $��Item1��5    ^   
������ $��0 0 0 2q�6.   ���#7FFF7F.��5!      �� $ 
Horizontal=�6   .+�5"        $��
-70 0 20 0q�6'   $ icon-svg/profile.svg?�6;   6[   �� 5#      $��Center=�6    
�������$
��Bold"�6N   Профиль6i   5$      5%      �� 5&      -   5        $��Item2��5&   k   $��1��6   
������ $��0 0 0 2q�6;   ���#7FFF7F.��5'      �� $ 
Horizontal=�6   $��1��66   .+�5(        $��
10 10 20 0q�6'   $ icon-svg/manag-user.svg?�6;   �� 5)      $��Center=�6    
�������$
��Bold"�6N   �� 6a   $*�$Упр. пользователями��6e   6�   5*      5+      �� 5,      -   5        $��Item3��5,   k   $��2��6   
������ $��0 0 0 2q�6;   ���#7FFF7F.��5-      �� $ 
Horizontal=�6   .+�5.        $��-45 10 20 0q�6(   $ icon-svg/manag-role.svg?�6=   6`   �� 5/      $��Center=�6    
�������$
��Bold"�6N   Упр. ролями6m   50      51      �� 52      -   5        $��Item4��52   k   $��3��6   
������ $��0 0 0 2q�6;   ���#7FFF7F.��53      �� $ 
Horizontal=�6   .+�54      �� $��Center=�6    
�������$
��Bold"�6N   Заказы6h   55      56      �� 57      -   5        $��Item5��57   k   $��4��6   
������ $��0 0 0 2q�6;   ���#7FFF7F.��58      �� $ 
Horizontal=�6   .+�59      �� $��Center=�6    
�������$
��Bold"�6N   Транспорт6k   5:      5;      5<      �� 5=   
   -   5        $��BtnExit��5=   s   $��2��6   
������ $��10q�67   $��0 0 0 2q�6C   ���#7FFF7F.��5>      �� $ 
Horizontal=�6   .+�5?        $ icon-svg/exit.svg?�6"   6?   �� 5@      $��20 0 0 0q�6   $��Center=�6.   
�������$
��Bold"�6\   
Выйти6u   5A      5B      �� 5D   
   -   5        $��TbTitle��5D      $��1��6#   $
��Left=�63   $��Center=�6N   $��16(�6i   
�������$
��Bold"�6�   Мой профиль6�    � 5E   
   -	   5        $��	MainFrame��5E   M     � NavigationUIVisibility$ Hidden=�6   $��1��60   $��1��6@   6`   5F      5G      
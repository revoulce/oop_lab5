   M S B A M L   `   `   `  ����H  DEmployeesWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EmployeesWork.UtilityEmployeesWork.Utility  5   	       EmployeesWork.MainWindow   5   	   e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7utility#clr-namespace:EmployeesWork.Utility     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ 	Employees��5	   	   $	��450��6   $	��800��6(    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6Q     5   
   -   5        $
 Save��5      6Q     5   
   -   5        $! utility:CustomCommands.Exit��5      5        5   
   -   5        $( "utility:CustomCommands.AddEmployee��5      5        5   
   -   5        $+ %utility:CustomCommands.RemoveEmployee��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   
�������.@�5      m� $��_File��6   .@�5      m�  m� Command$
 Open��6   m� 5      $
 Save��6   �� 5      m� 5      $! utility:CustomCommands.Exit��6   5       m� 5!      $��_Edit��6   .@�5"      m� $( "utility:CustomCommands.AddEmployee��6   m� 5#      $+ %utility:CustomCommands.RemoveEmployee��6   �� 5$      m� 5%      $
 Copy��6   5&      5'      �� 5(   
   $��1��6   $��5q�6]   $��3q�6h   ��6   �� *	Pattern+ �� UpdateSourceTrigger$ PropertyChanged=�6h   &   System.Windows.Controls.DataGrid  5)   
   -   5        $��2��5)         AutoGenerateColumns$ False��5,      ��5*      �� *	Employees+$ PropertyChanged=� �� SelectedItem 5+      �� *SelectedEmployee+	   Columns	 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+$ PropertyChanged=�  5/      $

 Name��6%    63   �� *Name+$ PropertyChanged=�  50      $
 	Job Title��6%    51   %   �� *
JobTitle+$ PropertyChanged=�  52      $
 Gender��6%    65   �� *Gender+$ PropertyChanged=�  53      $
 Year Of Birth��6%    54   %   �� *YearOfBirth+$ PropertyChanged=�  55      $
 Year Of Employment��6%    56   %   �� *YearOfEmployment+$ PropertyChanged=�   RowDetailsTemplate 58      �� 59      .R�5:      ]� .+�5;      � $��10q�6    � ColumnDefinitions 5<      �� 5=   "   $
��Auto �63   �� 5>   "   $��* �63    5@      �� 5A   "   $
��Auto �60   �� 5B   "   $
��Auto �60   �� 5C   "   $
��Auto �60   �� 5D   "   $
��Auto �60   �� 5E   "   $
��Auto �60   �� 5F   "   $
��Auto �60   .+�5I      �� $
��ID: ��6(   $
��Bold"�64   $��0��6F   $��0��6S   �� 5J      $��0��6<   $��1��6I   ��6(   �� *Id+6I   �� 5L      $��Name: ��6(   $
��Bold"�66   $��1��6H   $��0��6U   �� 5M      $��1��6>   $��1��6N   ��6(   �� *Name+6N   �� 5O      $��Job Title: ��6(   $
��Bold"�6;   $��2��6M   $��0��6Z   �� 5P      $��1��6B   $��2��6R   ��6(   �� *
JobTitle+6R   �� 5R      $��Gender: ��6(   $
��Bold"�68   $��3��6J   $��0��6W   �� 5S      $��1��6@   $��3��6P   ��6(   �� *Gender+6P   �� 5U      $��Year of Birth: ��6(   $
��Bold"�6?   $��4��6Q   $��0��6^   �� 5V      $��4��6E   $��1��6R   ��6(   �� *YearOfBirth+6R   �� 5X      $��Year of Employment: ��6(   $
��Bold"�6D   $��5��6V   $��0��6c   �� 5Y      $��5��6J   $��1��6W   ��6(   �� *YearOfEmployment+6W   5Z      5[      5\      5^      5_      5`      
   M S B A M L   `   `   `  ����A  =wpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpfAppwpfApp  5   	       wpfApp.EmpListWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:wpfApp     5   	   -   5          � Title$  EmpListWindow��5   	   $
��Auto��6   $
��Auto��6-    � SizeToContent$ WidthAndHeight=�6:    � 	Resources 5	         wpfApp.pawelDBDataSet   pawelDBDataSet  employeesViewSource �� Source �� Source��%Z   &	        &	      7     5
   
   6   �� 5   
    6;   �� *	Employees+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��	0,0,0,117q�6j   $	��152��6}   $��Bottom=�6�   ��6R   �� 6�   �� 5   
   -   5         ��Name$ btnExitEmpList��5      $
��EXIT��6)   $
��Left=�68   $	��Top=�6S   $	��120��6k   $��293,206,0,0q�6w   $��29��6�   6�   �� 5   
   -   5        $ btnBackEmpList��5      $
��BACK��6)   $
��Left=�68   $	��Top=�6S   $	��120��6k   $��
45,206,0,0q�6w   $��29��6�   6�   5      5      
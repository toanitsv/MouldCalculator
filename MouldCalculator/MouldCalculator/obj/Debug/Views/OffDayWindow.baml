   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   J FMouldCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MouldCalculator.ViewsMouldCalculator.Views 5
   	   (   "MouldCalculator.Views.OffDayWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /local#clr-namespace:MouldCalculator.Views  5
   	   -   5           OffDayVM  � DataContext#  �   5   	   $��15(�5	   	    � Title$ OffDayWindow��5   	   $	��600��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   $��5q�6+   .��5      �  5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$    � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'   .+�5      (  "System.Windows.Controls.DatePicker  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Select a Date��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6   �� *DisplayDate+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�
	 �� Now
 �� TargetNullValue#
 Z	 6�   �� 5       $��0,10,0,0q�6   $��1��6,    " componentTxtEnterComponentName# �  6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��69   �� *Description+$ PropertyChanged=�$ TwoWay=�6�   �� 5!      $��0,15,0,0q�6   $��2��6K   $��Apply for suppliers��6X   ��6+   �� *AddSupplier+��5"      �� 5#       �� 
TargetType" ��6*   .R�5$      �� $��	Underline{�6(   �� 5%      5&      5'      ��5)      �� 5*       �� 
TargetType" ��6    .�5+      ��  �� Property � �� �� Value
 ��  �6;    �� Triggers 5,      P� 5-   "    P� Property �@J�IsMouseOver P� Value . . �5.   &   ��  � ��
 �  ��6C   5/   #   51      53      �� 54      $��0,10,0,0q�6   $��3��61   $
��Left=�6>   $��Hidden=�6Y   $
��Auto=�6~   .��55      �� -   5         ��Name$ icComponent��55   #   ��68   �� *SupplierList+$ TwoWay=�$ PropertyChanged=���56      �� 57      .R�58   "   �  � Orientation$ 
Horizontal=�6,   59   #   5:      ��5<      �� 5=      .R�5>   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5?   &   �� ��60   �� *SupplierName+�� 5@   &    ��Name$ btnRemoveSupplier��6-   -   5        $��X��5@   H   $��0,0,5,5q�6T   
 � Tag 6e   �� *
SupplierID+5A   -   5B   #   5C      5E      5F      � 5G      $��4��6   $��0,20,0,0q�6)   .+�5H      �� 
���2�2�
���   �
������ ��6   �� *
AddCommand+��5I      � 5J      .+�5K   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Add=�6:   $��24��6E   $��24��6Q   $��0,0,5,0q�6\   �� 5L   "    
 btnAdd#���  6,   $��Center=�6X   5M      5O      �� 5P      
����� �
���   �
������ $��10,0,0,0q�6�   ��6   �� *EditCommand+��5Q      � 5R      .+�5S   "     $
 Edit=�6:   $��24��6F   $��24��6R   $��0,0,5,0q�6]   �� 5T   "     	btnRevise#���  6,   $��Center=�6[   5U      5W      �� 5X      
���  ��
���   �
������ $��10,0,0,0q�6}   ��6   �� *DeleteCommand+��5Y      � 5Z      .+�5[   "     $ Delete=�6:   $��24��6H   $��24��6T   $��0,0,5,0q�6_   �� 5\   "     	btnRemove#���  6,   $��Center=�6[   5]      5_      5`      5a      5b      �� 5c   
   $��1��6   $��0,10,0,0q�6!   $��1,1,1,1q�5d      
�������$��OffDay List��5e        MaterialDesignGroupBox#���  5f      .��5g      � .+�5h      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $��15(�6�      CanUserAddRows .     CanUserResizeRows .  ��6   �� *
OffDayList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5j      �� *SelectedItem+   Columns 5k      0  *System.Windows.Controls.DataGridTextColumn  5l      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6J      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6-   �� *
OffDayID+6V     5m       . $
 Date��6q    6-   �� *Date+  �� StringFormat$  
MM/dd/yyyy��6q     5n       . $ Description��6_    6-   �� *Description+6_   5p      5q      5r      5s      5u      
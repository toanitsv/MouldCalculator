   M S B A M L   `   `   `  ����J  FMouldCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MouldCalculator.ViewsMouldCalculator.Views  5   	   *    $MouldCalculator.Views.SupplierWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MouldCalculator.Views     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��15(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	     supplierWindowTitle � Title# �  5   	   $	��450��5   	   $	��650��6    � WindowStartupLocation$ CenterScreen=�6"   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   #  MaterialDesignThemes.Wpf.Card    MaterialDesignBackground#���  6   .��5      9� -   5         9�Name$ epCreateSupplier��5      $��	30,0,0,10q�61   ��5      �� 5       + 'supplierWindowExpanderCreateNewSupplier#���  6    
����  �$��16(�6   .��5      �  5      �� 5      $
��auto �6(   �� 5       $
��auto �6(   �� 5!      $
��auto �6(   �� 5"      $
��auto �6(    � ColumnDefinitions 5$      �� 5%      $
��auto �6+   �� 5&      .+�5)      �� -   5         ��Name$ txtSupplierID��5)      {�.    supplierWindowTxtSupplierID)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  5*   "    % !MaterialDesignFloatingHintTextBox#��[ 5+   "   �� 5-      -   5        $ txtSupplierName��5-      $��1��67   $��0,10,0,0q�5.   "    ! supplierWindowTxtSupplierName# �  5/   "   #��[ 50   "   �� 52      -   5        $ txtSupplierDescription��52      $��2��6>   $��0,10,0,0q�53   "    (	 $supplierWindowTxtSupplierDescription# � 	 54   "   #��[ 55   "   �� 57      	 �� Orientation$	 
Horizontal=�6!   $��0,10,0,0q�6:   $��3��6L   .+�58      �� -   5        
 ��Name$
 btnAdd��58   !   
���2�2�
���   �
������ ��59      � 5:   "   .+�5;   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentSave=�6>   $��24��6Q   $��24��6]   $��0,0,5,0q�6h   �� 5<   &    
 btnSave#��� 
 60   $��Center=�6]   5=   #   5?      �� 5@      -   5        $
 	btnRemove��5@   !   $��10,0,0,0q�64   {�.  
���  ��
���   �
������ ��5A      � 5B   "   .+�5C   &     $ Delete=�6>   $��24��6L   $��24��6X   �� 5D   &     	btnRemove#���  60   $��Center=�6_   5E   #   5G      5H      5I      5J      5K      �� 5L   
   $��1��6   $��0,20,0,0q�6!   $��1,1,1,1q�5M      
������� # supplierWindowGroupSupplierList#���  5N        MaterialDesignGroupBox#���  5O      .��5P      � .+�5Q      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgSupplier��5Q         AutoGenerateColumns .  $��15(�6K      CanUserAddRows .     CanUserResizeRows .     Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T        supplierWindowGridColID,  &System.Windows.Controls.DataGridColumn   Header# �  6L      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6-   �� *
SupplierID+6�     5U       .   supplierWindowGridColName# �  6`    6-   �� *SupplierName+6`     5V       .  $  supplierWindowGridColDescription# �  6_    6-   �� *Description+6_     5W       .  $  supplierWindowGridColCreatedTime# �  6x    6-   �� *CreatedTime+ �� StringFormat$ 
MM/dd/yyyy��6x   4
  .System.Windows.Controls.DataGridTemplateColumn
  5X       
  CellTemplate 5Y      �� 5Z   "   .R�5[   &   �� $
 
btnEditRow��6-   -	   5          supplierWindowGridCellEdit#���  5[   A   ��5\   *   �� 5]   .    �� 
TargetType" ��6>   .R�5^   2   �� $��	Underline{�6<   �� 5_   :   5`   3   5a   /   ��5c   *   �� 5d   .    �� 
TargetType" ��64   .�5e   2   ��  �� Property � �� �� Value
 ��  �6O    �� Triggers 5f   2   P� 5g   6    P� Property �@J�IsMouseOver P� Value . . �5h   :   ��  � ��
 �  ��6W   5i   7   5k   /   5m   '   5n   #   5p      5r      5s      5t      5u      5v      
   M S B A M L   `   `   `  ����J  FMouldCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MouldCalculator.ViewsMouldCalculator.Views  5   	   +    %MouldCalculator.Views.ComponentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MouldCalculator.Views     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      ComponentVM  � DataContext#  �   5   	    � Title$ 	Component��5
   	   $	��450��6   $	��650��6(   $��15(�64    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � $��1��6    5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5      �  5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   .+�5      �� $��5q�6m    " componentTxtEnterComponentName)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6x    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *DisplayName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   � 5       $��1��6    $��0,10,0,0q�6-   .+�5!      �� 
���2�2�
���   �
������ ��6!   �� *
AddCommand+��5"      � 5#   "   .+�5$   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Add=�6>   $��24��6I   $��24��6U   $��0,0,5,0q�6`   �� 5%   &    
 btnAdd#���  60   $��Center=�6\   5&   #   5(      �� 5)      
����� �
���   �
������ $��10,0,0,0q�6�   ��6!   �� *EditCommand+��5*      � 5+   "   .+�5,   &     $
 Edit=�6>   $��24��6J   $��24��6V   $��0,0,5,0q�6a   �� 5-   &     	btnRevise#���  60   $��Center=�6_   5.   #   50      �� 51      
���  ��
���   �
������ $��10,0,0,0q�6�   ��6!   �� *DeleteCommand+��52      � 53   "   .+�54   &     $ Delete=�6>   $��24��6L   $��24��6X   $��0,0,5,0q�6c   �� 55   &     	btnRemove#���  60   $��Center=�6_   56   #   58      59      5:      5;        5=      $��2��6"   $��Stretch=�6/   $��0,10,0,0q�6K   $��5q�6]   .��5>      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $��15(�5@   7   	   CanUserAddRows	 .  
   CanUserResizeRows
 .  ��5>      �� *ComponentList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5?      �� *SelectedItem+$ TwoWay=�   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C        componentLsvColID,  &System.Windows.Controls.DataGridColumn   Header# �  6M      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *ComponentID+6�     5D         componentLsvColComponentName# �  6O    .  6-   �� *ComponentName+6�   5F      5G      5H      5I      5J      
   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Test.ViewModelTest.ViewModel  5   	   clr-namespace:TestTest  5   	       Test.MainWindow   5   	   #vmclr-namespace:Test.ViewModel  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	     � Title$  
MainWindow��5	   	   $	��720��6   $
��1280��6)    � DataContext 5
      (  "Test.ViewModel.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��0.075* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��0.25* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Dishes��61   $��Center=�6?   $��Center=�6\   $��35(�6w   $��Arial)�6�   �� 5   
   $��0��6   $��1��6!   $��Recipe��61   $��Center=�6?   $��Center=�6\   $��35(�6w   $��Segoe UI)�6�   �� 5   
   -   5         ��Name$ DishesNames��5      $��1��6(   $��0��65   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��Disabled=�5       $��Disabled=�6I   $��Stretch=�6}   ��5   E   �� *
DishesList+ �� Mode$ TwoWay=� �� SelectedItem 6v   �� *SelectedItem+��5!      �� 5"       �� DataType$  viewModels:DishesViewModel��6   .R�5#      �� 
����ح�
����  �$��7,1,1,1q�6G   $	��7.5q�6a   ._�5$      �� $
��Bold"�6:   ��6$   �� *Name+6:   5%      5&      5)      �� 5*   
   $��1��6   $��1��6)   ��66   �� *
DishesList+��5+      �� 5,      .R�5-      �� 
�������$��1q�62   $��10q�6F   ._�5.      �� $��10q�6%   .+�5/      �� $��Название:��6(   �� 50      $��0,0,0,10q�6a   ��6&   �� *Name+	 �� UpdateSourceTrigger$	 PropertyChanged=�6a   �� 52      $��Рецепт:��6(   �� 53      $��0,0,0,10q�6c   ��6&   �� *Recipe+$	 PropertyChanged=�6c   54      55      56      58      5B      5C      
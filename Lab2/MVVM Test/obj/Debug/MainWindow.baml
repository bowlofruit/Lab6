   M S B A M L   `   `   `  ����D  @MVVM Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVM_Test	MVVM_Test  5   	       MVVM_Test.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVM_Test     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       '�� H     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 5q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.8* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5"   
   o� $��2��6   .@�5#      m� $
��File��6   .@�5$      m� $
��Open��6    m� Command 6)   �� *OpenCommand+m� 5%      $
��Save��6    6)   �� *SaveCommand+5&      5'      �� 5(   
   $��1��6   ��6   �� *Tours+ �� SelectedItem 5)      �� *SelectedTour+��5*      �� 5+      .R�5,      �� $��5q�6!   .+�5-      �� $��18(�6$   ��62   �� 	 �� Path$
	 Date��� 5.      ��6$   �� $
	 Cost��� 5/      ��6"   �� $	 
Excursions�50      51      53      �� 54   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   .+�55      �� ��6   �� *
AddCommand+.��64   +67   �� 56      ��6   �� *RemoveCommand+��57      �� *SelectedTour+.��6?   -6B   �� 58      $��52��59   D   ��58      �� *ListElement+��59      �� *SelectedExcursion+.��6O   Change6W   5:      �� 5<   
   $��1��6   $��1��6"    � DataContext 62   �� *SelectedTour+.+�5=      �� $
��Date��6   �� 5>      ��6   �� *Date+ �� UpdateSourceTrigger$ PropertyChanged=��� 5?      $
��Cost��6   �� 5@      ��6   �� *Cost+$ PropertyChanged=��� 5A      $��	Tour list��6   �� 5B      ��6   �� $	 
Excursions� 6>   �� $	 ListElement�5C      5D      5E      
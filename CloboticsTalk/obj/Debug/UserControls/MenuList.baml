   M S B A M L   `   `   `  ����  CloboticsTalk)    #CloboticsTalk.UserControls.MenuList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5	         ChatListBox �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect  DropShadowInd   
BlurRadius   ShadowDepth   	Direction   Color  IndicatorStyle �� RelativeSource	 �� Mode
 �� AncestorType �� Triggers �� Binding �� Value  	PathStyle �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels �� Triggers��%	  &	        &	     &	 b    7  &	     '�� �    7  7  �� 5
   
   " ��6$   .�5      ��  � ��$ 0q�60   �� 5       � ��
 ���� 6+   �� 5       � ��$ Stretch=�62   �� 5       � ��$ Stretch=�64   �� 5       �@��SelectionMode$ Single=�6.   �� 5       � |� .  6*   5        5   
   $ 10Q�61   $ 3Q�6A   $	 360Q�6Q   $ #f54a4a��6a   �� 5   
   " ��6'   .�5      ��  � �� �#f54a4a6+   �� 5       � y�$ Hidden=�6+   �� 5       � �� 6'   �� *Height+ �� $	 FindAncestor=�$
 BorderL��� 5       � ��$ 4��6&   �� 5       � |� .  6*   �� 5       � ��$
 Left=�64   �� 5       �@J�Effect8   6'    5"      �� 5#       6   �� *IsMouseOver+ �� $	 FindAncestor=�$
 ListBoxItemL� True6�   .a�5$      ��  � y�$ Visible=�63   5%      �� 5&       6   �� *
IsSelected+ �� $	 FindAncestor=�$
 ListBoxItemL� True6�   .a�5'      ��  � y�$ Visible=�63   5(      5*      �� 5.   
   " F�6"   .�5/      ��  � �� �#686D836%   �� 50       � ��$ 26��6&   �� 51       �@��Stretch$ Uniform=�6(   �� 52       � ��$ Stretch=�64    53      �� 54       6   �� *IsMouseOver+ �� $	 FindAncestor=�"
 �� True6�   .a�55      ��  � ��
 �����6-   56      �� 57       6   �� *
IsSelected+ �� $	 FindAncestor=�"
 �� True6�   .a�58      ��  � ��
 �����6-   59      5;      �� 5?   
   " ��6   .�5@      ��  � ��$ 74��6'   �� 5A       �@�Cursor$
 Hand��6'   66   �� 5C       �@��
IsSelected 6+   �� *IsItemSelected+�� 5E       � ��
 ���� 6+   �� 5F       � ��$ 0q�60   �� 5G       � �� 5H      �� 5I      " ��6&   .R�5J      �� $ border��6!   #��z��61   # z��6[   #��z��6   #��z��6�    . ._�5L      � $��-4,0,0,0q�6#   .+�5O   "   �� 8��  6)   F� 5S   "   8�� ��6'   �� *
PathData+6A   5U      5V       5W      �� 5X      $	 130��6M    6*   �� *ListItemHeight+.a�5Y   "   ��  � ��$	 130��6;   �� 5Z   "    � {� .  6>   5[      5]      5_      5`      5b      .��5e      �� $��Hidden=�6   #��[  6@   ��6e   �� *
ItemList+5f      
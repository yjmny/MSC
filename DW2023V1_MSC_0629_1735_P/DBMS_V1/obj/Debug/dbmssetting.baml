   M S B A M L   `   `   `  ����B  >DBMS_V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DBMS_V1DBMS_V1  5      b ^C1.WPF.FlexGrid.4.6.2, Version=4.6.20222.770, Culture=neutral, PublicKeyToken=2aa4ec5576d6c3ceP<clr-namespace:C1.WPF.FlexGrid;assembly=C1.WPF.FlexGrid.4.6.2C1.WPF.FlexGrid 5          DBMS_V1.dbmssetting   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:DBMS_V1     5      Y UC1.WPF.4.6.2, Version=4.6.20222.770, Culture=neutral, PublicKeyToken=2aa4ec5576d6c3ce:c1/http://schemas.componentone.com/winfx/2006/xaml   5      O
c1FlexGrid<clr-namespace:C1.WPF.FlexGrid;assembly=C1.WPF.FlexGrid.4.6.2   5        N� Title$  dbmssetting��5
       � 	Resources 5         _RowBackground �� Color  _AlternatingRowBackground  _HeaderGridLinesBrush  MouseOverColor  _GridLinesBrush  MouseOverBrush  _FrozenLinesBrush  _GroupRowBackground  _CursorBackground 	 _SelectionBackground 
 MarqueeColor  	_gradFrom  _gradTo  _RowHeaderBackground �� EndPoint � Color � Offset  _ColumnHeaderBackground  _TopLeftCellBackground  _BottomRightCellBackground  C1FlexGridStyle1 �� 
TargetType   C1.WPF.FlexGrid.C1FlexGrid �� Property �� Value	 �� 
TargetType
 �Name � ColumnDefinitions � RowDefinitions ��Name �� Orientation��%�	  &	        &	      &	 >     &	 _     &	 �     &	 �     7  &	 �     &	 �     &	     &		 $    &	
 G    &	 f    &	 �    &	 �    7  7  &	     7  7  &	 |    7  7  &	 �    7  7  &	 N    7   7  7  7  7  7  7  7 	 7  7  7  7  7 
 7  �� 5   
   $ White��61   �� 5   
   $ White��6<   �� 5   
   $ #323a47��68   ��5   
   	#FFBFE1EA��62   �� 5   
   $ 	#FFF0F0F0��62   �� 5   
   8   61   �� 5   
   $ 	#E0000000��64   �� 5   
   $ 	#E0E4E4E4��66   �� 5   
   $ 	#FFBADDE9��64   �� 5   
   $ 	#A0BADDE9��67   �� 5   
   $ Black��6/   ��5   
   	#F0FAFAFA��6-   ��5   
   	#F0DBDBDB��6+   �� 5   
   $ 1.5,0&�6;   .��5      � 8   $ 0Q�6>   � 5      8  $ 1Q�6<   5      �� 5   
   $	 0,1&�6>   .��5      � 8   $ 0Q�6>   � 5       8  $ 1Q�6<   5!      �� 5"   
   $	 1,1&�6=   .��5#      � 8   $ 0Q�6>   � 5$      8  $ 1Q�6<   5%      �� 5&   
   $	 1,1&�6A   .��5'      � 8   $ 0Q�6<   � 5(      8  $ 1Q�6>   5)      �� 5*   
   "  6)   .�5+      ��  � ��
 �����6+   �� 5,       �@ RowBackground8   6.   �� 5-        �@ AlternatingRowBackground8  69   �� 5.       �@ HeaderGridLinesBrush8  65   �� 5/       �@ GridLinesBrush8  6/   �� 50       �@ FrozenLinesBrush8  61   �� 51       �@ GroupRowBackground8  63   �� 52       �@ CursorBackground8  61   �� 53       �@ SelectionBackground8  64   �� 54       �@ RowHeaderBackground8  64   �� 55       �@ ColumnHeaderBackground8 	 67   �� 56       �@ TopLeftCellBackground8 
 66   �� 57      ! �@ BottomRightCellBackground8  6:   �� 58       �@ MarqueeColor8  6-   �� 59       �@ MouseOverBrush8  6/   �� 5:       � �� 5;      �� 5<      "	  6&   .R�5=      �� #��z��6!   #��z��6K   #��z��6w   ._�5>      � $
 _root��6#    5?   "   �� 5@   &   $
��Auto �67   �� 5A   &   $��* �67   �� 5B   &   $
��Auto �67    5D   "   �� 5E   &   $
��Auto �64   �� 5F   &   $��* �64   �� 5G   &   $
��Auto �64   �� 5H   &   $
��Auto �64   .+�5J   "   �� $
 _sbV��6,   $��2��6:   $ Vertical=�6J   $��3��6a   �� 5K   "   $
 _sbH��6,   $��2��6:   $ 
Horizontal=�6N   $��3��6g   5L      5M      5N      5P      5Q      5R      .��5T      � .+�5U   
   �� $	��850��6   $	��815��6"   $��824,46,01,0q�6.   
�������.+�5V      �� $��0,0,0,0q�6   $��로그��6%   $��	Noto Sans)�62   �� 5W      -   5         ��Name$ LogList��5W      
�������$��14(�6>   $��	Noto Sans)�6L   $	��810��6c   $
��Auto=�6p   $	��820��6�   5X      �� 5Z   
   $	��420��6   $	��815��6"   $��0,46,820,434q�6.   
�������.+�5[      �� $ ��DBMS 설정(내부) 설정��6   $��	Noto Sans)�6-   $��0,0,0,0q�6D     5\      -   5          Name$ inDbmsSetting��5\   O   #���  6$   $��14(�6f   $	��820��6t      HeadersVisibility$ Column=�6�      AutoGenerateColumns .     ColumnHeaderBackground �#323a47   ColumnHeaderForeground �#ffffff   AllowDragging$
 None=�6�      AllowResizing$
 None=�6  $��	Noto Sans)�6#     Columns 5]        C1.WPF.FlexGrid.Column  5^         Width$	 10* �6?     C1.WPF.FlexGrid.RowCol   HorizontalAlignment�  �C1.WPF.FlexGrid.NullableObjectConverter`1[[System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$ center 6K       HeaderHorizontalAlignment$ center 6h      
IsReadOnly .    Binding 6(   �� *no+6�     5_      $	 35* �6A   $ center 6M   $ center 6j    .  6(   �� *name+6�     5`      $	 20* �6A   $ center 6M   $ center 6j    .  6(   �� *type+6�     5a      $	 30* �6?   $ center 6K   $ center 6h    .  6(   �� *ip+6�     5b      $	 25* �6B   $ center 6N   $ center 6k    6(   �� *event+   CellTemplate 5c      �� 5d      .R�5f   "   �� -   5        $��연결상태확인��5f   )   ���#FFC359$	��139��6O   6[   5h      5j        5k      $	 25* �6)   $ center 65   $ center 6R    5l      �� 5m      .R�5o   "   �� -   5        $��포트상태확인��5o   )   ���#FFC359$	��139��6P   6\   5q      5s      5u      5v      �� 5w   
   $��DBMS 관리��6   $
��Left=�6"   $��0,0,0,0q�6=   $	��Top=�6N   $��50��6f   $	��190��6r   $��18(�6~   $
��Bold"�6�   $��	Noto Sans)�6�   ���	#FF6565656�   �� 5y   
   $	��420��6   $	��815��6"   $��0,475,822,0q�6.   
�������.+�5z      �� $��DBMS 설정(외부)��6   $��	Noto Sans)�6*   $��0,0,0,0q�6A     5{      -   5        $ outDbmsSetting��5{   $   #���  6<   $��14(�6h   $	��820��6v   $ Column=�6�    .   �#323a47 �#ffffff$
 None=�6�   $
 None=�6  $��	Noto Sans)�6&   5|        5}      $	 15* �6?   $ center 6K   $ center 6h    .  6(   �� *no+6�     5~      $	 25* �6A   $ center 6M   $ center 6j    .  6(   �� *name+6�     5      $	 25* �6A   $ center 6M   $ center 6j    .  6(   �� *type+6�     5�      $	 30* �6?   $ center 6K   $ center 6h    .  6(   �� *ip+6�     5�      $	 25* �6B   $ center 6N   $ center 6k    6(   �� *event+ 5�      �� 5�      .R�5�   "   �� $��연결상태확인��6)   ���#FFC359$	��139��6O   5�      5�        5�      $	 25* �6)   $ center 65   $ center 6R    5�      �� 5�      .R�5�   "   �� $��포트상태확인��6)   ���#FFC359$	��139��6O   5�      5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ���� D  @DWDBMS_V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DWDBMS_V1	DWDBMS_V1      DWDBMS_V1.dbmssetting   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:DWDBMS_V1     b ^C1.WPF.FlexGrid.4.6.2, Version=4.6.20222.770, Culture=neutral, PublicKeyToken=2aa4ec5576d6c3ceY UC1.WPF.4.6.2, Version=4.6.20222.770, Culture=neutral, PublicKeyToken=2aa4ec5576d6c3ce:c1/http://schemas.componentone.com/winfx/2006/xaml     N� Title$  dbmssetting��.��� .+�   C1.WPF.FlexGrid.C1FlexGrid  -     Name$ inDbmsSetting��$
��Left=�$��
20,150,0,0q�$	��800��$	��Top=�   HeadersVisibility$ Column=�   AutoGenerateColumns .     ColumnHeaderBackground
 �   �   ColumnHeaderForeground
 �����   AllowDragging$
 None=�   AllowResizing$
 None=�   Columns   C1.WPF.FlexGrid.Column  	   Width$		 10* �  C1.WPF.FlexGrid.RowCol
   HorizontalAlignment�  �C1.WPF.FlexGrid.NullableObjectConverter`1[[System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$
 center     HeaderHorizontalAlignment$ center    
IsReadOnly .    Binding �� *no+  $		 40* �$
 center $ center  .  �� *name+  $		 20* �$
 center $ center  .  �� *type+  $		 25* �$
 center $ center  .  �� *ip+  $		 20* �$
 center $ center  �� *event+   CellTemplate �� .R��� $��연결하기��$	��100��  $		 25* �$
 center $ center  �� .R��� $��연결해제��$	��100��  -   $ outDbmsSetting��$
��Left=�$��
20,574,0,0q�$	��800��$	��Top=�$ Column=� .  
 �   �
 �����$
 None=�$
 None=�   $		 15* �$
 center $ center  .  �� *no+  $		 25* �$
 center $ center  .  �� *name+  $		 25* �$
 center $ center  .  �� *type+  $		 25* �$
 center $ center  .  �� *ip+  $		 25* �$
 center $ center  �� *event+ �� .R��� -   $��연결하기��$	��100��  $		 25* �$
 center $ center  �� .R��� -   $��연결해제��$	��100���� $��DBMS연동관리��$
��Left=�$��	10,31,0,0q�$	��Top=�$��40��$	��190��$��25(�$
��Bold"��� $��DBMS 설정(내부)��$��10,89,760,500q�$��20(��� $��DBMS 설정(외부)��$��20,500,760,40q�$��20(��� $��로그��$��880,74,26,46q�$��20(��� -    ��Name$ LogList��$��920,124,52,68q�
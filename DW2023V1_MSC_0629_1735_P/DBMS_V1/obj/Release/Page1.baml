   M S B A M L   `   `   `  ���� D  @DWDBMS_V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DWDBMS_V1	DWDBMS_V1      DWDBMS_V1.Page1   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:DWDBMS_V1       N� Title$  Page1��.���  � RowDefinitions �� $	��20* ��� $	��60* ��� $	��20* �.+�� $��0�� � ColumnDefinitions �� �� .+��� -    ��Name$ btnConnection��$��0��$��Right=�$��연결테스트 확인��$��80��$��	0,70,50,0q�$	��Top=�$	��200�� � 	Resources  �� 
TargetType �� Property �� Value��%�   '��       '�� 0     �� " ��.���  �@��CornerRadius$ 10���� " ��.���  � ��
 �������  � ��$ 20(���  � ��
 �/kU��� -   $ btnDisconnection��$��1��$
��Left=�$��연결OFF테스트 확인��$��80��$��	50,70,0,0q�$	��Top=�$	��200�� ��%�   '��       '�� 0     �� " ��.���  �@��CornerRadius$ 10���� " ��.���  � ��
 �������  � ��$ 20(���  � ��
 �/kU�� $��1�� �� $	��80* ��� $	��20* �.+�� $��0�� �� �� .+��� $��0��$��0��
���   �$��1q�$��0,0,1,1q�._��� -    ��Name$ tbSql1��$��Stretch=�$��Stretch=�	 �� TextWrapping$
	 Wrap=�$��Sql edit���� $��0��$��1��
���   �$��1q�
�������$��0,0,4,1q�._��� -   
 ��Name$
 tbSql2��$��Stretch=�$��Stretch=�$
��Wrap=�$��
Sql Result���� -   $ 	btnRunSql��$��1��$��SQL 실행(RUD)��$��Center=�$��70��$��Center=�$	��200�� ��%�   '��       '�� 0     �� " ��.���  �@��CornerRadius$ 10���� " ��.���  � ��
 �������  � ��$ 20(���  � ��
 �/kU��� $��2��$	��400��$	��100��.@��� -    ��Name$ 
lblStatus1��$��Center=�$��Center=�$��Center=�$��Label��$��20(�$��Center=�
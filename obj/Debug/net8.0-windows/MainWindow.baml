   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��
bestSignal��5
      $
��Left=�6$   $��20��6?   $��	20,40,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��335��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��wifiGrid��5   r   $
��Left=�6   $	��300��6.   $��	20,90,0,0q�6;   $	��Top=�6N   $	��760��6f      AutoGenerateColumns$ False��6�   ��6�   �� *WifiNetwork+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя сети��6%   -   5        
nameWN��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 5   e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *
wifiName+6e     5      $, &Уровень сигнала сети��6%   -   5        signalWN��$	 360 5   t    6U   �� *
wifiSignal+6t   5      �� 5   
   -   5        $��
scanButton��5   '   $��Сканировать��6   $
��Left=�6S   $��20��6n   $��
490,40,0,0q�6z   $	��Top=�6�   $	��137��6�   �� 5   
   -   5        $��
saveButton��5   %   $��Сохранить��6   $
��Left=�6V   $��20��6q   $��
643,40,0,0q�6}   $	��Top=�6�   $	��137��6�   ��67   �� *
AddCommand+6�   5      5      
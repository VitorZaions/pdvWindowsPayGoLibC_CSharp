   M S B A M L   `   `   `  ����?  ;PDVS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PDVSPDVS  5   	       PDVS.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:PDVS     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$
 PDVS��5	   	   $��441.684��6   $��950.063��6'    � ShowActivated$ False��67   .��5
      � $
��Left=�6   $	��401��6&   $	��347��62   $	��Top=�6?    � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��114* �6   �� 5      $
��222* �6   .+�5   
   �� -   5         ��Name$ 
btnExecute��5      $��Executar��6%   $��166,45,-14,0q�68   $��20��6g   $	��Top=�6s   $��2��6�   �� 5   
   -   5         ��Name$ cmbOper��5      $��70,12,-14,0q�6$   $	��Top=�69    �� 
IsReadOnly$
 True��6Q   $��1��6c   $��2��6s   $��22��6�    �� SelectedIndex$ 0��6�   �� 5   
   -   5         ��Name$ LblOper��5      $��PWINFO__OPERATION:��6!   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   $	��125��6�   $��2��6�   $��26��6�   �� 5   
   -   5        	 ��Name$	 lstParameters��5      $��10,72,-14,-12q�6)   $��3��6r   �� 5   
   -   5        $ LblParameters��5      $��PARÂMETROS:��6'   $
��Left=�6=   $��	10,41,0,0q�6X   $	��Top=�6k   $��2��6�   $��26��6�   $��87��6�   �� 5   
   -   5        $ btnClear��5      $��Limpar��6#   $
��Left=�64   $��	86,45,0,0q�6O   $��70��6b   $��20��6�   $	��Top=�6�   $��2��6�   �� 5   
   -   5        $ btnAddParam��5      $��	Adicionar��6&   $��	40,45,4,0q�6:   $	��Top=�6M   $��1��6   $��20��6�   $��70��6�   �� 5   
   -   5        $ 	btnRemove��5      $��Remover��6$   $��
6,45,146,0q�66   $	��Top=�6J   $��2��6{   $��20��6�   $��70��6�   �� 5   
   -	   5        $ btnCaptureWithPinpad��5      $
��Left=�6/   $��10,364,0,-48q�6J   $	��Top=�6`   $��75��6x   $��31��6�   $��9(�6�   $��2��6�   $"��Capturar dado
usando PINpad��6�   �� 5   
   -
   5        $	 listBox��5      $��0,41,-515,-48q�6#   $��Right=�6:   $	��472��6V   $��2��6b   $	��354��6r   $	��Top=�6   $��Courier New)�6�   �� 5   
   $��LOG de Eventos da DLL��6   $��0,0,-189,311q�60   $��2��6F   $��Bottom=�6V   $��Right=�6q   
 J� RenderTransformOrigin$
 -0.737,1.423&�6�   $	��146��6�   $��26��6�   �� 5   
   -   5        $ btnMsgPinpad��5      $$��Exibir mensagem
usando PINPad��6'   $��1��6X   $
��Left=�6h   $��29,364,0,-48q�6�   $	��Top=�6�   $��72��6�   $��31��6�   $��9(�6�   6�   �� 5   
   -   5        $ btnGetOperations��5      $%��Obter operações
disponíveis��6+   $��2��6Z   $
��Left=�6j   $��31��6�   $��164,364,-14,-48q�6�   $	��Top=�6�   $��72��6�   $��9(�6�   6�   �� 5   
   -   5        $ btnWaitEvent��5      $$��Aguardar evento
usando PINpad��6'   $��1��6X   $
��Left=�6h   $��31��6�   $��113,364,0,-48q�6�   $	��Top=�6�   $��72��6�   $��9(�6�   $��2��6�   6�   �� 5   
   -   5        $ btnGetPINBlock��5      $ ��Obter senha
usando PINpad��6)   $��2��6V   $
��Left=�6f   $��31��6�   $��81,364,0,-48q�6�   $	��Top=�6�   $��72��6�   $��9(�6�   6�   5      5       
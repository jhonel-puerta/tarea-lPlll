   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	       Presentacion.editar   5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	   -   5           MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5	       � Title$ loging��5   	   $	��450��6   $	��400��6%   
������  � WindowStyle$
 None=�6J    � AllowsTransparency . .��5      �� 
������� �� CornerRadius$ 15��6    ._�5   
   �  � RowDefinitions 5      �� 5      $	��150 �6    6/   �� 5      6"   .+�5      �� -   5        $��0��5      
�������$ 	15,15,0,0��65   ._�5      � .+�5      �� $��Editar��6   $��110,10,122,68q�6-   ���#85C1E9$��60(�6Y   �� 5      -   5         ��Name$ header_name��5      $��alumno��62   $��136,82,147,20q�6C   $��30(�6Z   ���#AED6F16h   �� 5      $
��Left=�6   $��34��67   $��	358,6,0,0q�6C   $	��Top=�6V   $��37��6n   $��boton-x.png��6y    � Cursor$
 Hand��6�   �� 5      -   5        	 ��Name$	 	btnCerrar��5      $
 Hand��60   $�� ��6>   $
��Left=�6I   $��34��6d   $��	355,6,0,0q�6p   $	��Top=�6�   $��37��6�   
������ ��6�   Z� 5      5      �� 5       $��1��6   ._�5!      � .+�5"      �� -   5        
 ��Name$
 primerN��5"      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Primer Nombre��5#       % !MaterialDesignFloatingHintTextBox#��[ 5$      $��Center=�5%      $��10,10,213,254q�6   �� 5&      -   5        $
 segundoN��5&      $ Segundo Nombre��5'      #��[ 5(      $��Center=�5)      $��10,51,213,214q�64   �� 5*      -   5        $
 primerA��5*      $ Primer Apellido��5+      #��[ 5,      $��Center=�5-      $��10,91,213,174q�64   �� 5.      -   5        $
 segundoA��5.      $ Segundo Apellido��5/      #��[ 50      $��Center=�51      $��10,131,213,133q�64   �� 52      -	   5        $
 telefono��52      $ Telefono��53      #��[ 54      $��Center=�55      $��10,172,213,93q�64   �� 56      -
   5        $
 celular��56      $ Celular��57      #��[ 58      $��Center=�59      $��218,11,10,254q�64    �� 
CaretBrush �	#FF8AB73A6K   �� 5:      -   5        $
 	direccion��5:      $ 	Direccion��5;      #��[ 5<      $��Center=�5=      $��218,132,10,133q�64   �� 5>      -   5        $
 email��5>      $ email��5?      #��[ 5@      $��Center=�5A      $��218,51,10,214q�64   �� 5B      -   5        $��
Actualizar��5B      $��20(�62   $
��Left=�6@   $��133,235,0,0q�6[   $	��Top=�6p   $	��126��6�   $��39��6�   ���	#FF3498DB��6�   Z� 6�   �� 5C      -   5        $
 fecha_n��5C      $ fecha de nacimineto��5D      #��[ 5E      $��Center=�5F      $��218,91,10,174q�64   �� 5G      -   5        $
 observaciones��5G      $ observaciones��5H      #��[ 5I      $��Center=�5J      $��218,172,10,93q�64   5K      5L      5M      5N      5O      
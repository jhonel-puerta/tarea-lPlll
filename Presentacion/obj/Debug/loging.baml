   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	       Presentacion.loging   5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5	       � Title$ loging��5   	   $	��450��6   $	��400��6%   
������  � WindowStyle$
 None=�6J    � AllowsTransparency . .��5      �� 
������� �� CornerRadius$	 20 ��6    ._�5   
   �  � RowDefinitions 5      �� 5      $��80 �6    6.   �� 5      6"   .+�5      �� -   5        $��0��5      ���	#FF2C3E50$ 	20,20,0,0��69   ._�5      � .+�5      �� $��Iniciar��6   $��145,16,140,10q�6.   
�������$��40(�6X   �� 5      $
��Left=�6   $��34��67   $��	358,6,0,0q�6C   $	��Top=�6V   $��37��6n   $��boton-x.png��6y    � Cursor$
 Hand��6�   �� 5      -   5        $
 Hand��5      $�� ��6+   $
��Left=�66   $��34��6Q   $��	355,6,0,0q�6]   $	��Top=�6p   $��37��6�   
������ ��6�   Z� 6�   5      5      �� 5      $��1��6   ._�5       � $��0,0,10,0q�6   .+�5!      �� -   5         ��Name$ txtName��5!      $	��200��5"      $��66��5#      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Nombre��5$      $��25(�5%       % !MaterialDesignFloatingHintTextBox#��[ 5&      $��Center=�5'      $��98,59,92,245q�6   
 �� 
CaretBrush
 �	#FF2C3E50���	#FF2C3E50 �� SelectionBrush
 �2�2����	#FF2C3E506}   G� 5(      -   5         G�Name$ FloatingPasswordBox��5,      $	��200��5)      $��65��5*      $��25(�5+      $	 Contraseña��5-         
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � � ) %MaterialDesignFloatingHintPasswordBox#��[ 50      $��98,162,92,143q�6B    G� 
CaretBrush �	#FF2C3E50���	#FF2C3E50 G� SelectionBrush �	#FF7D2ACF���	#FF2C3E506�   �� 51      -   5        
���2�2�$��Ingresar��51   4   $
��Auto��6G   $��20(�6U   $��132,275,125,51q�6c   ��6{   Z� 6�   52      53      54      55      56      
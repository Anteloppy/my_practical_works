   M S B A M L   `   `   `  ����B  >Text_it, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Text_itText_it  5   	       Text_it.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Text_it     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ ApplicationCommands.Open��5
      6<     5   
   -   5        $ ApplicationCommands.Save��5      6<   .��5      � .+�5   
   �� .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� -   5        $
��Save��5      6)   m� 5      -   5        $
��Open��5      6)   5      m� 5      $
��Edit��6   .@�5      m� $
��Bold��6    m� Command$  EditingCommands.ToggleBold��6)   m� 5      $��Italic��6   $" EditingCommands.ToggleItalic��6+   m� 5      $��	Underline��6   $% EditingCommands.ToggleUnderline��6/   5      5      �� 5   
   .+�5      c� $	��Top=�6   .@�5      �� $��ApplicationCommands.Open��6   $��0q�6@    � ToolTip$
 Open��6T   .��5      �� $��/folder.png��6    $��21��65   $��21��6@   5      �� 5      $��ApplicationCommands.Save��6   $��0q�6@   $
 Save��6T   .��5       �� $��/floppy.png��6    $��20��65   $��20��6@   5!      �� 5"      d� 5#      -   5         d�Name$ bBold��5#   Z   {�. $ ��EditingCommands.ToggleBold��65   $��0q�6i   $
 Bold��6}   .��5$      �� $��	/bold.png��6    $��16��63   $��16��6>   5%      d� 5&      -   5        $ bItalic��5&   \   {�. $"��EditingCommands.ToggleItalic��65   
������ $ italic��6�   .��5'      �� $��/italic.png��6    $��16��65   $��16��6@   5(      d� 5)      -   5        $ 
bUnderline��5)   ^   {�. $%��EditingCommands.ToggleUnderline��64   
������ $ 	Underline��6�   .��5*      �� $��/underline.png��6    $��16��68   $��16��6C   5+      �� 5,      �� 5-      -   5        $��cmbFontFamily��5-      $	��150��64   6@   �� 5.      -	   5        $��cmbFontSize��5.      $��50��62    �� 
IsEditable . 6O   �� 5/      �� 50      -
   5         ��Name$ bLineSpacing��50      $��20��6H   $��20��6S   $ LineSpacing+��6_   .��51      �� $��/line_spacing.png��6    52      �� 53      -   5        $ bDoesntLineSpacing��53      $��20��6U   $��20��6`   $ LineSpacing-��6l   .��54      �� $��/line_doesnt_spacing.png��6    55      �� 56      �� 57      -   5        $ Black��57      $��15��6,   $��15��68   
���   �$ Black��6V   6f   �� 58      -   5        $	 Red��58      $��15��6*   $��15��66   
���  ��$	 Red��6R   6`   �� 59      -   5        $ Green��59      $��15��6,   $��15��68   
��� �|�$ Green��6Z   6j   �� 5:      -   5        $
 Blue��5:      $��15��6+   $��15��67   
����  �$
 Blue��6T   6c   5;      �� 5<      -   5         ��Name$	 rtb��5<      . �5=      /� -   5        	 /�Name$		 par��5=      
 /� 
LineHeight$
 1��6(   .T�5>      J� .*�6   <:Здесь могла быть ваша реклама :р5@      5A      5B      5C      5D      5E      5F      
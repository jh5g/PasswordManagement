   M S B A M L   `   `   `  ����D  @Passwords, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Passwords	Passwords  5   	       Passwords.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Passwords     5   	   -   5          �Name$  	Generator��5   	    � Title$* $Hougie's Password Manager: Generator��5   	   $	��450��66   $	��800��6C   .��5	      �  J� RenderTransformOrigin$ 0.358,0.499&�6   .+�5
   
   �� -   5         ��Name$ GenerateButton��5
      $��Gernate!��6)   $
��Left=�6<   $��426.75,199.934,0,0q�6W   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5         ��Name$ CapCheck��5      $��Capitals��6%   $
��Left=�68   $��517.814,206.305,0,0q�6S   $	��Top=�6p   $��24.571��6�    d� 	IsChecked$
 TrueY�6�   $��2��6�   �� 5   
   -   5        $ 	PuncCheck��5      $��Punctuation��6&   $
��Left=�6<   $��517.814,181.732,0,0q�6W   $	��Top=�6t   $
 TrueY�6�   $��18.549��6�   $��2��6�   �� 5   
   -   5        $ NumCheck��5      $��Numbers��6%   $
��Left=�67   $��517.814,230.875,0,0q�6R   $	��Top=�6o   $
 TrueY�6�   $��18.549��6�   $��2��6�   �� 5   
   -   5         ��Name$ LenghtSlide��5      $
��Left=�6&   $��151.859,162.811,0,0q�6A   $	��Top=�6^   $��349.891��6v    � Maximum$ 25Q�6�    � Minimum$ 5Q�6�   	 �� IsSnapToTickEnabled	 . 
 � Value$
 10Q�6�   �� 5   
   -   5         ��Name$ LengthSlideLabeller��5      $
��Left=�6/   $��23��6J   $��151.859,123.767,0,0q�6V    �� TextWrapping$
 Wrap=�6s   $��Length is 10��6�   $	��Top=�6�   $	��120��6�   {�.  6�   �� 5   
   -   5        $ PasswordField��5      $
��Left=�6)   $��19.96��6D   $��151.859,199.934,0,0q�6S   $
 Wrap=�6p   $	��Top=�6�   $	��251��6�    �� 
IsReadOnly . 6�   �� 5   
   -	   5         ��Name$ PasswordRating��5      ���	#FFF4F4F5$
��Left=�6=   $��19.96��6X   $��85.047,199.934,0,0q�6g   
���   �$	��Top=�6�   $��58.921��6�   �� 5   
   -
   5         ��Name$ ScoreBox��5      $
��Left=�6&   $��85.047,201.934,0,0q�6A   $
��Wrap=�6]   $	��Top=�6q   $��58.921��6�   5      5      
   M S B A M L   `   `   `  ����M  IPendu_Projet_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pendu_Projet_FinalPendu_Projet_Final  5   	   #    Pendu_Projet_Final.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pendu_Projet_Final     5   	     � Title$  
MainWindow��5   	   $	��642��6   $	��922��6)    � 	Resources 5
         RoundedButtonWithHover �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value N� EnterActions g� Duration	 �� To �� TargetProperty N� ExitActions��%�  &	        �� 5   
   " ��6/   .�5      ��  � ��
 �����6+   �� 5       � ��
 �   �6+   �� 5       � �� �	#FF65A7FF6,   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 5��61   #��z��6B   #��z��6l   #��z��6�   ._�5      �� $��Center=�6/   $��Center=�6L   #��z��6g   5      5      5       5      P� 5      	 �@J�IsMouseOver
 .  5      �� 5      .��5      �� .��5   "   �� $ 0:0:0.3D�61   $ 	#FF65A7FFX�6D   $ Background.Color�6S   �� 5    "   $ 0:0:0.3D�61   $ WhiteX�6D   $ Foreground.Color�6O   5!      5"       5$      �� 5%      .��5&      �� .��5'   "   �� $ 0:0:0.3D�61   $ WhiteX�6D   $ Background.Color�6O   �� 5(   "   $ 0:0:0.3D�61   $ 	#FF65A7FFX�6D   $ Foreground.Color�6S   5)      5*      5,      5.      5/      .��51      � $��	0,10,0,11q�6   $��Center=�6   $	��922��6;    � RowDefinitions 52   
   �� 53      $
��527* �6   �� 54      $	��78* �6   .+�56   
   ��  J� RenderTransformOrigin$ 0.496,0.492&�6   $��/LE_PENDU_LOGO.png��64   $��-88,-193,-88,10q�6P   $��2��6i   � 57   
   $��Center=�6   $	��140��6,   $��	0,377,0,0q�69   $	��Top=�6L   $	��738��6d   .+�58      �� $��
1,2,603,10q�6   .+�59      �� $��85��6   $��99��6$   $��/Historique.png��6/   �� 5:      -   5         ��Name$ btn_historique��5:      $��
HISTORIQUE��61   $��87��6F   $��0,9,0,0q�6Q   $��Century Gothic)�6b   ���	#FF65A7FF
����������	#FF65A7FF#��[  6�   $��28��6�   $
��Bold"�6�   $��11(�6%  5;      �� 5<      $��150,0,454,12q�6   $	��130��6/   .+�5=      �� $��85��6   $��99��6$   $��/settings.png��6/   �� 5>      -   5        $ btn_réglages��5>      $��PRÉFÉRENCES��6/   $��87��6E   $��Century Gothic)�6P   ���	#FF65A7FF
����������	#FF65A7FF#��[  6�   $��28��6�   $
��Bold"�6�   $��1,1,1,1q�6�   $��0,9,0,0q�6  $��11(�64  5?      �� 5@      $��302,2,302,10q�6   $	��133��6/   $	��130��6;   .+�5A      �� $��85��6   $��99��6$   $��	/play.png��6/   �� 5B      -   5        $ 	btn_jouer��5B      $��JOUER��6,   $��87��6<   $��Century Gothic)�6G   ���	#FF65A7FF
����������	#FF65A7FF#��[  6�   $��28��6�   $
��Bold"�6�   $��0,9,0,0q�6�   $��11(�6  5C      �� 5D      $��455,0,149,12q�6   $	��133��6/   $	��130��6;   .+�5E      �� $��85��6   $��99��6$   $��/dictionary.png��6/   �� 5F      -   5        $ btn_dictionnaire��5F      $��DICTIONNAIRE��63   $��87��6J   $��Century Gothic)�6U   ���	#FF65A7FF
����������	#FF65A7FF#��[  6�   $��28��6�   $
��Bold"�6�   $��0,9,0,0q�6  $��11(�6  6   5G      �� 5H      $��
604,2,0,10q�6   $	��133��6-   $	��130��69   .+�5I      �� $��85��6   $��99��6$   $��	/quit.png��6/   �� 5J      -   5        $ btn_quitter��5J      $��QUITTER��6.   $��87��6@   $��Century Gothic)�6K   ���	#FF65A7FF
����������	#FF65A7FF#��[  6�   $��28��6�   $
��Bold"�6�   $��1,1,1,1q�6�   $��0,9,0,0q�6	  $��11(�6  6(  5K      5L      5M      5N      
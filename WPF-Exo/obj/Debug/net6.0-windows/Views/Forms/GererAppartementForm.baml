   M S B A M L   `   `   `  ����B  >WPF-Exo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_Exo.Views.SubviewsWPF_Exo.Views.Subviews  5      1    +WPF_Exo.Views.Subviews.GererAppartementForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WPF_Exo.Views.Subviews     5        N� Title$  GererAppartementForm��5	      .��5      � .+�5   
   �� -   5         ��Name$ txtBxNom��5      $
��Left=�6$   $��
175,10,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��205��6   �� 5   
   -   5         ��Name$ txtBlockNom��5      $
��Left=�6)   $��	71,11,0,0q�6D   $
��Wrap=�6W   $	��Nom��6k   $	��Top=�6v   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ txtBxAdresse��5      $
��Left=�6(   $��
175,31,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��205��6�   �� 5   
   -   5        $ txtBlockAdresse��5      $
��Left=�6-   $��	60,33,0,0q�6H   $
��Wrap=�6[   $��Adresse��6o   $	��Top=�6~   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ txtBlockValeur��5      $
��Left=�6,   $��	66,54,0,0q�6G   $
��Wrap=�6Z   $��Valeur��6n   $	��Top=�6|   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ txtBxValeur��5      $
��Left=�6'   $��
175,53,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��205��6�   �� 5   
   -   5        $ txtBlockSurface��5      $
��Left=�6-   $��	66,77,0,0q�6H   $
��Wrap=�6[   $��Surface��6o   $	��Top=�6~   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ txtBxSurface��5      $
��Left=�6(   $��
175,75,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��205��6�   �� 5   
   -	   5        $ txtBxNbPiece��5      $
��Left=�6(   $��
175,96,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��205��6�   �� 5   
   -
   5        $ txtBlockNbPiece��5      $
��Left=�6-   $��	28,97,0,0q�6H   $
��Wrap=�6[   $��Nombre de pièce��6o   $	��Top=�6�   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ txtBxNbChambre��5      $
��Left=�6*   $��175,117,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��205��6�   �� 5   
   -   5        $ txtBlockNbChambre��5      $
��Left=�6/   $��
16,118,0,0q�6J   $
��Wrap=�6^   $��Nombre de chambre��6r   $	��Top=�6�   $��Arial)�6�   $��14(�6�   �� 5   
   -   5        $ 	txtBxCave��5      $
��Left=�6%   $��175,138,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��205��6�   �� 5   
   -   5        $ txtBlockCave��5      $
��Left=�6*   $��
69,139,0,0q�6E   $
��Wrap=�6Y   $
��Cave��6m   $	��Top=�6y   $��Arial)�6�   $��14(�6�   �� 5!   
   -   5        $ txtBxParking��5!      $
��Left=�6(   $��175,160,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��205��6�   �� 5"   
   -   5        $ txtBlockParking��5"      $
��Left=�6-   $��
61,160,0,0q�6H   $
��Wrap=�6\   $��Parking��6p   $	��Top=�6   $��Arial)�6�   $��14(�6�   �� 5$   
   -   5        $ 
txtBxEtage��5$      $
��Left=�6&   $��175,181,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��205��6�   �� 5%   
   -   5        $ txtBlockEtage��5%      $
��Left=�6+   $��
67,182,0,0q�6F   $
��Wrap=�6Z   $��Etage��6n   $	��Top=�6{   $��Arial)�6�   $��14(�6�   �� 5(   
   -   5         ��Name$ cmbBoxAscenseur��5(      $
��Left=�6,   $��175,206,0,0q�6G   $	��Top=�6\   $	��205��6t   $��15��6�   .@�5)      �� .��6   
Possède6$   �� 5*      .��6   Ne possède pas6+   5+      �� 5,   
   -   5        $ txtBlockAscenceur��5,      $
��Left=�6/   $��
57,205,0,0q�6J   $
��Wrap=�6^   $��	Ascenseur��6r   $	��Top=�6�   $��Arial)�6�   $��14(�6�   �� 5.   
   -   5        $ cmbBoxChauffage��5.      $
��Left=�6,   $��175,227,0,0q�6G   $	��Top=�6\   $	��205��6t   $��15��6�   .@�5/      �� .��6   
Possède6$   �� 50      .��6   Ne possède pas6+   51      �� 52   
   -   5        $ txtBlockChauffage��52      $
��Left=�6/   $��
54,225,0,0q�6J   $
��Wrap=�6^   $��	Chauffage��6r   $	��Top=�6�   $��Arial)�6�   $��14(�6�   �� 54   
   -   5         ��Name$ btnAjouterAppartement��54      $��Ajouter��60   $��Center=�6B   $��	0,270,0,0q�6_   $	��Top=�6r   $��82��6�   $��20��6�   6�   56      57      
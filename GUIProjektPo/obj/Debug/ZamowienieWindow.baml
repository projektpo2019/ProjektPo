   M S B A M L   `   `   `  ����G  CGUIProjektPo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GUIProjektPoGUIProjektPo  5   	   #    GUIProjektPo.ZamowienieWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GUIProjektPo     5   	     � Title$  ZamowienieWindow��5   	   $	��300��6"   $	��500��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ Label_numerZamowienia��5
      $4��.Wybierz rodzaj płatności i sposób wysyłki:��6/   $��16(�6d   $
��Left=�6r   $	��Top=�6�    J� RenderTransformOrigin$ 1.316,1.346&�6�   $��35��6�   $	��400��6�   $��	36,20,0,0q�6�   �� 5   
   -   5         ��Name$ ComboBox_rodzajPlatnosci��5      $
��Left=�65   $	��Top=�6P   $	��120��6h   $��
209,90,0,0q�6t   .@�5      �� -   5         ��Name$ ZaPobraniem��5      $��Za Pobraniem��60   $
��Left=�6G   $	��118��6b   �� 5      -   5        $ KartaPlatnicza��5      $��Karta Platnicza��63   $
��Left=�6M   $	��118��6h   �� 5      -   5        $ PrzelewBankowy��5      $��Przelew bankowy��63   $
��Left=�6M   $	��118��6h   5      �� 5   
   -   5        $ ComboBox_sposobWysylki��5      $
��Left=�63   $	��Top=�6N   $	��120��6f   $��209,154,0,0q�6r   .@�5      �� -   5        $ combobox_kurier��5      $��Kurier��64   $
��Left=�6E   $	��118��6`   �� 5      -   5        $ combobox_paczkomat��5      $��	Paczkomat��67   $
��Left=�6K   $	��118��6f   �� 5      -	   5        $ combobox_odbiorOsobisty��5      $��Odbior osobisty��6<   $
��Left=�6V   $	��118��6q   �� 5      -
   5        $ combobox_pocztaPolska��5      $��Poczta Polska ��6:   $
��Left=�6S   $	��118��6n   5      �� 5   
   $��Rodzaj płatnosci��6   $
��Left=�6+   $	��Top=�6F   $��	36,86,0,0q�6^   �� 5   
   $��Sposób wysyłki��6   $
��Left=�6)   $	��Top=�6D   $ 2.579,4.673&�6\   $��
43,150,0,0q�6�   �� 5   
   -   5         ��Name$ Button_zakoncz��5      $��Zakończ��6)   $
��Left=�6;   $	��Top=�6V   $��74��6n   $��630,370,0,0q�6y   $ 0.453,3.575&�6�   �� 5   
   -   5        $��zakoncz��5      $
��Left=�6#   $	��Top=�6>   $��74��6V   $��298,218,0,0q�6a   6v   5      5      
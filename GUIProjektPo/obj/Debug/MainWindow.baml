   M S B A M L   `   `   `  ����G  CGUIProjektPo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GUIProjektPoGUIProjektPo  5   	       GUIProjektPo.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GUIProjektPo     5   	     � Title$)  #Panel osoby realizujacej zamowienie��5   	   $	��600��65   $
��1000��6B   .��5	      � .+�5
   
   �� -   5         ��Name$ textBox_produkty��5
      $��Produkty��6*   $��Right=�6=   $��Bottom=�6Y    J� RenderTransformOrigin$ 2.684,3.731&�6t   $��0,0,990,392q�6�   $��92��6�   $	��172��6�   �� 5   
   -   5         ��Name$ listtBox_produkty��5      $
��Left=�6-   $��92��6H   $	��Top=�6T   $	��810��6l   $��
154,85,0,0q�6x   �� 5   
   -   5         ��Name$ button_dalej��5      $��Dodaj Klienta��6'   $��20(�6@   $
��Left=�6O   $	��Top=�6j   $	��271��6�   $��685,370,0,0q�6�   $��30��6�   �� 5   
   -   5        $ button_dodaj��5      $��Dodaj��6'   $��20(�67   $
��Left=�6E   $	��Top=�6`   $��91��6x   $��	30,85,0,0q�6�   $ 
5.853,0.35&�6�   $��27��6�   �� 5   
   -   5        $ label_wstep��5      $-��'Wybierz produkty, które zamowil klient��6&   $��26(�6W   $
��Left=�6e   $	��Top=�6�   $��	30,10,0,0q�6�   $	��718��6�   $��52��6�   �� 5   
   -   5        $  button_szczegolyzamowienia��5      $��Przejdz do zamowienia��65   $��20(�6V   $
��Left=�6d   $	��Top=�6   $	��271��6�   $��685,425,0,0q�6�   $��28��6�   6�   �� 5   
   $��Wybrane produkty��6   $��20(�6+   $
��Left=�69   $	��Top=�6T   $��
30,182,0,0q�6l   �� 5   
   -   5        $ ListBox_wybraneProdukty��5      $
��Left=�63   $��64��6N   $	��Top=�6Z   $	��810��6r   $��154,239,0,0q�6~   �� 5   
   $��Klient��6   $��20(�6!   $
��Left=�6/   $	��Top=�6J   $ 1.895,7.962&�6b   $��
50,329,0,0q�6�   $��89��6�   �� 5   
   -   5         ��Name$ TextBox_klient��5      $
��Left=�6*   $��37��6E    �� TextWrapping$
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��502��6�   $��154,329,0,0q�6�   �� 5   
   $#��Całkowita wartosc zamowienia��6   $��20(�67   $
��Left=�6E   $	��Top=�6`   $��
30,412,0,0q�6x   �� 5   
   -	   5        $ TextBox_wartosc��5      $
��Left=�6+   $��23��6F   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��120��6�   $��354,412,0,0q�6�   �� 5   
   -
   5        $��Zakończ i zapisz��5      $
��Left=�6,   $��20(�6H   $	��Top=�6V   $	��271��6n   $��685,482,0,0q�6z   $��26��6�   6�   5      5      
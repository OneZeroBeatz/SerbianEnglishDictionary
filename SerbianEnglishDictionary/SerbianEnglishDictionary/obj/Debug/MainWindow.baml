   M S B A M L   `   `   `  ����S  OSerbianEnglishDictionary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SerbianEnglishDictionarySerbianEnglishDictionary  5   	   )    #SerbianEnglishDictionary.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SerbianEnglishDictionary     5   	     � Title$  
MainWindow��5   	   $��202.619��6   $��515.044��6-   .��5	      � $��0,0,2,-1q�6   .+�5
      �� -   5         ��Name$ SwapLanguagesButton��5
      $��Swap Languages��6(   $
��Left=�6A   $��
200,41,0,0q�6\   $	��Top=�6p   $��98��6�    J� RenderTransformOrigin$ 0.383,0.687&�6�   �� 5      -   5        $ 
ShowButton��5   1   $
��Show��6E   $
��Left=�6T   $��
200,66,0,0q�6o   $	��Top=�6�   $��98��6�   ��6   �� *ShowAnswerCommand+6�   �� 5      -   5        $ Confirm��5   4   $��Confirm��6E   $
��Left=�6W   $��200,141,0,0q�6r   $	��Top=�6�   $��98��6�   ��6   �� *ConfirmAnswerCommand+6�   �� 5      -   5        $
 Save��5   1   $
��Save��6?   $
��Left=�6N   $��
200,91,0,0q�6i   $	��Top=�6}   $��98��6�   $ 0.383,0.687&�6�   ��6   �� *SaveEntityCommand+6�   �� 5      -   5        $ 
NextButton��5   /   $
��Next��6C   $
��Left=�6R   $��200,116,0,0q�6m   $	��Top=�6�   $��98��6�   ��6   �� *NextWordCommand+6�   �� 5      -   5         ��Name$ WordToGuessTextBox��5   Y   $
��Left=�6u   $	��120��6�   $��	10,41,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��185��6�   ��6   �� *	FirstWord+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5        $ AnswerTextBox��5   Z   $
��Left=�6q   $	��120��6�   $��
303,41,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��191��6�   ��6   �� *
SecondWord+$ TwoWay=�$ PropertyChanged=�6�   �� 5      -   5         ��Name$ WortToGuessLanguageLabel��5   
   $��Label��6,   $
��Left=�6<   $��
157,10,0,0q�6W   $	��Top=�6k   �� 5      -	   5        $ AnswerLanguageLabel��5   
   $��Label��6'   $
��Left=�67   $��
303,10,0,0q�6R   $	��Top=�6f   �� 5      -
   5        $ To��5   
   $��To��6   $
��Left=�6#   $��
239,10,0,0q�6>   $	��Top=�6R   5      5      
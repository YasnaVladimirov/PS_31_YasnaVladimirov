   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   "    StudentInfoSystem.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ MainGrid��5	      .+�5
   
   �� $��Лични данни��6   $��10,10,10,290q�6(   .��5      � .+�5      �� -   5         ��Name$ lblFirstName��5      $��Име:��6.   $
��Left=�6=   $��22,0,0,0q�6X   $	��Top=�6j   �� 5      -   5        $ lblMiddleName��5      $��Презиме:��6/   $
��Left=�6B   $��	22,30,0,0q�6]   $	��Top=�6p   $��78��6�   �� 5      -   5        $ lblLastName��5      $��Фамилия:

��6-   $
��Left=�6T   $��	22,60,0,0q�6o   $	��Top=�6�   $��26��6�   �� 5      -   5         ��Name$ txtFirstName��5      $
��Left=�60   $��	148,5,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5      -   5        $ txtMiddleName��5      $
��Left=�61   $��
148,35,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5      -   5        $ txtLastName��5      $
��Left=�6/   $��
148,65,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   5      5      �� 5   
   $/��)Студентска информация��6   $��10,129,10,104q�62   .��5      � .+�5      �� -   5        $ 
lblFaculty��5      $��Факултет:��6,   $
��Left=�6@   $��22,0,0,0q�6[   $	��Top=�6m   �� 5      -	   5        $ lblSpeciality��5      $��Сециалност:��6/   $
��Left=�6E   $��	22,30,0,0q�6`   $	��Top=�6s   �� 5      -
   5        $ 	lblDegree��5      $��ОКС:��6+   $
��Left=�6:   $��	22,60,0,0q�6U   $	��Top=�6h   �� 5      -   5        $ 	lblStatus��5      $��Статус:��6+   $
��Left=�6=   $��	23,90,0,0q�6X   $	��Top=�6k   �� 5      -   5        $ lblFacultyNumber��5      $��Фак. номер:��62   $
��Left=�6H   $��
23,120,0,0q�6c   $	��Top=�6w   �� 5      -   5        $ txtYear��5      $
��Left=�6+   $��	443,5,0,0q�6F   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5      -   5        $ txtSpeciality��5      $
��Left=�61   $��
148,35,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5      -   5        $ 	txtDegree��5      $
��Left=�6-   $��
148,65,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5      -   5        $ 	txtStatus��5      $
��Left=�6-   $��
148,95,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5      -   5        $ txtFacultyNumber��5      $
��Left=�64   $��148,125,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5       -   5        $ 	lblStream��5       $��Поток:��6+   $
��Left=�6<   $��
381,30,0,0q�6W   $	��Top=�6k   �� 5!      -   5        $ lblGroup��5!      $��Група:��6*   $
��Left=�6;   $��
381,60,0,0q�6V   $	��Top=�6j   �� 5"      -   5        $ 	txtStream��5"      $
��Left=�6-   $��
443,35,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5#      -   5        $ txtGroup��5#      $
��Left=�6,   $��
443,65,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5$      -   5        $ 
txtFaculty��5$      $
��Left=�6.   $��	148,5,0,0q�6I   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5%      -   5        $ lblYear��5%      $��	Курс:��6)   $
��Left=�69   $��	380,0,0,0q�6T   $	��Top=�6g   5&      5'      5)      5*      
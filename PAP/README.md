## Programm Ablauf Plan

Ein Auftraggeber will ein Programm, womit er schnell und einfach ermitteln kann, ob sich ein Grundstück im preislich passenden Rahmen befindet.

| Anf.-Nr. | Typ           | Anforderung                                                                         |
|----------|---------------|-------------------------------------------------------------------------------------|
| 1        | Funktional    | Man soll einen beliebigen Preis angeben können.                                     |
| 2        | Funktional    | Man soll eine beliebige Größe angeben können.                                       |
| 3        | Funktional    | Man soll einen beliebigen Maximalpreis angeben können.                              |
| 4        | Funktional    | Der Wert des gesamten Grundstücks soll berechnet werden, inklusive Mehrwertsteuer.  |
| 5        | Funktional    | Es soll geprüft werden, ob der Gesamtpreis mit Mehrwertsteuer im Rahmen des Maximalpreises liegt. |
| 6        | Qualität      | Sollte der Preis nicht übereinstimmen, soll dies angezeigt werden und das Programm soll von vorne beginnen. |
| 7        | Randbedingung | Das Programm soll am 05.11.2024 fertig sein.                                        |
| 8        | Randbedingung | Das Programm soll in C# geschrieben sein.                                           |


Aus diesen Anforderungen erstellt der Entwickler anschließend einen PAP (Programmablaufplan), in dem das Programm, das später programmiert werden muss, grafisch nach bestimmten Richtlinien dargestellt wird.
Dies hilft ihm nichts zu vergessen und das Programm besser zu verstehen.

Jeder Programablaufplan Fängt mit einem Start an und endet mit einem Ende. Zwischen diesen beiden Symbolen befindet sich das Programm. In meinem Beispiel fängt es mit vier Eingaben an. Daraufhin geht es weiter in ein Unterprogramm, dieses Unterprogramm kann man im Unteren Screenshot sehen. In diesem Unterprogramm wird mit Verarbeitungssymbolen dargestellt, wie der Preis ermittelt wird.
Wenn es durchgelaufen ist kommt es zu einer Kontrollstruktur, die ermittelt, ob sich der Preis im Rahmen des Maximalpreises befindet. Sollte dies nicht so sein so gibt das Programm dies aus und geht wieder zum Anfang.
Sollte der Preis jedoch im Rahmen liegen so gibt das Programm diesen Preis aus und beendet sich.
![PAP](Screenshot_2024-11-06_184858.png)
![PAP](Screenshot_2024-11-06_184907.png)


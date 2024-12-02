Eine Anforderungsanalyse dient zum Erfassen der Kundenwünsche und zum Festhalten des Inhaltes eines Auftrags.

Beispiel: Ein Auftraggeber will ein Programm, womit er schnell und einfach ermitteln kann, ob sich ein Grundstück im preislich passenden Rahmen befindet.

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


Wir haben eine Tabelle, in der verschiedene Sachen beschrieben sind. Wir haben mehrere Anforderungen. Jede Anforderung hat eine Anforderungsnummer, einen Typ und eine kurze Beschreibung der Anforderung. Die Anforderungsnummer dient nur zur Strukturierung der Anforderungen.

Im Typ wird beschrieben, um welche Art von Anforderung es sich handelt. Zum Beispiel gibt es funktionale Anforderungen, die etwas mit der Funktion der Anwendung zu tun haben. Außerdem gibt es noch Qualitätsanforderungen; diese betreffen die Qualität der Anwendung. Das Programm würde auch ohne diese Anforderungen laufen, wäre dann aber beispielsweise nicht so benutzerfreundlich.

Dann gibt es noch Randbedingungen. Diese regeln alles rund um den Auftrag, beispielsweise in welcher Programmiersprache die Anwendung geschrieben sein soll oder bis wann sie fertig sein muss.

Bevor der Programierer nun mit dem Entwickeln des Codes anfängt, wird ein Testkonzept erstellt. Wie dieses genau aufgebaut ist, wird im Abschnitt Tests genauer erklärt. Wichtig zu wissen ist, dass bei den Testspezifikationen die Anforderungsnummer angegeben werden muss.

Aus diesen Anforderungen erstellt der Entwickler anschließend einen PAP (Programmablaufplan), in dem das Programm, das später programmiert werden muss, grafisch nach bestimmten Richtlinien dargestellt wird.

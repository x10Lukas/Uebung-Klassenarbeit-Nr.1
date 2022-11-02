## Aufgabe 1:

> Ein Vermessungsgerät liefert folgende Daten:
```
Höhe:   32,346 m
Breite: 15,193 m 
```
> Schreiben Sie einen C#-Code,welcher die initialisierten Daten in der Konsole ausgibt. Die folgende 
> Struktur zeigt,wie die Konsolenausgabe aussehen soll. Jede Zelle repräsentiert dabei eine 
> Zeichenstelle.

|   | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |
|--:|--:|--:|--:|--:|--:|--:|--:|--:|--:|---:|---:|---:|---:|---:|---:|---:|---:|---:|---:|---:|
| 1 |   |   |   |   |   |   | H | ö | h | e  |    |    |    |    | B  | r  | e  | i  | t  | e  |
| 2 |   |   |   |   |   |   |   |   |   |    |    |    |    |    |    |    |    |    |    |    |
| 3 |   |   |   |   |   |   | 3 | 2 | , | 3  |    |    |    |    |    |    | 1  | 5  | ,  | 2  |

    string sHöhe = "Höhe", sBreite = "Breite";
    float fHöhe = 32.346F, fBreite = 15.193F;    

## Lösung der Aufgabe
![Screenshot (2)](https://user-images.githubusercontent.com/65921256/199503482-3933e4bf-d64f-4c5c-80fa-4024ec4bdfd3.png)

## Aufgabe 2:

> Geben Sie an, wie die jeweilige Konsolenausgabe aussieht. 

```
intx = 3, y = 6;
bool flag = true;

Console.WriteLine(x + y);                       //Ausgabe____________________
Console.WriteLine(x / y);                       //Ausgabe____________________
Console.WriteLine(3.0 / y);                     //Ausgabe____________________
Console.WriteLine(x == y);                      //Ausgabe____________________
Console.WriteLine(x++ == y | true);             //Ausgabe____________________
Console.WriteLine(x > 3);                       //Ausgabe____________________
Console.WriteLine(--y == ++x & flag & true);    //Ausgabe____________________
```

## Lösung der Aufgabe
![Screenshot (3)](https://user-images.githubusercontent.com/65921256/199510546-2ec056b2-a157-41f6-b876-2d219a6cf259.png)

## Aufgabe 3:

> Schreiben Sie ein Programm zur Kalkulation der Warmmiete.
> Der Benutzer soll folgende Daten **eingeben**. 
>
> Kaltmiete/m^2, Nebenkosten/m^2, Quadratmeter des Objekts
>
> Die Kalkulation und Ausgabe erfolgt nach dem folgenden Beispiel: 
```
Kaltmiete/m^2:                            12.00 EUR
Nebenkosten/m^                            22.50 EUR
Quadratmeter des Objekts                  79 m^2

Kaltmiete:                                948 EUR
Nebenkosten:                              197.50 EUR
Warmmiete:                                1145.00 EUR
```

## Lösung der Aufgabe
![Screenshot (4)](https://user-images.githubusercontent.com/65921256/199513351-805c02c6-accf-4b1d-b106-ecc8b28ec4d1.png)

## Aufgabe 4:

> Entwickeln Sie ein Programm, das die Werte für Gewicht und Größe über die Konsole 
> einliest, anschließend den Bodymaßindex berechnet und in der Konsole ausgibt.
>
> BMI = Gewicht / (Körpergröße zum Quadrat)
>
> Achten Sie auf die Benutzerfreundlichkeit.

## Lösung der Aufgabe
![Screenshot (5)](https://user-images.githubusercontent.com/65921256/199513942-83453eb0-bf9f-4a4d-9e22-a57bab083a5c.png)

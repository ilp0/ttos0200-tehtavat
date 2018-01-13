using System;

public class harj6 {
 public static void Main(string[] args) {
     /*
     Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

        Algoritmi:

        4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
        Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
    */
    System.Console.WriteLine("input year");
    int luku = int.Parse(Console.ReadLine());

    if(luku % 4 == 0 && luku % 100 != 0 || luku % 400 == 0){
        System.Console.WriteLine("it is a leap year");
    }else {
        System.Console.WriteLine("it is not leap year");
    }
 }
}
/*Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.

Esimerkkitoiminta:

 
    Elevator is now in floor : 1
    Give a new floor number (1-5) > 2 */
using System;

namespace ns4_2 { 
    class Control{
        static void Main (string[] args){
            Hissi h = new Hissi();
            while (true){
                System.Console.WriteLine("Current floor is " + h.Floor);
                System.Console.WriteLine("Valitse kerros");
                h.Floor = int.Parse(Console.ReadLine());
            }
        }
    }
}
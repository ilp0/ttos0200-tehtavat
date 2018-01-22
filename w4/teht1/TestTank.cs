/*Tehtävä 1
Toteuta luokka Tank, jolla on seuraavat ominaisuudet: Name (string), Type (string), CrewCount(int), Speed(float) ja SpeedMax(float) sekä metodit AccerelateTo(float) ja SlowTo(float). Toteuta ominaisuudet niin että kaikilla ominaisuuksilla on luokan sisäinen taustamuuttuja, joita luokka käyttää.

 Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia.
 Ominaisuus CrewCount on luettavissa ja asetettavissa. Sitä asetettaessa tarkistetaan että annettu ominaisuus on sallitulla välillä: sallittu minimi on kaksi ja maksimi kuusi.
 
SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena pysyvästi arvoon 100. 

Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa suoraan mutta sen arvon voi lukea. Speed-omainaisuuden arvoa voi muuttaa ainoastaan metodien AccerelateTo(float) ja SlowTo(float) kautta kuitenkin niin että Speed ei voi olla nollaa pienempi eikä Speedmax-arvoa suurempi. - minimi on nolla ja maksimi 100.

 Jos metodeille annettu arvo ei ole sallitulla välillä niin metodi ei muuta Speed-arvoa.

Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista. Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan jotenkin tietää että metodi ei asettanutkaan nopeutta pyydettyyn arvoon? */

using System;

namespace ns {
    class TestTank{
        static void Main (string[] args){
            Tank a = new Tank();
            a.CrewCount = 5;
            a.Name = "boaty mcboatface";
            a.Type = "kiituri";
            System.Console.WriteLine("crewcount: " + a.CrewCount);
            System.Console.WriteLine("current speed: " + a.Speed + "\nname: " + a.Name + "\ntype: " + a.Type);
            a.AccelerateTo(9f);
            System.Console.WriteLine("speed changed to: " + a.Speed);
        }
    }
}
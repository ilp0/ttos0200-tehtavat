//Toteutetaan opettajan kanssa yhdessä konsolipohjainen MiniASIO-ohjelma, jolla voidaan lisätä, poistaa ja hakea opiskelijoiden tietoja. Luo Opiskelija-luokka, jolla on ominaisuudet Etunimi, Sukunimi, AsioID ja Ryhmä. AsioID on aina uniikki, yksilöllinen. Lisää rekisteriin aluksi neljän testi-oppilaan tiedot: Masa Niemi, Allan Aalto, Hanna Husso ja Teppo Testaaja.

using System;
using System.Linq;
using System.Collections.Generic;
namespace ns9_1{
    class prog {
         static void Main (string[] args){
             List<Opiskelija> opiskelijat = new List<Opiskelija>();
             opiskelijat.Add(new Opiskelija());
             opiskelijat[0].AddInfo("Masa", "Niemi","L4539","TTV17S4");
         }
    }
}
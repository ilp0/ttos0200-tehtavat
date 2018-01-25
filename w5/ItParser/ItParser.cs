using System;
using System.Linq;
namespace ns{
    class ItParser{
        public static int Count(string syote){
            string[] arr = syote.Split(',');
            return arr.Length;
        }

        public static int Sum(string syote){
            string[] stringArr = syote.Split(',');
            int[] intArr = Array.ConvertAll(stringArr, int.Parse);
            return intArr.Sum();
        }

        public static int Average(string syote){
            string[] stringArr = syote.Split(',');
            int[] intArr = Array.ConvertAll(stringArr, int.Parse);
            return (intArr.Sum() / intArr.Length);
        }
    }
}
/*
Tehtävä 3
Tee ohjelma joka kysyy käyttäjältä yhdestä kymmeneen lukua, niin että käyttäjä antaa luvut yhtenä merkkijonona pilkulla erotettuna. Siis esimerkiksi käyttäjä antaa merkkijonon "50,60,70,80,90". Tee luokka ItParser ja sille kolme staattista metodia. Metodeille annetaan argumenttina käyttäjän antama merkkijono ja metodit palauttavat tuloksen. Toteuta metodit:
int Count(string syote) ; metodi palauttaa montako lukua annetussa merkkijonossa on
int Sum(string syote) ; metodi palauttaa merkkijonon lukujen summan
int Average(string syote) ; metodi palauttaa merkkijonon lukujen keskiarvon
Tee pääohjelma TestParser(), jolla testaat tekemiäsi metodeja erilaisilla lähtöarvoilla. Tarkista että metodisi varmasti palauttavat oikein eri tilanteissa.
Oheisessa kuvassa on suoritettu kaksi testiä, sekä kahdella että viidellä luvulla.
*/
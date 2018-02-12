using System;
namespace ns_5{
    class ItMath{
        public static bool OnkoLuku(string syote){
            double luku;
            if (double.TryParse(syote, out luku)) return true;
            else {
                return false;
            }
        }
        public static bool OnkoPvm(string syote){
           string[] dateArr = syote.Split('.');
           if (dateArr.Length == 3) {
                if(int.Parse(dateArr[0]) > 0 && int.Parse(dateArr[0]) < 32) {
                    if(int.Parse(dateArr[1]) > 0 && int.Parse(dateArr[1]) < 13 ){
                        if(int.Parse(dateArr[2]) > 0){
                            return true;
                        } else {
                            System.Console.WriteLine("problem with year");
                        }
                    } else {
                        System.Console.WriteLine("problem with month");
                    }
                } else {
                    System.Console.WriteLine("problem with date");
                }
           } else {
              System.Console.WriteLine("problem with the format (.)");
           }
           return false;
        }
    }
}
/*Tee luokka ItMath, jolla on seuraava staattinen metodi:

Luvun tarkastaminen
bool OnkoLuku(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).

Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi, jolla testaat erilaisia vaihtoehtoja.
Alla esimerkin omainen Metodin OnkoLuku testaus kelvollisilla ja epäkelvoilla syötteillä. 

Tehtävä 2
Tee luokkaan ItMath staattinen metodi:

Päivämäärän tarkastaminen
bool OnkoPvm(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on suomalaisessa päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv", eli metodi esimerkiksi tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13", "1.10.2017", "12.12.2017", "24.12.17"
Seuraavia syötteitä ei kelpuuteta: "12,12,2016" --> väärä erotin, tai "12.13.2017" --> väärä kuukausi tai "30.2.2017" --> helmikuussa ei ole kolmeakymmentä päivää!
*/
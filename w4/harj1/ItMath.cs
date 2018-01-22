using System;
namespace ns{
    class ItMath{
        public static bool OnkoLuku(string syote){
            double luku;
            if (double.TryParse(syote, out luku)) return true;
            else {
                return false;
            }
        }
    }

}
/*Tee luokka ItMath, jolla on seuraava staattinen metodi:

Luvun tarkastaminen
bool OnkoLuku(string syote): metodi tutkii annetun merkkijonon ja palauttaa true, jos syöte on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).

Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi, jolla testaat erilaisia vaihtoehtoja.
Alla esimerkin omainen Metodin OnkoLuku testaus kelvollisilla ja epäkelvoilla syötteillä. */
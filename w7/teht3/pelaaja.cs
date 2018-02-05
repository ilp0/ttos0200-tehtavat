/*Jääkiekon SM-liigassa on viisitoista joukkuetta ja jokaisessa joukkuuessa on noin 25 pelaajaa. Tee Pelaaja-luokka, jolla on ominaisuudet: etunimi, sukunimi, pelipaikka (mv, p, h), kätisyys (L tai R). Luo myös luokka Seura, jolla on ominaisuudet: nimi, kaupunki ja kokoelma Pelaaja-olioita. Tee konsoli sovellus, joka osaa esittää valitun seuran pelaajat. Voit "kovakoodata" pelaajatiedot pelaajaolioihin. */
using System;
using System.Linq;
using System.Collections.Generic;
namespace ns_7{
    class Pelaaja {
        public string f_name {get;set;}
        public string l_name {get;set;}
        public string pelipaikka {get;set;}
        public string hand {get;set;}

    }

    class Seura {
        public string name {get;set;}
        public string city {get;set;}
        public List<Pelaaja> players = new List<Pelaaja>();
    }
}
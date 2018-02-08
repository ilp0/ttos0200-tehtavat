/*
Tehtävä 1
Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.

Esimerkkitoiminta:


    Created a new vehichle Porsche model 911
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    
    Vechicle Name: Porsche Model:911
    Tyres:
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    
    Created a new vehichle Ducati model Diavel
    Tyre MIC added to vehicle Ducati
    Tyre MIC added to vehicle Ducati
    
    Vechicle Name: Ducati Model:Diavel
    Tyres:
    -Name: MIC Model:Pilot TyreSize:160R17
    -Name: MIC Model:Pilot TyreSize:140R16    
    ...
     */
using System;
using System.Linq;
using System.Collections.Generic;
namespace ns{
    public class Car {
        public Car(string i_name, string i_model){
            System.Console.WriteLine("Created a new Vechile " + i_name + " " + i_model);
            name = i_name;
            model = i_model;
        }
        public string name {get; se;}
        public string model {get;set;}

        public List<Tyre> tyres = new Litst<Tyre>();
        public void AddTyres (string a, int b, string c){
            for (int i = 0; i < 4; i++) {
                 tyres.Add(new Tyre() { type = a, size = b, brand = c });
                 System.Console.WriteLine("Added new tyre Type: " + tyres[i].type + " Size: " + tyres[i].size + " Brand: " + tyres[i].brand);
            }
        }
    }
    
    public class Tyre {
        public string type {get; set;}
        public int size {get;set;}
        public string brand {get;set;}
    }
}


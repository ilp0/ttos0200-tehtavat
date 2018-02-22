using System;
using System.Linq;
using System.Collections.Generic;
namespace ns9_1{
    class Opiskelija {
        public string Etunimi {get; protected set;}
        public string Sukunimi {get; protected set;}
        public string AsioID {get; protected set;}
        public string Ryhma {get; protected set;}
        public void AddInfo(string etunimi, string sukunimi, string asioId, string ryhma){
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            AsioID = asioId;
            Ryhma = ryhma;
        }
    }
}
using System;
using System.Linq;
namespace ns6_4{
    class item {
        public string name {get;set;}
    }
    class levyke : item {
        public string kunto {get;set;}
    }
    class CD : levyke {
        public int biisienMaara {get;set;}
    }
    class DVD : levyke {
        public string elokuvanPituus {get;set;}
    }
    class BluRay : DVD {

    }
}
using System;
using System.Linq;
namespace ns{
    class item {
        public string name {get;set;}
    }
    class levyke : tavara {
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
using System;
using System.Linq;
namespace ns{
    class Radio {
        private int _volume;
        private float _taajuus;
        public bool isOn {get;set;}
        public int volume {
            get {
                return _volume;
            }
            set {
                if (value < 9 && value >= 0) {
                    _volume = value;
                }
                else System.Console.WriteLine("invalid volume");
            }
        }

        public float taajuus {
            get {
                return _taajuus;
            }
            set {
                if (value <= 26000f  && value >= 2000f) {
                    _taajuus = value;
                }
                else System.Console.WriteLine("invalid volume");
            }
        }
    }
}
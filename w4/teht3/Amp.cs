using System;

namespace ns {
    class Amp{
        private int _Volume = 0;
        public int Volume{
            get {
                return _Volume;
            }
            set {
                if(value >= 0){
                    if(value <= 100 ) {
                        _Volume = value;
                    } else {
                        System.Console.WriteLine("Volume value too high! Volume set to MAX");
                        _Volume = 100;
                    }
                } else {
                    System.Console.WriteLine("Volume value too low! Volume set to MIN");
                    _Volume = 0;
                }
            }
        }
    }
}
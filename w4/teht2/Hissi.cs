using System;

namespace ns {
    class Hissi{
        private int _Floor = 1;
        public int Floor{
            get {
                return _Floor;
            }
            set {
                if(value > 0){
                    if(value < 6) {
                        _Floor = value;
                    } else {
                        System.Console.WriteLine("Floor value too high!");
                    }
                } else {
                    System.Console.WriteLine("Floor value too low!");
                }
            }
        }
    }
}
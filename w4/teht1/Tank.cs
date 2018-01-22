using System;

namespace ns {
    class Tank{

        public string Name = "";
        public string Type = "";
        private int _CrewCount = 2;
        public int CrewCount {
            get {
                return _CrewCount;
            }
            set {
                if (value >= 2 && value <= 6) _CrewCount = value;
                else {
                    System.Console.WriteLine("Invalid input, CrewCount must be between 2 and 6");
                }
            }
        } 
        public readonly int SpeedMax = 100;
        private float _speed = 0f;
        public float Speed {
            get {
                return _speed;
            }
        }
        
        public void AccelerateTo (float value){
            if(value < SpeedMax && value >= 0){
            _speed = value;
            } else {
                System.Console.WriteLine("invalid speed");
            }
        }

        public void SlowTo (float value){
            if(value < SpeedMax && value >= 0){
                _speed = value;
            } else {
                System.Console.WriteLine("invalid speed");
            }
            
        }
    }
}
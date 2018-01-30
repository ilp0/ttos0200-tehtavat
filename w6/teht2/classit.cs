using System;
using System.Linq;
namespace ns{
    class Vehicle {
        public string name {get; set;}
        public string model {get; set;}
        public string modelYear {get; set;}
        public string color {get;set;}
        public virtual string printInfo(){
            return ("Name: " + name + " Model: " + model + " ModelYear: " + modelYear + " Color: " + color);
        }
    }
    class Bike : Vehicle {
        public bool gearWheels {get; set;}
        public string gearName {get; set;}
        public override string printInfo(){
             return ("Name: " + name + " Model: " + model + " ModelYear: " + modelYear + " Color: " + color + " GearWheels: " + gearWheels + " GearName: " + gearName);
        }
    }
    class Boat : Vehicle {
        public int seatCount {get; set;}
        public string boatType {get;set;}
        public override string printInfo(){
             return ("Name: " + name + " Model: " + model + " ModelYear: " + modelYear + " Color: " + color + " SeatCount: " + seatCount + " BoatType: " + boatType);
        }
    }
}
using System;
using System.Linq;
namespace ns{
    class prog {
        static void Main (string[] args){
            Bike b1 = new Bike();
            b1.name = "Jopo";
            b1.model = "Street";
            b1.modelYear = "2016";
            b1.color = "Blue";
            b1.gearWheels = false;
            System.Console.WriteLine(b1.printInfo());

            Bike b2 = new Bike();
            b2.name = "Tunturi";
            b2.model = "Street";
            b2.modelYear = "2010";
            b2.color = "Black";
            b2.gearWheels = true;
            b2.gearName = "Shimano";
            System.Console.WriteLine(b2.printInfo());

            Boat boat1 = new Boat();
            boat1.name = "Suvi";
            boat1.model = "S900";
            boat1.modelYear = "1990";
            boat1.color = "White";
            boat1.seatCount = 3;
            boat1.boatType = "Rowboat";
            System.Console.WriteLine(boat1.printInfo());

            Boat boat2 = new Boat();
            boat2.name = "Yamaha";
            boat2.model = "Model 1000";
            boat2.modelYear = "2010";
            boat2.color = "Yellow";
            boat2.seatCount = 5;
            boat2.boatType = "Motorboat";
            System.Console.WriteLine(boat2.printInfo());
        }
    }
}
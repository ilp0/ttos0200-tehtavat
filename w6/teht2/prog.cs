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
        }
    }
}
using System;
using System.Linq;
namespace ns{
    class progw7 {
        static void Main (string[] args){
            Car skoda = new Car();
            skoda.name = "skoda";
            skoda.model = "fabia";
            skoda.AddTyres("Bridgestone", 1, "aaa");
            System.Console.WriteLine(skoda.tyres[3].brand);
        }
    }
}
    
using System;
using System.Linq;
namespace ns{
    class prog {
        static void Main (string[] args){
            Employee kirsi = new Employee();
            kirsi.name = "Kirsi Kernel";
            kirsi.profession = "Teacher";
            kirsi.salary = 1200;
            System.Console.WriteLine(kirsi.printInfo());
            
            Boss jussi = new Boss();
            jussi.name = "Jussi Jurkka";
            jussi.profession = "Head of Institute";
            jussi.salary = 9000;
            jussi.car = "Audi";
            jussi.bonus = 5000;
            System.Console.WriteLine(jussi.printInfo());

            kirsi.profession = "Principal Teacher";
            kirsi.salary = 2200;
            System.Console.WriteLine(kirsi.printInfo());
            
        }
    }
}
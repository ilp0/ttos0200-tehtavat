using System;
using System.Linq;
namespace ns{
    class Employee {
       public string name {get; set;}
       public string profession {get; set;}
       public float salary {get; set;}
       public virtual string printInfo() {
           return ("Name: " + name + " Profession: " + profession + " Salary: " + salary);
       }
    }
    class Boss : Employee {
       public string car {get; set;}
       public float bonus {get; set;}
       public override string printInfo() {
           return ("Name: " + name + " Profession: " + profession + " Salary: " + salary + " Car: " + car + " Bonus: " + bonus);
       }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
namespace ns8_1{
    class prog {
         static void Main (string[] args){
             List<Customer> Customers = new List<Customer>();
             for (int i = 0; i < 15; i++){
             Customers.Add(new Customer() {Name = "Pekka" + i});
             Customers[i].AddOrder(0, "1.1.2018");
             Customers[i].Orders[0].AddItem("banaani" + i, 10);
             }
             System.Console.WriteLine(Customers[10].Orders[0].OrderItems[0].Name);
        }
    }
}
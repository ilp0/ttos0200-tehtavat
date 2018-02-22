using System;
using System.Linq;
using System.Collections.Generic;
namespace ns12_1{
    class prog {
         static void Main (string[] args){
             System.Console.WriteLine("Test throw = " + Noppa.Heitto());
             int throwNum = 0;
             try {
             throwNum = int.Parse(Console.ReadLine());
             } catch (FormatException) {
                 System.Console.WriteLine("You didn't give a number!");
             }
             List<int> throwList = new List<int>();
             for (int i = 0; i < throwNum; i++) throwList.Add(Noppa.Heitto());
            Console.WriteLine("average: " + throwList.Average());
             
         }
         
    }
}
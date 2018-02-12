using System;
using System.Linq;
namespace ns2_8 {
public class harj8 {
 public static void Main(string[] args) {
     int[] num = new int[3];
     for (int i = 0; i < 3; i++){
       System.Console.WriteLine("input a number:");
       num[i] = int.Parse(Console.ReadLine());  
     }
    Console.WriteLine("biggest number is " + num.Max());
    Console.ReadKey();
 }
}
}
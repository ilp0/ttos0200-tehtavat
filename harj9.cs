using System;
using System.Linq;

public class harj8 {
 public static void Main(string[] args) {
      int temp = 10, num = 0;
      System.Console.WriteLine("input numbers, to stop: input 0");
     while (temp != 0) {
       try {
         temp = int.Parse(Console.ReadLine());
       }
       catch{
         System.Console.WriteLine("not a number, stopping loop");
         temp = 0;
       }
        num += temp;
     }
    Console.WriteLine("sum: " + num);
 }
}
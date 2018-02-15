using System;
namespace ns3_1 {
public class harj1 {
 public static void Main(string[] args) {
     
     System.Console.WriteLine("Input a number: ");
     int num = int.Parse(Console.ReadLine());

     for (int i = 0; i <= num; i++){
         Console.WriteLine("");
         for (int a = 0; a < i; a++){
             Console.Write("*");
         }
     }
     Console.ReadKey();
 }
}}
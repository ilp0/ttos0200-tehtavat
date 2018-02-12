using System;
using System.Linq;
namespace ns3_3 {
public class harj3 {
 public static void Main(string[] args) {
     int MAX = 5;
     int[] scores = new int[MAX];

     for (int i = 0; i < MAX; i++){ 
         System.Console.WriteLine("Give points: ");
         scores[i] = int.Parse(Console.ReadLine());
     }
     
    System.Console.WriteLine("Your score was " + (scores.Sum() - scores.Max() - scores.Min()).ToString());
    Console.ReadKey();
 }
}}

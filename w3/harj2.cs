using System;
namespace ns3_2 {
public class harj2 {
 public static void Main(string[] args) {
     int MAX = 10;
     int[] numbers = new int[MAX];
     for (int i = 0; i < MAX; i++){
         numbers[i] = int.Parse(Console.ReadLine());
     }
     System.Console.WriteLine("Numbers are: ");
     for (int i = 1; i <= MAX; i++) {
         Console.Write(numbers[MAX-i].ToString() +", ");
     }
     Console.ReadKey();
 }
}
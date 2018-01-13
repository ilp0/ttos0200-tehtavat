using System;

public class harj5 {
 public static void Main(string[] args) {
     System.Console.WriteLine("give seconds>");
     int input = int.Parse(Console.ReadLine());
     int hours = (input / 3600);
     int minutes = (input % 3600) / 60;;
     int seconds = (input % 60);
    System.Console.WriteLine(input + " seconds is equal to " + hours + " hours " + minutes + " minutes " + seconds +" seconds");
 }
}
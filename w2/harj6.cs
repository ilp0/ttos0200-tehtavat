using System;

public class harj6 {
 public static void Main(string[] args) {
     float price = 1.595f, perKM = 7.02f;
     System.Console.WriteLine("input km driven >");
    int distance = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Gasoline usage was " + ((distance / 100) * perKM) + "L price of trip was " + (((distance / 100) * perKM) * price) + "€");
 }
}
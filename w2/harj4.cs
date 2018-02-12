using System;
namespace ns2_4 {
public class harj4 {
 public static void Main(string[] args) {
     Console.Write("Input age>");
     int age = int.Parse(Console.ReadLine());
     if (age < 18) Console.WriteLine("you are a little boy");
     if (age >= 18 && age <= 65) Console.WriteLine("you are an adult boy");
     if (age > 65) Console.WriteLine("you are a seinor boy");
     Console.ReadKey();
 }
}
}
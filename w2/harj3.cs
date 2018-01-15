using System;

public class harj3 {
 public static void Main(string[] args) {

    int[] numb = new int[3];
    for (int i = 0; i < 3; i++){
    Console.WriteLine("Give number " + i.ToString());
    numb[i] = int.Parse(Console.ReadLine());
    } 
    Console.WriteLine("SUM:" + (numb[0] + numb[1] + numb[2]).ToString());
    Console.WriteLine("AVERAGE:" + ((numb[0] + numb[1] + numb[2]) / 3).ToString());
    Console.ReadKey();
 }
}
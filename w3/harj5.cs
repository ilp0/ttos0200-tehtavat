using System;

public class harj5 {

public static void Main(string[] args){
     
     System.Console.WriteLine("give a #: ");
     int height = int.Parse(Console.ReadLine());
     for (int i = 0; i < height - 2; i++){
        for (int b = 0; b < height/2 - i + 5; b++){
            Console.Write(" ");
        }
        for (int a = 0; a < i*2 + 1; a++){
            System.Console.Write("*");  
        }
        System.Console.WriteLine("");
     }
     for (int i = 0; i < 2; i++){
     for (int a = 0; a < height/2 + 5; a++){
         System.Console.Write(" ");
     }
     System.Console.WriteLine("*");
     }
 }
}

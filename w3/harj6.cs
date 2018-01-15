using System;

public class harj6 {
public static void Main(string[] args){
        Random rnd = new Random();
        int gen = rnd.Next(1,101);
        int guess = 0;
        System.Console.WriteLine("Guess a number! ");
        while (guess != gen){
            guess = int.Parse(Console.ReadLine());
            if (guess > gen) System.Console.WriteLine("number is smaller");
            if (guess < gen) System.Console.WriteLine("number is bigger");
            }
        System.Console.WriteLine("congrats!");
        Console.ReadKey();
    }
}

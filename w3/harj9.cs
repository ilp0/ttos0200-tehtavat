using System;
using System.Linq;
using System.Collections.Generic;
namespace ns3_9 {
public class harj9 {
    public static void Main(string[] args){
        string[] wordbank = new string[] {"suomalainen", "hetki", "oikea", "kuulla", "tarkoittaa", "ainakin", "kaupunki", "valtio", "pyrkiä" };
        Random rnd = new Random();
        int gen = rnd.Next(0, wordbank.Length - 1); 
        string answer = wordbank[gen];
        bool win = false;
        int lives = 5;
        List<char> rightChars = new List<char>();
        List<char> answerList = new List<char>();
        answerList.AddRange(answer);
        int lettersLeft = answer.Length;
        System.Console.WriteLine("Hirsipuu. arvaa kirjaimia. viidennestä väärästä kirjaimesta joudut hirteen.");
        while (!win && lives != 0) {
            lettersLeft = answer.Length;
            char guess = Console.ReadKey().KeyChar;
            Console.Clear();
            System.Console.WriteLine();
            if(answerList.Contains(guess)){
                System.Console.WriteLine("you guessed a right char!");
                rightChars.Add(guess);
                for (int i = 0; i < answer.Length; i++){
                    if(rightChars.Contains(answerList[i])) {
                        System.Console.Write(answerList[i]);
                        lettersLeft--;
                    } else {
                        System.Console.Write("_");
                    }
                }
                if(lettersLeft == 0) win = true;
                System.Console.WriteLine();
            } else {
                System.Console.WriteLine("you guessed a wrong char! -1 lives");
                lives--;
            }
            System.Console.WriteLine("Lives left: " + lives);
            System.Console.WriteLine("-------------------------------------\n");
        }
        if (win){
            System.Console.WriteLine("YOU WIN!"); 
        } else {
            System.Console.WriteLine("YOU LOSE!");
        }
    }
}}
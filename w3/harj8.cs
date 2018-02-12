using System;
using System.Linq;
namespace ns3_8 {
public class harj8 {
    public static void Main(string[] args){
        System.Console.WriteLine("Please input a string: ");
        string word = Console.ReadLine();
        char[] charArray = word.ToCharArray();
        Array.Reverse( charArray );
        string pal = new string( charArray );
        if(pal == word) System.Console.WriteLine("it is a palindrome");
        else
        {
            System.Console.WriteLine("it is not palindrome");
        }
    }
}}
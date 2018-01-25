using System;
namespace ns{
    class TestParser{
        static void Main (string[] args){
            System.Console.WriteLine("Give 1-10 comma separated integers: ");
            string syote = Console.ReadLine();
            //ItParser a = new ItParser();
            System.Console.Write("There are " + ItParser.Count(syote) + " integers. Sum: " + ItParser.Sum(syote) + ". Average: " + ItParser.Average(syote));
            
        }
    }
}
using System;
namespace ns {
    class TestiPeti{
        static void Main (string[] args){

            while(true){
            string input = Console.ReadLine();
            ItMath ItMath = new ItMath();
            System.Console.WriteLine("input is a number: " + ItMath.OnkoLuku(input));
            }
        }
    }
}
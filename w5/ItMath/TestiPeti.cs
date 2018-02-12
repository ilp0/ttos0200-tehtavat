using System;
namespace ns_5 {
    class TestiPeti{
        static void Main (string[] args){

            System.Console.WriteLine("1 = onko luku. 2 = onko pvm");
           
            int valinta = int.Parse(Console.ReadLine());
            switch(valinta){
                case 1:
                isNum();
                break;
                case 2:
                isDate();
                break;
            }
        }

        static void isNum(){
            ItMath ItMath = new ItMath();
            while(true){
                string input = Console.ReadLine();
                System.Console.WriteLine("input is a number: " + ItMath.OnkoLuku(input));
            }
         }

         static void isDate(){
            ItMath ItMath = new ItMath();
            while(true){
                System.Console.WriteLine("Please input a date: ");
                 string input = Console.ReadLine();
                 System.Console.WriteLine("input is a date: " + ItMath.OnkoPvm(input));
                 input = "";
             }
        }
    }
}
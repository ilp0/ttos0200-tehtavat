using System;
using System.Linq;

public class harj8 {
 public static void Main(string[] args) {
     int[] ar = new int[] {1,2,33,44,55,68,77,96,100};
     for (int i = 0; i < ar.Length; i++){
         System.Console.WriteLine(ar[i]);
         if(ar[i] % 2 == 0)System.Console.WriteLine("HEP");
     }
 }
}
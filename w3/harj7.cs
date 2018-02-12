using System;
using System.Linq;
namespace ns3_7 {
public class harj7 {
    public static void Main(string[] args){
        int[] arr = new int[] {10,20,30,40,50};
        int[] arr2 = new int[] {5,15,25,35,45};

        System.Console.Write("numbers in arr1: ");
        foreach (int i in arr){
            System.Console.Write(i.ToString() + ",");
        }
        System.Console.WriteLine(" ");
        System.Console.Write("numbers in arr2: ");
        foreach (int i in arr2){
            System.Console.Write(i.ToString() + ",");
        }
        int[] combined = arr.Concat(arr2).ToArray();
        Array.Sort(combined);   
        System.Console.WriteLine();
        System.Console.WriteLine("Combined and sorted: ");
        foreach (int i in combined){
            System.Console.Write(i.ToString() + ",");
        }
    }
}}
using System;
using System.Linq;

public class harj3 {
 public static void Main(string[] args) {
        System.Console.WriteLine("give # of students: ");
        int MAX = int.Parse(Console.ReadLine());
        int[] scores = new int[MAX];
        int[] gradeCount = new int[6];
        for (int i = 0; i < MAX; i++){ 
            System.Console.WriteLine("");
            System.Console.Write("Give grade: ");
            scores[i] = int.Parse(Console.ReadLine());
            switch (scores[i]){
                case 0: 
                    gradeCount[0]++;
                    break;
                case 1: 
                    gradeCount[1]++;
                    break;
                case 2: 
                    gradeCount[2]++;
                    break;
                case 3: 
                    gradeCount[3]++;
                    break;
                case 4: 
                    gradeCount[4]++;
                    break;
                case 5: 
                    gradeCount[5]++;
                    break;
            }
        }
        for (int i = 0; i < 6; i++){
            System.Console.Write(i.ToString() + ": ");
            for (int a = 0; a < gradeCount[i]; a++) {
               System.Console.Write("*");
            }
        System.Console.WriteLine("");
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
namespace ns_7{
        class pelaajaTest {
            static void Main (string[] args) {
                List<Seura> seurat = new List<Seura>();
                for (int i = 0; i < 15; i++){
                   seurat.Add(new Seura() {name = ("seura" + i), city = ("city" + i)});
                   for (int a = 0; a < 25; a++){
                       seurat[i].players.Add(new Pelaaja() {f_name = "p_fname" + a, l_name = "p_lname" + a, pelipaikka = "mv", hand = "R"});
                   }
               }
               while (true){
                   System.Console.WriteLine("type team id");
                   int temp = int.Parse(Console.ReadLine());
                    System.Console.WriteLine(seurat[temp].city + " " + seurat[temp].name + " " + seurat[temp].players[5].f_name);
               }

            } 
        }
}
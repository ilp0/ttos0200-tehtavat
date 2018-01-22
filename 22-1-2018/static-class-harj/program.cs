using System;

namespace StaticMembers{
    class program {
        static void Main (string[] args){

            int v = MathUtils.Power2(50);
            System.Console.WriteLine("v: " +v);

            CreateCats(99);

            System.Console.WriteLine("CatCount " + Cat.CatCount());
        }

        static void CreateCats(int num){
            for (int i = 0; i < num; i++){
                Cat cat = new Cat();
            }
        }
    }
}
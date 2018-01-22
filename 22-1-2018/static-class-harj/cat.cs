using System;

namespace StaticMembers{
    class Cat{
        private static int instances = 0;

        public Cat(){
            instances++;
        }

        public static int CatCount(){
            return instances;
        }
    }
}
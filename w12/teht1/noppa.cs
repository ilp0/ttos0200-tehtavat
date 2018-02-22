using System;
using System.Linq;
using System.Collections.Generic;

namespace ns12_1{
    public static class Noppa{
        static Random random = new Random();
        public static int Heitto() => random.Next(1, 7);
    }
}
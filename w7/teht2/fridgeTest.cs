using System;
using System.Linq;
using System.Collections.Generic;
namespace ns{
        class fridgeTest {
            static void Main (string[] args){
                fridge a = new fridge() {name = "whirlpool", model = "A554"};
                a.AddContent("maito", "valio", "22.4.2018");
            }
        }
}
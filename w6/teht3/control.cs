using System;
using System.Linq;
namespace ns{
    class control {
        static void Main (string[] args){
            Radio r = new Radio();
            r.isOn = false;
            System.Console.WriteLine("Radio is on: " + r.isOn);
            r.isOn = true;
            System.Console.WriteLine("Radio is on: " + r.isOn);
            r.volume = 2;
            r.taajuus = 2400.5f;
            System.Console.WriteLine("Volume: " + r.volume + " Taajuus: " + r.taajuus);
            
        }
    }
}

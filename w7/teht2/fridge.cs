using System;
using System.Linq;
using System.Collections.Generic;
namespace ns{
    class fridge {
        public string name {get;set;}
        public string model {get;set;}
        public List<FridgeItem> itemList = new List<FridgeItem>();
        public void AddContent(string i_name, string i_brand, string i_expirationDate){
            itemList.Add(new FridgeItem(i_name, i_brand, i_expirationDate));
        }
    }
    class FridgeItem {
        public FridgeItem(string i_name, string i_brand, string i_expirationDate) {
            name = i_name;
            brand = i_brand;
            expirationDate = i_expirationDate;
            System.Console.WriteLine("Added new fridge item: " + name + " Model: " + brand + " Expiration Date: " + expirationDate);
        }
        public string name;
        public string brand;
        public string expirationDate;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
namespace ns8_1{
    public class Customer {
        public string Name {get;set;}
        public List<Order> Orders = new List<Order>();
        public void AddOrder(int i_ID, string i_Date){
            Orders.Add(new Order() {ID = i_ID, Date = i_Date});
        }
    }

    public class Order{
        public int ID{get;set;}
        public string Date {get;set;}
        public List<OrderItem> OrderItems = new List<OrderItem>();
        public void AddItem(string n, int c){
            OrderItems.Add(new OrderItem() {Name = n, Count = c});
        }
    }
    public class OrderItem{
        public string Name {get; set;}
        public int Count {get;set;}
    }
}

using CafeteriaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaApp.Services
{
    public class OrderManager
    {
        private Dictionary<int, MenuItem> menu = new Dictionary<int, MenuItem>();
        private List<Order> orders = new List<Order>();
        private int nextOrderId = 1;
        public OrderManager() 
        { 
            menu.Add(1, new MenuItem(1, "Coffee", 2.5));
            menu.Add(2, new MenuItem(2, "Sandwich", 4.0));
            menu.Add(3, new MenuItem(3, "Pasta", 6.0));
            menu.Add(4, new MenuItem(4, "Juice", 3.0));
            menu.Add(5, new MenuItem(5, "Salad", 3.5));
        }

        public List<MenuItem> ShowMenu()
        {
            return menu.Values.ToList();
        }

        public bool PlaceOrder(int itemId, string name)
        {
            if(!menu.ContainsKey(itemId)) { return false; }

            MenuItem item = menu[itemId];

            Order order = new Order(
                nextOrderId++,
                name
                );

            order.items.Add(menu[itemId]);

            order.CalcuateTotal();

            orders.Add(order);
            return true;
        }

        public Order SearchOrder(int id)
        {
            return orders.FirstOrDefault(o => o.OrderId == id);
        }
        public bool CancelOrder(int id)
        {
            Order order = SearchOrder(id);
            if (order != null)
            {
                orders.Remove(order);
                return true;
            }
            return false;
        }

        // helpers for testing 
        public void AddOrderForTest(string name, List<int> itemids)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (int id in itemids) {
                if (menu.ContainsKey(id)) {
                    items.Add(menu[id]);
                }
            }

            if (items.Count == 0) return;

            Order order = new Order(
                nextOrderId++,
                name
                );
            orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}
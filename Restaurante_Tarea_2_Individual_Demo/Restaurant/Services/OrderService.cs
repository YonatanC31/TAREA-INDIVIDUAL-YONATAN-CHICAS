using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    public class OrderService
    {
        public List<MenuItem> MenuItems { get; private set; }

        public OrderService()
        {
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem("Hamburguesa", 5.50m),
                new MenuItem("Tacos", 4.50m),
                new MenuItem("Burrito", 5.00m),
                new MenuItem("Coca-Cola", 0.75m),
                new MenuItem("Pepsi", 0.75m)
            };
        }

        public Order CreateOrder(Dictionary<string, int> itemsQuantities)
        {
            Order order = new Order();

            foreach (var itemQuantity in itemsQuantities)
            {
                var menuItem = MenuItems.Find(m => m.Name == itemQuantity.Key);
                if (menuItem != null)
                {
                    order.AddItem(menuItem, itemQuantity.Value);
                }
            }

            return order;
        }
    }
}

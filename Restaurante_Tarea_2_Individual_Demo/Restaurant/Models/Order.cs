using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Order
    {
        public Dictionary<MenuItem, int> Items { get; private set; }

        public Order()
        {
            Items = new Dictionary<MenuItem, int>();
        }

        public void AddItem(MenuItem item, int quantity)
        {
            if (Items.ContainsKey(item))
            {
                Items[item] += quantity;
            }
            else
            {
                Items[item] = quantity;
            }
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.Key.Price * i.Value);
        }
    }
}

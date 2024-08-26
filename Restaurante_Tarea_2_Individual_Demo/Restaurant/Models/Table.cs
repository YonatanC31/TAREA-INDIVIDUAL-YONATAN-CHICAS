using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Table
    {
        public int TableNumber { get; set; }
        public bool IsSelected { get; set; }

        public Table(int tableNumber)
        {
            TableNumber = tableNumber;
            IsSelected = false;
        }
    }
}

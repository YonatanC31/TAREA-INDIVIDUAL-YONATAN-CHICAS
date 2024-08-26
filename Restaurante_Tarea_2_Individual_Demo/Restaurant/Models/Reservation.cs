using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    namespace Restaurante_Tarea_2_Individual.models
    {
        public class Reservation
        {
            public List<int> SelectedTables { get; private set; }
            public DateTime ReservationDate { get; set; }

            public Reservation()
            {
                SelectedTables = new List<int>();
            }

            public void AddTable(int tableNumber)
            {
                if (!SelectedTables.Contains(tableNumber))
                {
                    SelectedTables.Add(tableNumber);
                }
            }

            public void RemoveTable(int tableNumber)
            {
                if (SelectedTables.Contains(tableNumber))
                {
                    SelectedTables.Remove(tableNumber);
                }
            }

            public string GetSelectedTables()
            {
                if (SelectedTables.Count == 0)
                {
                    return "No se han seleccionado mesas.";
                }
                return string.Join(", ", SelectedTables);
            }
        }
    }
}

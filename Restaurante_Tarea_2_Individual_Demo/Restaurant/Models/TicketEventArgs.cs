using System;
using System.Collections.Generic;

namespace Restaurant.Models
{
    public class TicketEventArgs : EventArgs
    {
        public string MesaSeleccionada { get; }
        public Dictionary<string, int> Items { get; }
        public decimal Total { get; }

        public TicketEventArgs(string mesaSeleccionada, Dictionary<string, int> items, decimal total)
        {
            MesaSeleccionada = mesaSeleccionada;
            Items = items;
            Total = total;
        }
    }
}

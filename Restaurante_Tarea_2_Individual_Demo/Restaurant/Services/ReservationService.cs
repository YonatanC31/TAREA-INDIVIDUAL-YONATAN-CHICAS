using Restaurant.Models;
using Restaurant.Models.Restaurante_Tarea_2_Individual.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Services
{
    public class ReservationService
    {
        private Reservation reservation;

        public ReservationService()
        {
            reservation = new Reservation();
        }

       
        public void SelectTable(int tableNumber)
        {
            reservation.AddTable(tableNumber);
        }

        
        public void DeselectTable(int tableNumber)
        {
            reservation.RemoveTable(tableNumber);
        }

        
        public string GetSelectedTables()
        {
            return reservation.GetSelectedTables();
        }

        public void ValidateSelection()
        {
            if (reservation.SelectedTables.Count == 0)
            {
                throw new InvalidOperationException("Debe seleccionar al menos una mesa para continuar con la reserva.");
            }
        }

        
        public DateTime GetReservationDate()
        {
            return reservation.ReservationDate;
        }

        
        public void SetReservationDate(DateTime date)
        {
            reservation.ReservationDate = date;
        }
    }
}
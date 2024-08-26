using System;
using System.Globalization;
using System.Windows.Forms;

namespace Restaurante_Tarea_2_Individual.UI
{
    public partial class Reservationform : Form
    {
        public Reservationform()
        {
            InitializeComponent();
        }

        
        /// <param name="selectedTables">A comma-separated string of selected table numbers.</param>
        public void SetSelectedTables(string selectedTables)
        {
            if (string.IsNullOrEmpty(selectedTables))
            {
                MessageBox.Show("No se han seleccionado mesas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MesasTextBox.Text = selectedTables;
        }

        private void ContinuarReservationButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(MesasTextBox.Text))
                {
                    throw new InvalidOperationException("Debe seleccionar al menos una mesa para continuar con la reserva.");
                }

                
                DateTime fechaSeleccionada = FechaseleccionadadateTimePicker.Value;
                if (fechaSeleccionada < DateTime.Today)
                {
                    throw new InvalidOperationException("La fecha de la reserva no puede ser anterior a la fecha actual.");
                }

                string mesasSeleccionadas = MesasTextBox.Text;
                string fechaFormateada = fechaSeleccionada.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                string mensajeConfirmacion = $"Reserva confirmada para el {fechaFormateada}.\nMesas seleccionadas: {mesasSeleccionadas}";

                
                MostrarConfirmacion(mensajeConfirmacion);
            }
            catch (InvalidOperationException ex)
            {
                
                MessageBox.Show(ex.Message, "Error en la Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Ha ocurrido un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Displays the confirmation message in a MessageBox.
        /// </summary>
        /// <param name="mensajeConfirmacion">The confirmation message to display.</param>
        private void MostrarConfirmacion(string mensajeConfirmacion)
        {
            MessageBox.Show(mensajeConfirmacion, "Reserva Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

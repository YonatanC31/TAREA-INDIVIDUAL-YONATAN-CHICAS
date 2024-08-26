using Restaurant.Services;
using Restaurant.Models;
using System;
using System.Windows.Forms;

namespace Restaurante_Tarea_2_Individual.UI
{
    public partial class MesasReservationForm : Form
    {
        private ReservationService reservationService;
        private Form activeForm = null;

        public MesasReservationForm()
        {
            InitializeComponent();
            reservationService = new ReservationService();

            mesa1.CheckedChanged += Mesa_CheckedChanged;
            mesa2.CheckedChanged += Mesa_CheckedChanged;
            mesa3.CheckedChanged += Mesa_CheckedChanged;
            mesa4.CheckedChanged += Mesa_CheckedChanged;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            reservationpanel.Controls.Add(childForm);
            reservationpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Mesa_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            int tableNumber = int.Parse(checkBox.Name.Replace("mesa",""));

            if (checkBox.Checked)
            {
                reservationService.SelectTable(tableNumber);
            }
            else
            {
                reservationService.DeselectTable(tableNumber);
            }
        }

        private void ContinuarReservationButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                reservationService.ValidateSelection();

                
                Reservationform reservationForm = new Reservationform();

                
                string mesasSeleccionadas = reservationService.GetSelectedTables();
                reservationForm.SetSelectedTables(mesasSeleccionadas);

                
                openChildForm(reservationForm);
            }
            catch (InvalidOperationException ex)
            {
                
                MessageBox.Show(ex.Message, "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

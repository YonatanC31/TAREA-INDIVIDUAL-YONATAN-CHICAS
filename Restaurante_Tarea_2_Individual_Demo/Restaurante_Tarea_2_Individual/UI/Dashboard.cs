using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_Tarea_2_Individual.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        bool menuexpand = false;
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menutransition_Tick(object sender, EventArgs e)
        {
            if (menuexpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 120)
                {
                    menutransition.Stop();
                    menuexpand = true;
                }
            }
            else menuContainer.Height -= 10;
            {
                if (menuContainer.Height <= 35)
                {
                    menutransition.Stop();
                    menuexpand = false;

                }
            }

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menutransition.Start();
        }




        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PrincipalContainer.Controls.Add(childForm);
            PrincipalContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void NuevaordenButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OrdenForm());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void ReservarButton_Click(object sender, EventArgs e)
        {
            openChildForm (new MesasReservationForm());
        }
    }
}

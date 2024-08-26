using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Restaurante_Tarea_2_Individual.UI
{
    public partial class Informationform : Form
    {
        public Informationform()
        {
            InitializeComponent();

            //Evento personalizado para RecursosButton
            RecursosButton.Click += (sender, e) => OpenLink("https://www.canva.com/design/DAGO3kOkyC0/rzIwCNU5u1yAVr4lcKJgCQ/edit?utm_content=DAGO3kOkyC0&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FacbeookpictureBox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.facebook.com/LaChozaDDV");
        }

        private void InstagrampictureBox_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.instagram.com/lachozaddv?utm_source=ig_web_button_share_sheet&igsh=ZDNlZDc0MzIxNw==");
        }
    }
}

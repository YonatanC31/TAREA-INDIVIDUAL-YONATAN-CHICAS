using Restaurant.Models;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante_Tarea_2_Individual.UI
{
    public partial class OrdenForm : Form
    {
        private readonly OrderService _orderService;

        public OrdenForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            button1.Click += new EventHandler(IngresarOrden_Click); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void IngresarOrden_Click(object sender, EventArgs e)
        {
            string mesaSeleccionada = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemsQuantities = new Dictionary<string, int>
            {
                { "Hamburguesa", (int)HamburgesanumericUpDown.Value },
                { "Tacos", (int)TacosnumericUpDown.Value },
                { "Burrito", (int)BurritonumericUpDown3.Value },
                { "Coca-Cola", (int)CocacolanumericUpDown.Value },
                { "Pepsi", (int)PepsinumericUpDown.Value }
            };

            if (itemsQuantities.Values.All(quantity => quantity == 0))
            {
                MessageBox.Show("Por favor, ingrese al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Order order = _orderService.CreateOrder(itemsQuantities);
            decimal totalOrden = order.CalculateTotal();

            string mensajeOrden = $"Mesa: {mesaSeleccionada}\n\n";
            foreach (var item in order.Items)
            {
                mensajeOrden += $"{item.Key.Name}: {item.Value} x ${item.Key.Price} = ${item.Key.Price * item.Value}\n";
            }
            mensajeOrden += $"\nTotal: ${totalOrden}";


            DialogResult resultado = MessageBox.Show($"¿Confirmar la siguiente orden?\n\n{mensajeOrden}", "Confirmar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("¡Orden ingresada con éxito!", "Orden Ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFormulario();
            }
        }

        private void ResetFormulario()
        {
            HamburgesanumericUpDown.Value = 0;
            TacosnumericUpDown.Value = 0;
            BurritonumericUpDown3.Value = 0;
            PepsinumericUpDown.Value = 0;
            CocacolanumericUpDown.Value = 0;
            comboBox1.SelectedIndex = -1;
        }
    }
}

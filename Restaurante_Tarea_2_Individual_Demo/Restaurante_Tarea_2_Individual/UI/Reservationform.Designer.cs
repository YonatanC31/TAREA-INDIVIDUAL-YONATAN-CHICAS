namespace Restaurante_Tarea_2_Individual.UI
{
    partial class Reservationform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ContinuarReservationButton = new Button();
            ReservationTitlle = new Label();
            mesasSeleccionadaslabel = new Label();
            Fechalabel = new Label();
            FechaseleccionadadateTimePicker = new DateTimePicker();
            MesasTextBox = new TextBox();
            SuspendLayout();
            // 
            // ContinuarReservationButton
            // 
            ContinuarReservationButton.BackColor = SystemColors.ActiveCaptionText;
            ContinuarReservationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ContinuarReservationButton.ForeColor = Color.White;
            ContinuarReservationButton.Location = new Point(234, 301);
            ContinuarReservationButton.Name = "ContinuarReservationButton";
            ContinuarReservationButton.Size = new Size(162, 30);
            ContinuarReservationButton.TabIndex = 71;
            ContinuarReservationButton.Text = "RESERVAR";
            ContinuarReservationButton.UseVisualStyleBackColor = false;
            ContinuarReservationButton.Click += ContinuarReservationButton_Click;
            // 
            // ReservationTitlle
            // 
            ReservationTitlle.Anchor = AnchorStyles.Top;
            ReservationTitlle.AutoSize = true;
            ReservationTitlle.BackColor = Color.Transparent;
            ReservationTitlle.BorderStyle = BorderStyle.FixedSingle;
            ReservationTitlle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ReservationTitlle.ForeColor = Color.White;
            ReservationTitlle.Location = new Point(189, 9);
            ReservationTitlle.Name = "ReservationTitlle";
            ReservationTitlle.Size = new Size(230, 39);
            ReservationTitlle.TabIndex = 64;
            ReservationTitlle.Text = "RESERVACIONES";
            // 
            // mesasSeleccionadaslabel
            // 
            mesasSeleccionadaslabel.AutoSize = true;
            mesasSeleccionadaslabel.BackColor = Color.Transparent;
            mesasSeleccionadaslabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesasSeleccionadaslabel.ForeColor = Color.White;
            mesasSeleccionadaslabel.Location = new Point(72, 76);
            mesasSeleccionadaslabel.Name = "mesasSeleccionadaslabel";
            mesasSeleccionadaslabel.Size = new Size(496, 31);
            mesasSeleccionadaslabel.TabIndex = 72;
            mesasSeleccionadaslabel.Text = "Los numeros de las mesas seleccionadas son: ";
            // 
            // Fechalabel
            // 
            Fechalabel.AutoSize = true;
            Fechalabel.BackColor = Color.Transparent;
            Fechalabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fechalabel.ForeColor = Color.White;
            Fechalabel.Location = new Point(130, 192);
            Fechalabel.Name = "Fechalabel";
            Fechalabel.Size = new Size(361, 31);
            Fechalabel.TabIndex = 73;
            Fechalabel.Text = "Seleccione la fecha de su reserva";
            // 
            // FechaseleccionadadateTimePicker
            // 
            FechaseleccionadadateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaseleccionadadateTimePicker.Location = new Point(102, 236);
            FechaseleccionadadateTimePicker.Name = "FechaseleccionadadateTimePicker";
            FechaseleccionadadateTimePicker.Size = new Size(407, 34);
            FechaseleccionadadateTimePicker.TabIndex = 74;
            // 
            // MesasTextBox
            // 
            MesasTextBox.Location = new Point(143, 128);
            MesasTextBox.Name = "MesasTextBox";
            MesasTextBox.Size = new Size(315, 27);
            MesasTextBox.TabIndex = 75;
            // 
            // Reservationform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(625, 343);
            Controls.Add(MesasTextBox);
            Controls.Add(FechaseleccionadadateTimePicker);
            Controls.Add(Fechalabel);
            Controls.Add(mesasSeleccionadaslabel);
            Controls.Add(ContinuarReservationButton);
            Controls.Add(ReservationTitlle);
            Name = "Reservationform";
            Text = "Reservationform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ContinuarReservationButton;
        private Label ReservationTitlle;
        private Label mesasSeleccionadaslabel;
        private Label Fechalabel;
        private DateTimePicker FechaseleccionadadateTimePicker;
        private TextBox MesasTextBox;
    }
}
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
            ContinuarReservationButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinuarReservationButton.ForeColor = Color.White;
            ContinuarReservationButton.Location = new Point(235, 355);
            ContinuarReservationButton.Name = "ContinuarReservationButton";
            ContinuarReservationButton.Size = new Size(259, 51);
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
            ReservationTitlle.Location = new Point(264, 48);
            ReservationTitlle.Name = "ReservationTitlle";
            ReservationTitlle.Size = new Size(230, 39);
            ReservationTitlle.TabIndex = 64;
            ReservationTitlle.Text = "RESERVACIONES";
            // 
            // mesasSeleccionadaslabel
            // 
            mesasSeleccionadaslabel.AutoSize = true;
            mesasSeleccionadaslabel.BackColor = Color.Transparent;
            mesasSeleccionadaslabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesasSeleccionadaslabel.ForeColor = Color.White;
            mesasSeleccionadaslabel.Location = new Point(50, 108);
            mesasSeleccionadaslabel.Name = "mesasSeleccionadaslabel";
            mesasSeleccionadaslabel.Size = new Size(648, 41);
            mesasSeleccionadaslabel.TabIndex = 72;
            mesasSeleccionadaslabel.Text = "Los numeros de las mesas seleccionadas son: ";
            // 
            // Fechalabel
            // 
            Fechalabel.AutoSize = true;
            Fechalabel.BackColor = Color.Transparent;
            Fechalabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fechalabel.ForeColor = Color.White;
            Fechalabel.Location = new Point(104, 223);
            Fechalabel.Name = "Fechalabel";
            Fechalabel.Size = new Size(535, 41);
            Fechalabel.TabIndex = 73;
            Fechalabel.Text = "Seleccione la fecha de la reservacion:";
            // 
            // FechaseleccionadadateTimePicker
            // 
            FechaseleccionadadateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaseleccionadadateTimePicker.Location = new Point(157, 294);
            FechaseleccionadadateTimePicker.Name = "FechaseleccionadadateTimePicker";
            FechaseleccionadadateTimePicker.Size = new Size(401, 34);
            FechaseleccionadadateTimePicker.TabIndex = 74;
            // 
            // MesasTextBox
            // 
            MesasTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MesasTextBox.Location = new Point(254, 152);
            MesasTextBox.Name = "MesasTextBox";
            MesasTextBox.Size = new Size(212, 38);
            MesasTextBox.TabIndex = 75;
            // 
            // Reservationform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(755, 464);
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
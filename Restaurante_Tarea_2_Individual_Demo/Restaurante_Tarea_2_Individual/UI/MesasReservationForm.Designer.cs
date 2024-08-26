namespace Restaurante_Tarea_2_Individual.UI
{
    partial class MesasReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesasReservationForm));
            reservationpanel = new Panel();
            mesa4 = new CheckBox();
            mesa2 = new CheckBox();
            ContinuarReservationButton = new Button();
            mesa3 = new CheckBox();
            mesa1 = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            SeleccionMesasLabel = new Label();
            ReservationTitle = new Label();
            pictureBox2 = new PictureBox();
            reservationpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // reservationpanel
            // 
            reservationpanel.BackColor = Color.Transparent;
            reservationpanel.Controls.Add(mesa4);
            reservationpanel.Controls.Add(mesa2);
            reservationpanel.Controls.Add(ContinuarReservationButton);
            reservationpanel.Controls.Add(mesa3);
            reservationpanel.Controls.Add(mesa1);
            reservationpanel.Controls.Add(pictureBox4);
            reservationpanel.Controls.Add(pictureBox3);
            reservationpanel.Controls.Add(pictureBox1);
            reservationpanel.Controls.Add(SeleccionMesasLabel);
            reservationpanel.Controls.Add(ReservationTitle);
            reservationpanel.Controls.Add(pictureBox2);
            reservationpanel.Location = new Point(-7, 3);
            reservationpanel.Name = "reservationpanel";
            reservationpanel.Size = new Size(643, 390);
            reservationpanel.TabIndex = 52;
            // 
            // mesa4
            // 
            mesa4.AutoSize = true;
            mesa4.Location = new Point(425, 311);
            mesa4.Name = "mesa4";
            mesa4.Size = new Size(18, 17);
            mesa4.TabIndex = 84;
            mesa4.UseVisualStyleBackColor = true;
            // 
            // mesa2
            // 
            mesa2.AutoSize = true;
            mesa2.Location = new Point(424, 194);
            mesa2.Name = "mesa2";
            mesa2.Size = new Size(18, 17);
            mesa2.TabIndex = 83;
            mesa2.UseVisualStyleBackColor = true;
            // 
            // ContinuarReservationButton
            // 
            ContinuarReservationButton.BackColor = SystemColors.ActiveCaptionText;
            ContinuarReservationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ContinuarReservationButton.ForeColor = Color.White;
            ContinuarReservationButton.Location = new Point(242, 339);
            ContinuarReservationButton.Name = "ContinuarReservationButton";
            ContinuarReservationButton.Size = new Size(162, 30);
            ContinuarReservationButton.TabIndex = 82;
            ContinuarReservationButton.Text = "CONTINUAR";
            ContinuarReservationButton.UseVisualStyleBackColor = false;
            ContinuarReservationButton.Click += ContinuarReservationButton_Click_1;
            // 
            // mesa3
            // 
            mesa3.AutoSize = true;
            mesa3.Location = new Point(289, 311);
            mesa3.Name = "mesa3";
            mesa3.Size = new Size(18, 17);
            mesa3.TabIndex = 81;
            mesa3.UseVisualStyleBackColor = true;
            // 
            // mesa1
            // 
            mesa1.AutoSize = true;
            mesa1.Location = new Point(289, 194);
            mesa1.Name = "mesa1";
            mesa1.Size = new Size(18, 17);
            mesa1.TabIndex = 80;
            mesa1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = Properties.Resources.Logo__1_;
            pictureBox4.Location = new Point(334, 217);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 79;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.Logo__1_;
            pictureBox3.Location = new Point(198, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 78;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.Logo__1_;
            pictureBox1.Location = new Point(334, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // SeleccionMesasLabel
            // 
            SeleccionMesasLabel.AutoSize = true;
            SeleccionMesasLabel.BackColor = Color.Transparent;
            SeleccionMesasLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SeleccionMesasLabel.ForeColor = Color.White;
            SeleccionMesasLabel.Location = new Point(111, 60);
            SeleccionMesasLabel.Name = "SeleccionMesasLabel";
            SeleccionMesasLabel.Size = new Size(445, 31);
            SeleccionMesasLabel.TabIndex = 76;
            SeleccionMesasLabel.Text = "Seleecione las mesas que desea reservar:";
            // 
            // ReservationTitle
            // 
            ReservationTitle.Anchor = AnchorStyles.Top;
            ReservationTitle.AutoSize = true;
            ReservationTitle.BackColor = Color.Transparent;
            ReservationTitle.BorderStyle = BorderStyle.FixedSingle;
            ReservationTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ReservationTitle.ForeColor = Color.White;
            ReservationTitle.Location = new Point(198, 21);
            ReservationTitle.Name = "ReservationTitle";
            ReservationTitle.Size = new Size(230, 39);
            ReservationTitle.TabIndex = 75;
            ReservationTitle.Text = "RESERVACIONES";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.Logo__1_;
            pictureBox2.Location = new Point(198, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // MesasReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(635, 381);
            Controls.Add(reservationpanel);
            Name = "MesasReservationForm";
            Text = "MesasReservationForm";
            reservationpanel.ResumeLayout(false);
            reservationpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel reservationpanel;
        private CheckBox mesa4;
        private CheckBox mesa2;
        private Button ContinuarReservationButton;
        private CheckBox mesa3;
        private CheckBox mesa1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label SeleccionMesasLabel;
        private Label ReservationTitle;
        private PictureBox pictureBox2;
    }
}
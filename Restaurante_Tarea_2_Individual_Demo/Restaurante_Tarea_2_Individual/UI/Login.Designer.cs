namespace Restaurante_Tarea_2_Individual.UI
{
    partial class Login
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
            Logo = new PictureBox();
            TitleLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = Properties.Resources.Logo__1_;
            Logo.ErrorImage = Properties.Resources.Logo__1_;
            Logo.Location = new Point(238, 51);
            Logo.Name = "Logo";
            Logo.Size = new Size(497, 443);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(136, 114);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(708, 38);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "BIENVENIDO AL SISTEMA DE ADMINISTRACION DE:\r\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(295, 500);
            button1.Name = "button1";
            button1.Size = new Size(225, 47);
            button1.TabIndex = 2;
            button1.Text = "INICIAR SESION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(537, 500);
            button2.Name = "button2";
            button2.Size = new Size(130, 47);
            button2.TabIndex = 3;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(978, 586);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TitleLabel);
            Controls.Add(Logo);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label TitleLabel;
        private Button button1;
        private Button button2;
    }
}
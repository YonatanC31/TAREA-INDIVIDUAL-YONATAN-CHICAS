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
            PanelLogin = new Panel();
            ExitButton = new Button();
            IniciodesesionButton = new Button();
            TitleLabel = new Label();
            Logo = new PictureBox();
            PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // PanelLogin
            // 
            PanelLogin.BackColor = Color.Transparent;
            PanelLogin.Controls.Add(ExitButton);
            PanelLogin.Controls.Add(IniciodesesionButton);
            PanelLogin.Controls.Add(TitleLabel);
            PanelLogin.Controls.Add(Logo);
            PanelLogin.Location = new Point(0, -3);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(938, 586);
            PanelLogin.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Location = new Point(499, 474);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(145, 41);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "SALIR";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // IniciodesesionButton
            // 
            IniciodesesionButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IniciodesesionButton.ForeColor = SystemColors.ActiveCaptionText;
            IniciodesesionButton.Location = new Point(209, 474);
            IniciodesesionButton.Name = "IniciodesesionButton";
            IniciodesesionButton.Size = new Size(231, 41);
            IniciodesesionButton.TabIndex = 7;
            IniciodesesionButton.Text = "INICIAR SESION";
            IniciodesesionButton.UseVisualStyleBackColor = true;
            IniciodesesionButton.Click += IniciodesesionButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(115, 106);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(708, 38);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "BIENVENIDO AL SISTEMA DE ADMINISTRACION DE:\r\n";
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = Properties.Resources.Logo__1_;
            Logo.ErrorImage = Properties.Resources.Logo__1_;
            Logo.Location = new Point(172, 15);
            Logo.Name = "Logo";
            Logo.Size = new Size(497, 443);
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(937, 583);
            Controls.Add(PanelLogin);
            Name = "Login";
            Text = "Login";
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLogin;
        private Button ExitButton;
        private Button IniciodesesionButton;
        private Label TitleLabel;
        private PictureBox Logo;
    }
}
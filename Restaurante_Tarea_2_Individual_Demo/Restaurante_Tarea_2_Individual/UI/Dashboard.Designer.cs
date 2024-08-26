namespace Restaurante_Tarea_2_Individual.UI
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            Home = new Button();
            menuContainer = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            ReservarButton = new Button();
            NuevaordenButton = new Button();
            pictureBox2 = new PictureBox();
            MenuButton = new Button();
            panel4 = new Panel();
            exitbutton = new Button();
            pictureBox3 = new PictureBox();
            Logo = new PictureBox();
            button8 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menutransition = new System.Windows.Forms.Timer(components);
            PrincipalContainer = new Panel();
            ImagenHome = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            PrincipalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(menuContainer);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(button8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 469);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = Properties.Resources.home;
            pictureBox6.Location = new Point(12, 166);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // Home
            // 
            Home.BackColor = Color.Black;
            Home.FlatAppearance.BorderSize = 0;
            Home.FlatStyle = FlatStyle.Flat;
            Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.ForeColor = SystemColors.Control;
            Home.ImageAlign = ContentAlignment.MiddleRight;
            Home.Location = new Point(-23, 159);
            Home.Margin = new Padding(0);
            Home.Name = "Home";
            Home.Size = new Size(220, 38);
            Home.TabIndex = 7;
            Home.Text = "Inicio";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(23, 24, 30);
            menuContainer.Controls.Add(pictureBox5);
            menuContainer.Controls.Add(pictureBox4);
            menuContainer.Controls.Add(ReservarButton);
            menuContainer.Controls.Add(NuevaordenButton);
            menuContainer.Controls.Add(pictureBox2);
            menuContainer.Controls.Add(MenuButton);
            menuContainer.Location = new Point(3, 209);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(180, 38);
            menuContainer.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 87);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 47);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // ReservarButton
            // 
            ReservarButton.BackColor = Color.FromArgb(23, 24, 30);
            ReservarButton.FlatAppearance.BorderSize = 0;
            ReservarButton.FlatStyle = FlatStyle.Flat;
            ReservarButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservarButton.ForeColor = SystemColors.Control;
            ReservarButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReservarButton.Location = new Point(28, 82);
            ReservarButton.Margin = new Padding(0);
            ReservarButton.Name = "ReservarButton";
            ReservarButton.Size = new Size(150, 38);
            ReservarButton.TabIndex = 8;
            ReservarButton.Text = "Reservar Mesa";
            ReservarButton.UseVisualStyleBackColor = false;
            ReservarButton.Click += ReservarButton_Click;
            // 
            // NuevaordenButton
            // 
            NuevaordenButton.BackColor = Color.FromArgb(23, 24, 30);
            NuevaordenButton.FlatAppearance.BorderSize = 0;
            NuevaordenButton.FlatStyle = FlatStyle.Flat;
            NuevaordenButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevaordenButton.ForeColor = SystemColors.Control;
            NuevaordenButton.ImageAlign = ContentAlignment.MiddleLeft;
            NuevaordenButton.Location = new Point(28, 42);
            NuevaordenButton.Margin = new Padding(0);
            NuevaordenButton.Name = "NuevaordenButton";
            NuevaordenButton.Size = new Size(150, 38);
            NuevaordenButton.TabIndex = 7;
            NuevaordenButton.Text = "Nueva Orden";
            NuevaordenButton.UseVisualStyleBackColor = false;
            NuevaordenButton.Click += NuevaordenButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.Black;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuButton.ForeColor = SystemColors.Control;
            MenuButton.ImageAlign = ContentAlignment.MiddleRight;
            MenuButton.Location = new Point(-2, 0);
            MenuButton.Margin = new Padding(0);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(220, 38);
            MenuButton.TabIndex = 6;
            MenuButton.Text = "Menu principal";
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(exitbutton);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(3, 416);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 45);
            panel4.TabIndex = 4;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Black;
            exitbutton.FlatAppearance.BorderSize = 0;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.ForeColor = SystemColors.Control;
            exitbutton.Location = new Point(40, 7);
            exitbutton.Margin = new Padding(0);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(125, 33);
            exitbutton.TabIndex = 5;
            exitbutton.Text = "Cerrar Sesion";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.ErrorImage = null;
            Logo.Image = Properties.Resources.Logo__1_;
            Logo.InitialImage = Properties.Resources.Logo__1_;
            Logo.Location = new Point(0, -18);
            Logo.Name = "Logo";
            Logo.Size = new Size(174, 168);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.Control;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(29, 302);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(0, 0);
            button8.TabIndex = 6;
            button8.Text = "Menu principal";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 41);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(487, 23);
            label1.TabIndex = 0;
            label1.Text = "BIENVEIDO AL RESTAURANTE  |  LA CHOZA DE DON VISITA";
            // 
            // menutransition
            // 
            menutransition.Interval = 20;
            menutransition.Tick += menutransition_Tick;
            // 
            // PrincipalContainer
            // 
            PrincipalContainer.Controls.Add(ImagenHome);
            PrincipalContainer.Dock = DockStyle.Fill;
            PrincipalContainer.Location = new Point(179, 41);
            PrincipalContainer.Name = "PrincipalContainer";
            PrincipalContainer.Size = new Size(630, 428);
            PrincipalContainer.TabIndex = 2;
            // 
            // ImagenHome
            // 
            ImagenHome.Image = (Image)resources.GetObject("ImagenHome.Image");
            ImagenHome.Location = new Point(0, 0);
            ImagenHome.Name = "ImagenHome";
            ImagenHome.Size = new Size(630, 434);
            ImagenHome.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenHome.TabIndex = 0;
            ImagenHome.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 469);
            Controls.Add(PrincipalContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PrincipalContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImagenHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Button exitbutton;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer menutransition;
        private Button InformacionButton;
        private Button button8;
        private Panel menuContainer;
        private PictureBox pictureBox2;
        private Button MenuButton;
        private Button NuevaordenButton;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button ReservarButton;
        private PictureBox pictureBox6;
        private Button Home;
        private Panel PrincipalContainer;
        private PictureBox ImagenHome;
    }
}
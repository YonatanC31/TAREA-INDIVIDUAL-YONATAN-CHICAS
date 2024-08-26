namespace Restaurante_Tarea_2_Individual.UI
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            ImagenHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImagenHome).BeginInit();
            SuspendLayout();
            // 
            // ImagenHome
            // 
            ImagenHome.Image = (Image)resources.GetObject("ImagenHome.Image");
            ImagenHome.Location = new Point(-13, -8);
            ImagenHome.Name = "ImagenHome";
            ImagenHome.Size = new Size(661, 446);
            ImagenHome.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenHome.TabIndex = 1;
            ImagenHome.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 432);
            Controls.Add(ImagenHome);
            Name = "HomeForm";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)ImagenHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImagenHome;
    }
}
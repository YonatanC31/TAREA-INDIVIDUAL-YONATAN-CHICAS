namespace Restaurante_Tarea_2_Individual.UI
{
    partial class Informationform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informationform));
            Tittlelabel = new Label();
            InformacionLabel = new Label();
            RecursosButton = new Button();
            FacbeookpictureBox = new PictureBox();
            InstagrampictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FacbeookpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InstagrampictureBox).BeginInit();
            SuspendLayout();
            // 
            // Tittlelabel
            // 
            Tittlelabel.Anchor = AnchorStyles.Top;
            Tittlelabel.AutoSize = true;
            Tittlelabel.BackColor = Color.Transparent;
            Tittlelabel.BorderStyle = BorderStyle.FixedSingle;
            Tittlelabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Tittlelabel.ForeColor = Color.White;
            Tittlelabel.Location = new Point(241, 106);
            Tittlelabel.Name = "Tittlelabel";
            Tittlelabel.Size = new Size(352, 39);
            Tittlelabel.TabIndex = 42;
            Tittlelabel.Text = "LA CHOZA DE DON VISITA";
            // 
            // InformacionLabel
            // 
            InformacionLabel.AutoSize = true;
            InformacionLabel.BackColor = Color.Transparent;
            InformacionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InformacionLabel.ForeColor = SystemColors.ControlLightLight;
            InformacionLabel.Location = new Point(47, 178);
            InformacionLabel.Name = "InformacionLabel";
            InformacionLabel.Size = new Size(738, 168);
            InformacionLabel.TabIndex = 43;
            InformacionLabel.Text = resources.GetString("InformacionLabel.Text");
            InformacionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RecursosButton
            // 
            RecursosButton.BackColor = SystemColors.ActiveCaptionText;
            RecursosButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            RecursosButton.ForeColor = Color.White;
            RecursosButton.Location = new Point(314, 445);
            RecursosButton.Name = "RecursosButton";
            RecursosButton.Size = new Size(199, 40);
            RecursosButton.TabIndex = 44;
            RecursosButton.Text = "RECURSOS USADOS";
            RecursosButton.UseVisualStyleBackColor = false;
            // 
            // FacbeookpictureBox
            // 
            FacbeookpictureBox.BackColor = Color.Transparent;
            FacbeookpictureBox.ErrorImage = null;
            FacbeookpictureBox.Image = (Image)resources.GetObject("FacbeookpictureBox.Image");
            FacbeookpictureBox.InitialImage = Properties.Resources.Logo__1_;
            FacbeookpictureBox.Location = new Point(314, 349);
            FacbeookpictureBox.Name = "FacbeookpictureBox";
            FacbeookpictureBox.Size = new Size(83, 81);
            FacbeookpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FacbeookpictureBox.TabIndex = 45;
            FacbeookpictureBox.TabStop = false;
            FacbeookpictureBox.Click += FacbeookpictureBox_Click;
            // 
            // InstagrampictureBox
            // 
            InstagrampictureBox.BackColor = Color.Transparent;
            InstagrampictureBox.ErrorImage = null;
            InstagrampictureBox.Image = (Image)resources.GetObject("InstagrampictureBox.Image");
            InstagrampictureBox.InitialImage = Properties.Resources.Logo__1_;
            InstagrampictureBox.Location = new Point(430, 349);
            InstagrampictureBox.Name = "InstagrampictureBox";
            InstagrampictureBox.Size = new Size(83, 81);
            InstagrampictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            InstagrampictureBox.TabIndex = 46;
            InstagrampictureBox.TabStop = false;
            InstagrampictureBox.Click += InstagrampictureBox_Click;
            // 
            // Informationform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backgorund;
            ClientSize = new Size(829, 555);
            Controls.Add(InstagrampictureBox);
            Controls.Add(FacbeookpictureBox);
            Controls.Add(RecursosButton);
            Controls.Add(InformacionLabel);
            Controls.Add(Tittlelabel);
            Name = "Informationform";
            Text = "Informationform";
            ((System.ComponentModel.ISupportInitialize)FacbeookpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InstagrampictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tittlelabel;
        private Label InformacionLabel;
        private Button RecursosButton;
        private PictureBox FacbeookpictureBox;
        private PictureBox InstagrampictureBox;
    }
}
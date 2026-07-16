namespace Vitalis
{
    partial class frmInicio
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
            lblVitalisInicio = new Label();
            pcbLogoInicio = new PictureBox();
            label1 = new Label();
            lblMensajeBienvenidaInicio = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLogoInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVitalisInicio
            // 
            lblVitalisInicio.Anchor = AnchorStyles.None;
            lblVitalisInicio.AutoSize = true;
            lblVitalisInicio.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitalisInicio.ForeColor = Color.FromArgb(23, 147, 209);
            lblVitalisInicio.Location = new Point(724, 601);
            lblVitalisInicio.Name = "lblVitalisInicio";
            lblVitalisInicio.Size = new Size(258, 68);
            lblVitalisInicio.TabIndex = 4;
            lblVitalisInicio.Text = "V i t a l i s";
            // 
            // pcbLogoInicio
            // 
            pcbLogoInicio.Anchor = AnchorStyles.None;
            pcbLogoInicio.Image = Properties.Resources.Logo_VerFondo_blanco;
            pcbLogoInicio.Location = new Point(682, 264);
            pcbLogoInicio.Name = "pcbLogoInicio";
            pcbLogoInicio.Size = new Size(350, 350);
            pcbLogoInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogoInicio.TabIndex = 3;
            pcbLogoInicio.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(657, 667);
            label1.Name = "label1";
            label1.Size = new Size(393, 32);
            label1.TabIndex = 5;
            label1.Text = "Gestion de consultas y pacientes.";
            // 
            // lblMensajeBienvenidaInicio
            // 
            lblMensajeBienvenidaInicio.Anchor = AnchorStyles.Bottom;
            lblMensajeBienvenidaInicio.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeBienvenidaInicio.ForeColor = Color.FromArgb(23, 147, 209);
            lblMensajeBienvenidaInicio.Location = new Point(477, 820);
            lblMensajeBienvenidaInicio.Name = "lblMensajeBienvenidaInicio";
            lblMensajeBienvenidaInicio.Size = new Size(784, 152);
            lblMensajeBienvenidaInicio.TabIndex = 6;
            lblMensajeBienvenidaInicio.Text = "Bienvenido";
            lblMensajeBienvenidaInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(58, 154, 138);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1719, 70);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(58, 154, 138);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 239, 239);
            label2.Location = new Point(39, 20);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 8;
            label2.Text = "Inicio";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(lblVitalisInicio);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(lblMensajeBienvenidaInicio);
            Controls.Add(pcbLogoInicio);
            Name = "frmInicio";
            Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)pcbLogoInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVitalisInicio;
        private PictureBox pcbLogoInicio;
        private Label label1;
        private Label lblMensajeBienvenidaInicio;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
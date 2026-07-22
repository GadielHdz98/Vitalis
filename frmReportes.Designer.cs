namespace Vitalis
{
    partial class frmReportes
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
            lblReportes = new Label();
            dgvReportes = new DataGridView();
            panel1 = new Panel();
            btnVer = new Button();
            btnGenerar = new Button();
            rbCnosultasHoy = new RadioButton();
            rbReporteRecetaMedica = new RadioButton();
            rbReportePacientesSemanales = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblReportes
            // 
            lblReportes.BackColor = Color.Transparent;
            lblReportes.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.FromArgb(23, 147, 209);
            lblReportes.Location = new Point(60, 86);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(876, 68);
            lblReportes.TabIndex = 7;
            lblReportes.Text = "Reportes";
            lblReportes.Click += lblVitalisInicio_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(104, 178);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(980, 632);
            dgvReportes.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVer);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(rbCnosultasHoy);
            panel1.Controls.Add(rbReporteRecetaMedica);
            panel1.Controls.Add(rbReportePacientesSemanales);
            panel1.Location = new Point(1116, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 470);
            panel1.TabIndex = 10;
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVer.Location = new Point(186, 375);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(183, 52);
            btnVer.TabIndex = 15;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnGenerar.Location = new Point(186, 287);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(183, 52);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // rbCnosultasHoy
            // 
            rbCnosultasHoy.AutoSize = true;
            rbCnosultasHoy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbCnosultasHoy.Location = new Point(128, 201);
            rbCnosultasHoy.Name = "rbCnosultasHoy";
            rbCnosultasHoy.Size = new Size(274, 29);
            rbCnosultasHoy.TabIndex = 14;
            rbCnosultasHoy.TabStop = true;
            rbCnosultasHoy.Text = "Reporte de consulta de hoy";
            rbCnosultasHoy.UseVisualStyleBackColor = true;
            // 
            // rbReporteRecetaMedica
            // 
            rbReporteRecetaMedica.AutoSize = true;
            rbReporteRecetaMedica.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReporteRecetaMedica.Location = new Point(128, 137);
            rbReporteRecetaMedica.Name = "rbReporteRecetaMedica";
            rbReporteRecetaMedica.Size = new Size(312, 29);
            rbReporteRecetaMedica.TabIndex = 13;
            rbReporteRecetaMedica.TabStop = true;
            rbReporteRecetaMedica.Text = "Reporte de consultas semanales";
            rbReporteRecetaMedica.UseVisualStyleBackColor = true;
            // 
            // rbReportePacientesSemanales
            // 
            rbReportePacientesSemanales.AutoSize = true;
            rbReportePacientesSemanales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReportePacientesSemanales.Location = new Point(128, 67);
            rbReportePacientesSemanales.Name = "rbReportePacientesSemanales";
            rbReportePacientesSemanales.Size = new Size(214, 29);
            rbReportePacientesSemanales.TabIndex = 12;
            rbReportePacientesSemanales.TabStop = true;
            rbReportePacientesSemanales.Text = "Consultas Mensuales";
            rbReportePacientesSemanales.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(58, 154, 138);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1703, 70);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1703, 861);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgvReportes);
            Controls.Add(lblReportes);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblReportes;
        private DataGridView dgvReportes;
        private Panel panel1;
        private RadioButton rbCnosultasHoy;
        private RadioButton rbReporteRecetaMedica;
        private RadioButton rbReportePacientesSemanales;
        private Button btnGenerar;
        private Button btnVer;
        private PictureBox pictureBox1;
    }
}
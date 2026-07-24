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
            rbReporteCantDiagnostico = new RadioButton();
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
            lblReportes.Location = new Point(69, 115);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(1001, 91);
            lblReportes.TabIndex = 7;
            lblReportes.Text = "Reportes";
            lblReportes.Click += lblVitalisInicio_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(119, 237);
            dgvReportes.Margin = new Padding(3, 4, 3, 4);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(1120, 843);
            dgvReportes.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVer);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(rbReporteCantDiagnostico);
            panel1.Controls.Add(rbReporteRecetaMedica);
            panel1.Controls.Add(rbReportePacientesSemanales);
            panel1.Location = new Point(1275, 237);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 627);
            panel1.TabIndex = 10;
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVer.Location = new Point(213, 500);
            btnVer.Margin = new Padding(3, 4, 3, 4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(209, 69);
            btnVer.TabIndex = 15;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnGenerar.Location = new Point(213, 383);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(209, 69);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // rbReporteCantDiagnostico
            // 
            rbReporteCantDiagnostico.AutoSize = true;
            rbReporteCantDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReporteCantDiagnostico.Location = new Point(95, 268);
            rbReporteCantDiagnostico.Margin = new Padding(3, 4, 3, 4);
            rbReporteCantDiagnostico.Name = "rbReporteCantDiagnostico";
            rbReporteCantDiagnostico.Size = new Size(455, 36);
            rbReporteCantDiagnostico.TabIndex = 14;
            rbReporteCantDiagnostico.TabStop = true;
            rbReporteCantDiagnostico.Text = "Reporte por cantidad de diagnostico";
            rbReporteCantDiagnostico.UseVisualStyleBackColor = true;
            rbReporteCantDiagnostico.CheckedChanged += rbReporteCantDiagnostico_CheckedChanged;
            // 
            // rbReporteRecetaMedica
            // 
            rbReporteRecetaMedica.AutoSize = true;
            rbReporteRecetaMedica.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReporteRecetaMedica.Location = new Point(95, 183);
            rbReporteRecetaMedica.Margin = new Padding(3, 4, 3, 4);
            rbReporteRecetaMedica.Name = "rbReporteRecetaMedica";
            rbReporteRecetaMedica.Size = new Size(401, 36);
            rbReporteRecetaMedica.TabIndex = 13;
            rbReporteRecetaMedica.TabStop = true;
            rbReporteRecetaMedica.Text = "Reporte de consultas semanales";
            rbReporteRecetaMedica.UseVisualStyleBackColor = true;
            // 
            // rbReportePacientesSemanales
            // 
            rbReportePacientesSemanales.AutoSize = true;
            rbReportePacientesSemanales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReportePacientesSemanales.Location = new Point(95, 89);
            rbReportePacientesSemanales.Margin = new Padding(3, 4, 3, 4);
            rbReportePacientesSemanales.Name = "rbReportePacientesSemanales";
            rbReportePacientesSemanales.Size = new Size(274, 36);
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
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1924, 93);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgvReportes);
            Controls.Add(lblReportes);
            Margin = new Padding(3, 4, 3, 4);
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
        private RadioButton rbReporteCantDiagnostico;
        private RadioButton rbReporteRecetaMedica;
        private RadioButton rbReportePacientesSemanales;
        private Button btnGenerar;
        private Button btnVer;
        private PictureBox pictureBox1;
    }
}
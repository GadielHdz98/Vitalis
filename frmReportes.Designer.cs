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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblReportes = new Label();
            panel1 = new Panel();
            dtmpConsultaDelDia = new DateTimePicker();
            rbReportesDiarios = new RadioButton();
            cmbReporteMensual = new ComboBox();
            btnGenerar = new Button();
            rbReporteCantDiagnostico = new RadioButton();
            rbReporteSemanal = new RadioButton();
            rbReportePacientesMensuales = new RadioButton();
            pictureBox1 = new PictureBox();
            dgvReportes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // lblReportes
            // 
            lblReportes.BackColor = Color.Transparent;
            lblReportes.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.FromArgb(23, 147, 209);
            lblReportes.Location = new Point(40, 96);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(876, 68);
            lblReportes.TabIndex = 7;
            lblReportes.Text = "Reportes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtmpConsultaDelDia);
            panel1.Controls.Add(rbReportesDiarios);
            panel1.Controls.Add(cmbReporteMensual);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(rbReporteCantDiagnostico);
            panel1.Controls.Add(rbReporteSemanal);
            panel1.Controls.Add(rbReportePacientesMensuales);
            panel1.Location = new Point(1226, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 601);
            panel1.TabIndex = 10;
            // 
            // dtmpConsultaDelDia
            // 
            dtmpConsultaDelDia.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpConsultaDelDia.Enabled = false;
            dtmpConsultaDelDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpConsultaDelDia.Format = DateTimePickerFormat.Short;
            dtmpConsultaDelDia.Location = new Point(59, 78);
            dtmpConsultaDelDia.MaximumSize = new Size(300, 33);
            dtmpConsultaDelDia.MinimumSize = new Size(250, 33);
            dtmpConsultaDelDia.Name = "dtmpConsultaDelDia";
            dtmpConsultaDelDia.Size = new Size(270, 33);
            dtmpConsultaDelDia.TabIndex = 50;
            dtmpConsultaDelDia.ValueChanged += dtmpConsultaDelDia_ValueChanged;
            // 
            // rbReportesDiarios
            // 
            rbReportesDiarios.AutoSize = true;
            rbReportesDiarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReportesDiarios.Location = new Point(43, 43);
            rbReportesDiarios.Name = "rbReportesDiarios";
            rbReportesDiarios.Size = new Size(286, 29);
            rbReportesDiarios.TabIndex = 49;
            rbReportesDiarios.TabStop = true;
            rbReportesDiarios.Text = "Reporte de consultas del dia:";
            rbReportesDiarios.UseVisualStyleBackColor = true;
            rbReportesDiarios.CheckedChanged += rbReportesDiarios_CheckedChanged;
            // 
            // cmbReporteMensual
            // 
            cmbReporteMensual.BackColor = Color.FromArgb(239, 239, 239);
            cmbReporteMensual.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReporteMensual.Enabled = false;
            cmbReporteMensual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReporteMensual.ForeColor = Color.Black;
            cmbReporteMensual.FormattingEnabled = true;
            cmbReporteMensual.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbReporteMensual.Location = new Point(263, 184);
            cmbReporteMensual.Name = "cmbReporteMensual";
            cmbReporteMensual.Size = new Size(174, 33);
            cmbReporteMensual.TabIndex = 48;
            cmbReporteMensual.SelectedIndexChanged += cmbReporteMensual_SelectedIndexChanged;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(192, 0, 0);
            btnGenerar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGenerar.Location = new Point(146, 363);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(183, 52);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // rbReporteCantDiagnostico
            // 
            rbReporteCantDiagnostico.AutoSize = true;
            rbReporteCantDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReporteCantDiagnostico.Location = new Point(43, 246);
            rbReporteCantDiagnostico.Name = "rbReporteCantDiagnostico";
            rbReporteCantDiagnostico.Size = new Size(357, 29);
            rbReporteCantDiagnostico.TabIndex = 14;
            rbReporteCantDiagnostico.TabStop = true;
            rbReporteCantDiagnostico.Text = "Reporte por cantidad de diagnostico";
            rbReporteCantDiagnostico.UseVisualStyleBackColor = true;
            rbReporteCantDiagnostico.CheckedChanged += rbReporteCantDiagnostico_CheckedChanged;
            // 
            // rbReporteSemanal
            // 
            rbReporteSemanal.AutoSize = true;
            rbReporteSemanal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReporteSemanal.Location = new Point(43, 131);
            rbReporteSemanal.Name = "rbReporteSemanal";
            rbReporteSemanal.Size = new Size(394, 29);
            rbReporteSemanal.TabIndex = 13;
            rbReporteSemanal.TabStop = true;
            rbReporteSemanal.Text = "Reporte de consultas de la semana actual";
            rbReporteSemanal.UseVisualStyleBackColor = true;
            rbReporteSemanal.CheckedChanged += rbReporteSemanal_CheckedChanged;
            // 
            // rbReportePacientesMensuales
            // 
            rbReportePacientesMensuales.AutoSize = true;
            rbReportePacientesMensuales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rbReportePacientesMensuales.Location = new Point(43, 188);
            rbReportePacientesMensuales.Name = "rbReportePacientesMensuales";
            rbReportePacientesMensuales.Size = new Size(214, 29);
            rbReportePacientesMensuales.TabIndex = 12;
            rbReportePacientesMensuales.TabStop = true;
            rbReportePacientesMensuales.Text = "Consultas Mensuales";
            rbReportePacientesMensuales.UseVisualStyleBackColor = true;
            rbReportePacientesMensuales.CheckedChanged += rbReportePacientesMensuales_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(58, 154, 138);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1684, 70);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeColumns = false;
            dgvReportes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(23, 147, 209);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.GridColor = Color.White;
            dgvReportes.Location = new Point(40, 178);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(23, 147, 209);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReportes.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1148, 601);
            dgvReportes.TabIndex = 12;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 791);
            Controls.Add(dgvReportes);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblReportes);
            Name = "frmReportes";
            Text = "frmReportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblReportes;
        private Panel panel1;
        private RadioButton rbReporteCantDiagnostico;
        private RadioButton rbReporteSemanal;
        private RadioButton rbReportePacientesMensuales;
        private Button btnGenerar;
        private PictureBox pictureBox1;
        private DataGridView dgvReportes;
        private ComboBox cmbReporteMensual;
        private RadioButton rbReportesDiarios;
        private DateTimePicker dtmpConsultaDelDia;
    }
}
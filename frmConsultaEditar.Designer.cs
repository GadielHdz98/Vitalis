namespace Vitalis
{
    partial class frmConsultaEditar
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
            lblEditarConsultaTitulo = new Label();
            label1 = new Label();
            cmbDiagnostico = new ComboBox();
            cbxCIR = new CheckBox();
            label6 = new Label();
            rchtxtTratamiento = new RichTextBox();
            label4 = new Label();
            pnlEditarConsulta = new Panel();
            chcbxCita = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dtmpHoraCita = new DateTimePicker();
            dtpckFechaCita = new DateTimePicker();
            label8 = new Label();
            dtmpHoraFinConsulta = new DateTimePicker();
            dtmpHoraInicioConsulta = new DateTimePicker();
            dtmpFechaConsulta = new DateTimePicker();
            label7 = new Label();
            lblhoraYfcha = new Label();
            btnVaciarCampos = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlEditarConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // lblEditarConsultaTitulo
            // 
            lblEditarConsultaTitulo.Anchor = AnchorStyles.Top;
            lblEditarConsultaTitulo.AutoSize = true;
            lblEditarConsultaTitulo.BackColor = Color.Transparent;
            lblEditarConsultaTitulo.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditarConsultaTitulo.ForeColor = Color.FromArgb(23, 147, 209);
            lblEditarConsultaTitulo.Location = new Point(220, 0);
            lblEditarConsultaTitulo.Name = "lblEditarConsultaTitulo";
            lblEditarConsultaTitulo.Size = new Size(383, 68);
            lblEditarConsultaTitulo.TabIndex = 15;
            lblEditarConsultaTitulo.Text = "Editar consulta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 16;
            label1.Text = "Consulta:";
            // 
            // cmbDiagnostico
            // 
            cmbDiagnostico.BackColor = Color.FromArgb(239, 239, 239);
            cmbDiagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiagnostico.ForeColor = Color.Black;
            cmbDiagnostico.FormattingEnabled = true;
            cmbDiagnostico.Location = new Point(24, 131);
            cmbDiagnostico.Name = "cmbDiagnostico";
            cmbDiagnostico.Size = new Size(270, 33);
            cmbDiagnostico.TabIndex = 47;
            // 
            // cbxCIR
            // 
            cbxCIR.AutoSize = true;
            cbxCIR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxCIR.ForeColor = Color.FromArgb(23, 147, 209);
            cbxCIR.Location = new Point(24, 190);
            cbxCIR.Name = "cbxCIR";
            cbxCIR.Size = new Size(245, 29);
            cbxCIR.TabIndex = 59;
            cbxCIR.Text = "CIR (si llevó receta o no)";
            cbxCIR.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(25, 233);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 63;
            label6.Text = "Tratamiento:";
            // 
            // rchtxtTratamiento
            // 
            rchtxtTratamiento.BackColor = Color.FromArgb(239, 239, 239);
            rchtxtTratamiento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxtTratamiento.Location = new Point(23, 261);
            rchtxtTratamiento.Name = "rchtxtTratamiento";
            rchtxtTratamiento.Size = new Size(270, 100);
            rchtxtTratamiento.TabIndex = 64;
            rchtxtTratamiento.Tag = "Tratamiento";
            rchtxtTratamiento.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(24, 91);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 72;
            label4.Text = "Diagnostico:";
            // 
            // pnlEditarConsulta
            // 
            pnlEditarConsulta.BackColor = Color.White;
            pnlEditarConsulta.Controls.Add(chcbxCita);
            pnlEditarConsulta.Controls.Add(label3);
            pnlEditarConsulta.Controls.Add(label2);
            pnlEditarConsulta.Controls.Add(dtmpHoraCita);
            pnlEditarConsulta.Controls.Add(dtpckFechaCita);
            pnlEditarConsulta.Controls.Add(label8);
            pnlEditarConsulta.Controls.Add(dtmpHoraFinConsulta);
            pnlEditarConsulta.Controls.Add(dtmpHoraInicioConsulta);
            pnlEditarConsulta.Controls.Add(dtmpFechaConsulta);
            pnlEditarConsulta.Controls.Add(label7);
            pnlEditarConsulta.Controls.Add(lblhoraYfcha);
            pnlEditarConsulta.Controls.Add(btnVaciarCampos);
            pnlEditarConsulta.Controls.Add(btnGuardar);
            pnlEditarConsulta.Controls.Add(btnCancelar);
            pnlEditarConsulta.Controls.Add(rchtxtTratamiento);
            pnlEditarConsulta.Controls.Add(label6);
            pnlEditarConsulta.Controls.Add(cbxCIR);
            pnlEditarConsulta.Controls.Add(cmbDiagnostico);
            pnlEditarConsulta.Controls.Add(label1);
            pnlEditarConsulta.Controls.Add(label4);
            pnlEditarConsulta.Location = new Point(29, 71);
            pnlEditarConsulta.Name = "pnlEditarConsulta";
            pnlEditarConsulta.Size = new Size(779, 562);
            pnlEditarConsulta.TabIndex = 82;
            // 
            // chcbxCita
            // 
            chcbxCita.AutoSize = true;
            chcbxCita.FlatStyle = FlatStyle.Flat;
            chcbxCita.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            chcbxCita.ForeColor = Color.FromArgb(23, 147, 209);
            chcbxCita.Location = new Point(386, 32);
            chcbxCita.Name = "chcbxCita";
            chcbxCita.Size = new Size(377, 36);
            chcbxCita.TabIndex = 97;
            chcbxCita.Text = "Cita (si se programo cita o no)";
            chcbxCita.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 147, 209);
            label3.Location = new Point(378, 149);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 96;
            label3.Text = "Hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(378, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 95;
            label2.Text = "Fecha:";
            // 
            // dtmpHoraCita
            // 
            dtmpHoraCita.CalendarMonthBackground = Color.FromArgb(239, 239, 239);
            dtmpHoraCita.Font = new Font("Segoe UI", 14F);
            dtmpHoraCita.Format = DateTimePickerFormat.Time;
            dtmpHoraCita.Location = new Point(455, 149);
            dtmpHoraCita.Name = "dtmpHoraCita";
            dtmpHoraCita.Size = new Size(213, 32);
            dtmpHoraCita.TabIndex = 94;
            // 
            // dtpckFechaCita
            // 
            dtpckFechaCita.CalendarMonthBackground = Color.FromArgb(239, 239, 239);
            dtpckFechaCita.Font = new Font("Segoe UI", 14F);
            dtpckFechaCita.Format = DateTimePickerFormat.Short;
            dtpckFechaCita.Location = new Point(455, 85);
            dtpckFechaCita.Name = "dtpckFechaCita";
            dtpckFechaCita.Size = new Size(213, 32);
            dtpckFechaCita.TabIndex = 93;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 147, 209);
            label8.Location = new Point(23, 515);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 92;
            label8.Text = "Hora Fin:";
            // 
            // dtmpHoraFinConsulta
            // 
            dtmpHoraFinConsulta.CalendarMonthBackground = Color.FromArgb(239, 239, 239);
            dtmpHoraFinConsulta.Font = new Font("Segoe UI", 14F);
            dtmpHoraFinConsulta.Format = DateTimePickerFormat.Time;
            dtmpHoraFinConsulta.Location = new Point(154, 509);
            dtmpHoraFinConsulta.Name = "dtmpHoraFinConsulta";
            dtmpHoraFinConsulta.Size = new Size(213, 32);
            dtmpHoraFinConsulta.TabIndex = 91;
            // 
            // dtmpHoraInicioConsulta
            // 
            dtmpHoraInicioConsulta.CalendarMonthBackground = Color.FromArgb(239, 239, 239);
            dtmpHoraInicioConsulta.Font = new Font("Segoe UI", 14F);
            dtmpHoraInicioConsulta.Format = DateTimePickerFormat.Time;
            dtmpHoraInicioConsulta.Location = new Point(154, 455);
            dtmpHoraInicioConsulta.Name = "dtmpHoraInicioConsulta";
            dtmpHoraInicioConsulta.Size = new Size(213, 32);
            dtmpHoraInicioConsulta.TabIndex = 90;
            // 
            // dtmpFechaConsulta
            // 
            dtmpFechaConsulta.CalendarMonthBackground = Color.FromArgb(239, 239, 239);
            dtmpFechaConsulta.Font = new Font("Segoe UI", 14F);
            dtmpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtmpFechaConsulta.Location = new Point(154, 399);
            dtmpFechaConsulta.Name = "dtmpFechaConsulta";
            dtmpFechaConsulta.Size = new Size(213, 32);
            dtmpFechaConsulta.TabIndex = 89;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 147, 209);
            label7.Location = new Point(23, 461);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 88;
            label7.Text = "Hora inicio:";
            // 
            // lblhoraYfcha
            // 
            lblhoraYfcha.AutoSize = true;
            lblhoraYfcha.BackColor = Color.Transparent;
            lblhoraYfcha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhoraYfcha.ForeColor = Color.FromArgb(23, 147, 209);
            lblhoraYfcha.Location = new Point(25, 405);
            lblhoraYfcha.Name = "lblhoraYfcha";
            lblhoraYfcha.Size = new Size(67, 25);
            lblhoraYfcha.TabIndex = 87;
            lblhoraYfcha.Text = "Fecha:";
            // 
            // btnVaciarCampos
            // 
            btnVaciarCampos.BackColor = Color.Orange;
            btnVaciarCampos.FlatAppearance.BorderSize = 0;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(585, 328);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(160, 33);
            btnVaciarCampos.TabIndex = 76;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            btnVaciarCampos.Click += btnVaciarCampos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 64, 88);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGuardar.Location = new Point(585, 260);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 33);
            btnGuardar.TabIndex = 75;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(239, 239, 239);
            btnCancelar.Location = new Point(585, 405);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 33);
            btnCancelar.TabIndex = 74;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmConsultaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(833, 660);
            Controls.Add(lblEditarConsultaTitulo);
            Controls.Add(pnlEditarConsulta);
            MaximumSize = new Size(849, 699);
            MinimumSize = new Size(849, 699);
            Name = "frmConsultaEditar";
            Text = "Editar Consulta";
            pnlEditarConsulta.ResumeLayout(false);
            pnlEditarConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditarConsultaTitulo;
        private Label label1;
        private ComboBox cmbDiagnostico;
        private CheckBox cbxCIR;
        private Label label6;
        private RichTextBox rchtxtTratamiento;
        private Label label4;
        private Panel pnlEditarConsulta;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnVaciarCampos;
        private Label label8;
        private DateTimePicker dtmpHoraFinConsulta;
        private DateTimePicker dtmpHoraInicioConsulta;
        private DateTimePicker dtmpFechaConsulta;
        private Label label7;
        private Label lblhoraYfcha;
        private Label label3;
        private Label label2;
        private DateTimePicker dtmpHoraCita;
        private DateTimePicker dtpckFechaCita;
        private CheckBox chcbxCita;
    }
}
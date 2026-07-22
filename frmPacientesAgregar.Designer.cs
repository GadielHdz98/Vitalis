namespace Vitalis
{
    partial class frmPacientesAgregar
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
            pnlAgregarPacientes = new Panel();
            cmbSexo = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSinFoto = new Button();
            label1 = new Label();
            btnCambiarFoto = new Button();
            pcbFotoPaciente = new PictureBox();
            btnVaciarCampos = new Button();
            btnGuardar = new Button();
            txtUltimaTemperatura = new TextBox();
            txtUltimaPresionArt = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            lblSubTituloFisiologicos = new Label();
            label4 = new Label();
            lblSubTituloIdentificacion = new Label();
            lblSexo = new Label();
            txtGrupo = new TextBox();
            cmbGrado = new ComboBox();
            cmbCarrera = new ComboBox();
            lblPacienteFechaNaci = new Label();
            dtmpFechaNaciPaciente = new DateTimePicker();
            txtPacienteApellidoMaterno = new TextBox();
            txtPacienteApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            cmbTipoPaciente = new ComboBox();
            txtMatriculaNoTrab = new TextBox();
            lblConsultasBuscarTitulo = new Label();
            pnlAgregarPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            SuspendLayout();
            // 
            // pnlAgregarPacientes
            // 
            pnlAgregarPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAgregarPacientes.BackColor = Color.White;
            pnlAgregarPacientes.Controls.Add(cmbSexo);
            pnlAgregarPacientes.Controls.Add(label5);
            pnlAgregarPacientes.Controls.Add(label3);
            pnlAgregarPacientes.Controls.Add(label2);
            pnlAgregarPacientes.Controls.Add(btnSinFoto);
            pnlAgregarPacientes.Controls.Add(label1);
            pnlAgregarPacientes.Controls.Add(btnCambiarFoto);
            pnlAgregarPacientes.Controls.Add(pcbFotoPaciente);
            pnlAgregarPacientes.Controls.Add(btnVaciarCampos);
            pnlAgregarPacientes.Controls.Add(btnGuardar);
            pnlAgregarPacientes.Controls.Add(txtUltimaTemperatura);
            pnlAgregarPacientes.Controls.Add(txtUltimaPresionArt);
            pnlAgregarPacientes.Controls.Add(txtAltura);
            pnlAgregarPacientes.Controls.Add(txtPeso);
            pnlAgregarPacientes.Controls.Add(lblSubTituloFisiologicos);
            pnlAgregarPacientes.Controls.Add(label4);
            pnlAgregarPacientes.Controls.Add(lblSubTituloIdentificacion);
            pnlAgregarPacientes.Controls.Add(lblSexo);
            pnlAgregarPacientes.Controls.Add(txtGrupo);
            pnlAgregarPacientes.Controls.Add(cmbGrado);
            pnlAgregarPacientes.Controls.Add(cmbCarrera);
            pnlAgregarPacientes.Controls.Add(lblPacienteFechaNaci);
            pnlAgregarPacientes.Controls.Add(dtmpFechaNaciPaciente);
            pnlAgregarPacientes.Controls.Add(txtPacienteApellidoMaterno);
            pnlAgregarPacientes.Controls.Add(txtPacienteApellidoPaterno);
            pnlAgregarPacientes.Controls.Add(txtNombre);
            pnlAgregarPacientes.Controls.Add(cmbTipoPaciente);
            pnlAgregarPacientes.Controls.Add(txtMatriculaNoTrab);
            pnlAgregarPacientes.Location = new Point(34, 75);
            pnlAgregarPacientes.Name = "pnlAgregarPacientes";
            pnlAgregarPacientes.Size = new Size(1635, 748);
            pnlAgregarPacientes.TabIndex = 0;
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.FromArgb(239, 239, 239);
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSexo.ForeColor = Color.Black;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { " ", "Masculino", "Femenino" });
            cmbSexo.Location = new Point(544, 167);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(270, 33);
            cmbSexo.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 147, 209);
            label5.Location = new Point(914, 167);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 46;
            label5.Text = "Grado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 147, 209);
            label3.Location = new Point(914, 107);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 45;
            label3.Text = "Carrera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(82, 107);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 44;
            label2.Text = "Tipo:";
            // 
            // btnSinFoto
            // 
            btnSinFoto.BackColor = Color.FromArgb(192, 0, 0);
            btnSinFoto.FlatAppearance.BorderSize = 0;
            btnSinFoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinFoto.ForeColor = Color.FromArgb(239, 239, 239);
            btnSinFoto.Location = new Point(1393, 373);
            btnSinFoto.Margin = new Padding(0);
            btnSinFoto.Name = "btnSinFoto";
            btnSinFoto.Size = new Size(160, 35);
            btnSinFoto.TabIndex = 41;
            btnSinFoto.Text = "Sin foto";
            btnSinFoto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(1371, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 40;
            label1.Text = "Fotografia ";
            // 
            // btnCambiarFoto
            // 
            btnCambiarFoto.BackColor = Color.FromArgb(10, 64, 88);
            btnCambiarFoto.FlatAppearance.BorderSize = 0;
            btnCambiarFoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarFoto.ForeColor = Color.FromArgb(239, 239, 239);
            btnCambiarFoto.Location = new Point(1393, 329);
            btnCambiarFoto.Margin = new Padding(0);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(160, 35);
            btnCambiarFoto.TabIndex = 39;
            btnCambiarFoto.Text = "Cambiar foto";
            btnCambiarFoto.UseVisualStyleBackColor = false;
            // 
            // pcbFotoPaciente
            // 
            pcbFotoPaciente.Image = Properties.Resources.fotoperfilusuariosinfoto;
            pcbFotoPaciente.Location = new Point(1371, 101);
            pcbFotoPaciente.Name = "pcbFotoPaciente";
            pcbFotoPaciente.Size = new Size(200, 200);
            pcbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoPaciente.TabIndex = 38;
            pcbFotoPaciente.TabStop = false;
            // 
            // btnVaciarCampos
            // 
            btnVaciarCampos.BackColor = Color.Orange;
            btnVaciarCampos.FlatAppearance.BorderSize = 0;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(1130, 499);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(160, 35);
            btnVaciarCampos.TabIndex = 37;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            btnVaciarCampos.Click += btnVaciarCampos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(58, 154, 138);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGuardar.Location = new Point(949, 501);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 35);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtUltimaTemperatura
            // 
            txtUltimaTemperatura.BackColor = Color.FromArgb(239, 239, 239);
            txtUltimaTemperatura.BorderStyle = BorderStyle.FixedSingle;
            txtUltimaTemperatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUltimaTemperatura.Location = new Point(544, 438);
            txtUltimaTemperatura.MaxLength = 3;
            txtUltimaTemperatura.Name = "txtUltimaTemperatura";
            txtUltimaTemperatura.PlaceholderText = "Ultima temperatura (°C) ";
            txtUltimaTemperatura.Size = new Size(270, 33);
            txtUltimaTemperatura.TabIndex = 35;
            // 
            // txtUltimaPresionArt
            // 
            txtUltimaPresionArt.BackColor = Color.FromArgb(239, 239, 239);
            txtUltimaPresionArt.BorderStyle = BorderStyle.FixedSingle;
            txtUltimaPresionArt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUltimaPresionArt.Location = new Point(544, 369);
            txtUltimaPresionArt.MaxLength = 7;
            txtUltimaPresionArt.Name = "txtUltimaPresionArt";
            txtUltimaPresionArt.PlaceholderText = "Ultima presion arterial (x/y)";
            txtUltimaPresionArt.Size = new Size(270, 33);
            txtUltimaPresionArt.TabIndex = 34;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = Color.FromArgb(239, 239, 239);
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAltura.Location = new Point(544, 299);
            txtAltura.MaxLength = 3;
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Altura (cm)";
            txtAltura.Size = new Size(270, 33);
            txtAltura.TabIndex = 33;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.FromArgb(239, 239, 239);
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(544, 232);
            txtPeso.MaxLength = 3;
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso (kg)";
            txtPeso.Size = new Size(270, 33);
            txtPeso.TabIndex = 32;
            // 
            // lblSubTituloFisiologicos
            // 
            lblSubTituloFisiologicos.AutoSize = true;
            lblSubTituloFisiologicos.BackColor = Color.Transparent;
            lblSubTituloFisiologicos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubTituloFisiologicos.ForeColor = Color.FromArgb(23, 147, 209);
            lblSubTituloFisiologicos.Location = new Point(544, 33);
            lblSubTituloFisiologicos.Name = "lblSubTituloFisiologicos";
            lblSubTituloFisiologicos.Size = new Size(148, 32);
            lblSubTituloFisiologicos.TabIndex = 31;
            lblSubTituloFisiologicos.Text = "Fisiológicos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(914, 33);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 30;
            label4.Text = "Institucionales";
            // 
            // lblSubTituloIdentificacion
            // 
            lblSubTituloIdentificacion.AutoSize = true;
            lblSubTituloIdentificacion.BackColor = Color.Transparent;
            lblSubTituloIdentificacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubTituloIdentificacion.ForeColor = Color.FromArgb(23, 147, 209);
            lblSubTituloIdentificacion.Location = new Point(82, 33);
            lblSubTituloIdentificacion.Name = "lblSubTituloIdentificacion";
            lblSubTituloIdentificacion.Size = new Size(208, 32);
            lblSubTituloIdentificacion.TabIndex = 29;
            lblSubTituloIdentificacion.Text = "De identificación";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSexo.ForeColor = Color.FromArgb(23, 147, 209);
            lblSexo.Location = new Point(544, 107);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(61, 25);
            lblSexo.TabIndex = 26;
            lblSexo.Text = "Sexo:";
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.FromArgb(239, 239, 239);
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(1010, 232);
            txtGrupo.MaxLength = 1;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Grupo";
            txtGrupo.Size = new Size(270, 33);
            txtGrupo.TabIndex = 25;
            // 
            // cmbGrado
            // 
            cmbGrado.BackColor = Color.FromArgb(239, 239, 239);
            cmbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGrado.ForeColor = Color.Black;
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Items.AddRange(new object[] { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbGrado.Location = new Point(1010, 164);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(270, 33);
            cmbGrado.TabIndex = 24;
            // 
            // cmbCarrera
            // 
            cmbCarrera.BackColor = Color.FromArgb(239, 239, 239);
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(1010, 101);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 33);
            cmbCarrera.TabIndex = 23;
            // 
            // lblPacienteFechaNaci
            // 
            lblPacienteFechaNaci.AutoSize = true;
            lblPacienteFechaNaci.BackColor = Color.Transparent;
            lblPacienteFechaNaci.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPacienteFechaNaci.ForeColor = Color.FromArgb(23, 147, 209);
            lblPacienteFechaNaci.Location = new Point(145, 446);
            lblPacienteFechaNaci.Name = "lblPacienteFechaNaci";
            lblPacienteFechaNaci.Size = new Size(198, 25);
            lblPacienteFechaNaci.TabIndex = 22;
            lblPacienteFechaNaci.Text = "Fecha de nacimiento:";
            // 
            // dtmpFechaNaciPaciente
            // 
            dtmpFechaNaciPaciente.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpFechaNaciPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpFechaNaciPaciente.Format = DateTimePickerFormat.Short;
            dtmpFechaNaciPaciente.Location = new Point(145, 501);
            dtmpFechaNaciPaciente.MaximumSize = new Size(300, 33);
            dtmpFechaNaciPaciente.MinimumSize = new Size(250, 33);
            dtmpFechaNaciPaciente.Name = "dtmpFechaNaciPaciente";
            dtmpFechaNaciPaciente.Size = new Size(270, 33);
            dtmpFechaNaciPaciente.TabIndex = 21;
            // 
            // txtPacienteApellidoMaterno
            // 
            txtPacienteApellidoMaterno.BackColor = Color.FromArgb(239, 239, 239);
            txtPacienteApellidoMaterno.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteApellidoMaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPacienteApellidoMaterno.Location = new Point(145, 373);
            txtPacienteApellidoMaterno.MaxLength = 50;
            txtPacienteApellidoMaterno.Name = "txtPacienteApellidoMaterno";
            txtPacienteApellidoMaterno.PlaceholderText = "Apellido materno";
            txtPacienteApellidoMaterno.Size = new Size(270, 33);
            txtPacienteApellidoMaterno.TabIndex = 20;
            // 
            // txtPacienteApellidoPaterno
            // 
            txtPacienteApellidoPaterno.BackColor = Color.FromArgb(239, 239, 239);
            txtPacienteApellidoPaterno.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteApellidoPaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPacienteApellidoPaterno.Location = new Point(145, 304);
            txtPacienteApellidoPaterno.MaxLength = 50;
            txtPacienteApellidoPaterno.Name = "txtPacienteApellidoPaterno";
            txtPacienteApellidoPaterno.PlaceholderText = "Apellido paterno";
            txtPacienteApellidoPaterno.Size = new Size(270, 33);
            txtPacienteApellidoPaterno.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(239, 239, 239);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(145, 234);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre(s)";
            txtNombre.Size = new Size(270, 33);
            txtNombre.TabIndex = 18;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.BackColor = Color.FromArgb(239, 239, 239);
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Items.AddRange(new object[] { " ", "Alumno", "Trabajador" });
            cmbTipoPaciente.Location = new Point(145, 101);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 17;
            cmbTipoPaciente.SelectedIndexChanged += cmbTipoPaciente_SelectedIndexChanged;
            // 
            // txtMatriculaNoTrab
            // 
            txtMatriculaNoTrab.BackColor = Color.FromArgb(239, 239, 239);
            txtMatriculaNoTrab.BorderStyle = BorderStyle.FixedSingle;
            txtMatriculaNoTrab.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatriculaNoTrab.Location = new Point(145, 167);
            txtMatriculaNoTrab.MaxLength = 8;
            txtMatriculaNoTrab.Name = "txtMatriculaNoTrab";
            txtMatriculaNoTrab.PlaceholderText = "Matricula/No. Trab";
            txtMatriculaNoTrab.Size = new Size(270, 33);
            txtMatriculaNoTrab.TabIndex = 13;
            // 
            // lblConsultasBuscarTitulo
            // 
            lblConsultasBuscarTitulo.BackColor = Color.Transparent;
            lblConsultasBuscarTitulo.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarTitulo.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarTitulo.Location = new Point(27, 4);
            lblConsultasBuscarTitulo.Name = "lblConsultasBuscarTitulo";
            lblConsultasBuscarTitulo.Size = new Size(727, 68);
            lblConsultasBuscarTitulo.TabIndex = 12;
            lblConsultasBuscarTitulo.Text = "Datos para agregar pacientes";
            // 
            // frmPacientesAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1703, 861);
            Controls.Add(lblConsultasBuscarTitulo);
            Controls.Add(pnlAgregarPacientes);
            Name = "frmPacientesAgregar";
            Text = "frmAgregarPaciente";
            pnlAgregarPacientes.ResumeLayout(false);
            pnlAgregarPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAgregarPacientes;
        private Label lblConsultasBuscarTitulo;
        private TextBox txtMatriculaNoTrab;
        private ComboBox cmbTipoPaciente;
        private TextBox txtPacienteApellidoPaterno;
        private TextBox txtNombre;
        private TextBox txtPacienteApellidoMaterno;
        private DateTimePicker dtmpFechaNaciPaciente;
        private Label lblPacienteFechaNaci;
        private ComboBox cmbCarrera;
        private TextBox txtGrupo;
        private ComboBox cmbGrado;
        private Label lblSubTituloIdentificacion;
        private Label lblSexo;
        private Label label4;
        private Label lblSubTituloFisiologicos;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private TextBox txtUltimaTemperatura;
        private TextBox txtUltimaPresionArt;
        private Button btnGuardar;
        private Button btnVaciarCampos;
        private Button btnSinFoto;
        private Label label1;
        private Button btnCambiarFoto;
        private PictureBox pcbFotoPaciente;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cmbSexo;
    }
}
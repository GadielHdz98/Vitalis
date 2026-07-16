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
            panel1 = new Panel();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            btnSinFoto = new Button();
            label1 = new Label();
            btnCambiarFoto = new Button();
            pcbFotoPaciente = new PictureBox();
            btnVaciarCampos = new Button();
            btnGuardar = new Button();
            txtUltimaTemperatura = new TextBox();
            txtUltimaPresionArt = new TextBox();
            textBox2 = new TextBox();
            txtPeso = new TextBox();
            lblSubTituloFisiologicos = new Label();
            label4 = new Label();
            lblSubTituloIdentificacion = new Label();
            lblSexo = new Label();
            txtGrupo = new TextBox();
            cmbGrado = new ComboBox();
            cmbCarrera = new ComboBox();
            lblPacienteFechaNaci = new Label();
            dtmpFechaNaciUsuario = new DateTimePicker();
            txtPacienteApellidoMaterno = new TextBox();
            txtPacienteApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            cmbTipoPaciente = new ComboBox();
            txtMatriculaNoTrab = new TextBox();
            lblConsultasBuscarTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rbtnFemenino);
            panel1.Controls.Add(rbtnMasculino);
            panel1.Controls.Add(btnSinFoto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCambiarFoto);
            panel1.Controls.Add(pcbFotoPaciente);
            panel1.Controls.Add(btnVaciarCampos);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtUltimaTemperatura);
            panel1.Controls.Add(txtUltimaPresionArt);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(lblSubTituloFisiologicos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblSubTituloIdentificacion);
            panel1.Controls.Add(lblSexo);
            panel1.Controls.Add(txtGrupo);
            panel1.Controls.Add(cmbGrado);
            panel1.Controls.Add(cmbCarrera);
            panel1.Controls.Add(lblPacienteFechaNaci);
            panel1.Controls.Add(dtmpFechaNaciUsuario);
            panel1.Controls.Add(txtPacienteApellidoMaterno);
            panel1.Controls.Add(txtPacienteApellidoPaterno);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(cmbTipoPaciente);
            panel1.Controls.Add(txtMatriculaNoTrab);
            panel1.Location = new Point(34, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1635, 748);
            panel1.TabIndex = 0;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnFemenino.Location = new Point(681, 99);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(39, 29);
            rbtnFemenino.TabIndex = 43;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "F";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMasculino.Location = new Point(603, 99);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(47, 29);
            rbtnMasculino.TabIndex = 42;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "M";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnSinFoto
            // 
            btnSinFoto.BackColor = Color.FromArgb(192, 0, 0);
            btnSinFoto.FlatAppearance.BorderSize = 0;
            btnSinFoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinFoto.ForeColor = Color.FromArgb(239, 239, 239);
            btnSinFoto.Location = new Point(1371, 405);
            btnSinFoto.Margin = new Padding(0);
            btnSinFoto.Name = "btnSinFoto";
            btnSinFoto.Size = new Size(145, 33);
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
            btnCambiarFoto.Location = new Point(1371, 359);
            btnCambiarFoto.Margin = new Padding(0);
            btnCambiarFoto.Name = "btnCambiarFoto";
            btnCambiarFoto.Size = new Size(145, 33);
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
            btnVaciarCampos.BackColor = Color.DarkGoldenrod;
            btnVaciarCampos.FlatAppearance.BorderSize = 0;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(1371, 495);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(150, 33);
            btnVaciarCampos.TabIndex = 37;
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
            btnGuardar.Location = new Point(1215, 495);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 33);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtUltimaTemperatura
            // 
            txtUltimaTemperatura.BackColor = Color.White;
            txtUltimaTemperatura.BorderStyle = BorderStyle.FixedSingle;
            txtUltimaTemperatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUltimaTemperatura.Location = new Point(518, 371);
            txtUltimaTemperatura.MaxLength = 3;
            txtUltimaTemperatura.Name = "txtUltimaTemperatura";
            txtUltimaTemperatura.PlaceholderText = "Ultima temperatura (°C) ";
            txtUltimaTemperatura.Size = new Size(270, 33);
            txtUltimaTemperatura.TabIndex = 35;
            // 
            // txtUltimaPresionArt
            // 
            txtUltimaPresionArt.BackColor = Color.White;
            txtUltimaPresionArt.BorderStyle = BorderStyle.FixedSingle;
            txtUltimaPresionArt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUltimaPresionArt.Location = new Point(518, 302);
            txtUltimaPresionArt.MaxLength = 7;
            txtUltimaPresionArt.Name = "txtUltimaPresionArt";
            txtUltimaPresionArt.PlaceholderText = "Ultima presion arterial (x/y)";
            txtUltimaPresionArt.Size = new Size(270, 33);
            txtUltimaPresionArt.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(518, 232);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Altura (cm)";
            textBox2.Size = new Size(270, 33);
            textBox2.TabIndex = 33;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.White;
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(518, 165);
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
            lblSubTituloFisiologicos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTituloFisiologicos.ForeColor = Color.FromArgb(23, 147, 209);
            lblSubTituloFisiologicos.Location = new Point(518, 33);
            lblSubTituloFisiologicos.Name = "lblSubTituloFisiologicos";
            lblSubTituloFisiologicos.Size = new Size(115, 25);
            lblSubTituloFisiologicos.TabIndex = 31;
            lblSubTituloFisiologicos.Text = "Fisiológicos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(941, 33);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 30;
            label4.Text = "Institucionales";
            // 
            // lblSubTituloIdentificacion
            // 
            lblSubTituloIdentificacion.AutoSize = true;
            lblSubTituloIdentificacion.BackColor = Color.Transparent;
            lblSubTituloIdentificacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTituloIdentificacion.ForeColor = Color.FromArgb(23, 147, 209);
            lblSubTituloIdentificacion.Location = new Point(82, 33);
            lblSubTituloIdentificacion.Name = "lblSubTituloIdentificacion";
            lblSubTituloIdentificacion.Size = new Size(161, 25);
            lblSubTituloIdentificacion.TabIndex = 29;
            lblSubTituloIdentificacion.Text = "De identificación";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F);
            lblSexo.Location = new Point(518, 101);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 26;
            lblSexo.Text = "Sexo:";
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(941, 232);
            txtGrupo.MaxLength = 1;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Grupo";
            txtGrupo.Size = new Size(270, 33);
            txtGrupo.TabIndex = 25;
            // 
            // cmbGrado
            // 
            cmbGrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGrado.ForeColor = Color.Black;
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(941, 164);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(270, 33);
            cmbGrado.TabIndex = 24;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(941, 98);
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
            lblPacienteFechaNaci.Location = new Point(82, 433);
            lblPacienteFechaNaci.Name = "lblPacienteFechaNaci";
            lblPacienteFechaNaci.Size = new Size(198, 25);
            lblPacienteFechaNaci.TabIndex = 22;
            lblPacienteFechaNaci.Text = "Fecha de nacimiento:";
            // 
            // dtmpFechaNaciUsuario
            // 
            dtmpFechaNaciUsuario.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpFechaNaciUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtmpFechaNaciUsuario.Location = new Point(82, 474);
            dtmpFechaNaciUsuario.MaximumSize = new Size(270, 33);
            dtmpFechaNaciUsuario.MinimumSize = new Size(270, 33);
            dtmpFechaNaciUsuario.Name = "dtmpFechaNaciUsuario";
            dtmpFechaNaciUsuario.Size = new Size(270, 33);
            dtmpFechaNaciUsuario.TabIndex = 21;
            // 
            // txtPacienteApellidoMaterno
            // 
            txtPacienteApellidoMaterno.BackColor = Color.White;
            txtPacienteApellidoMaterno.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteApellidoMaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPacienteApellidoMaterno.Location = new Point(82, 371);
            txtPacienteApellidoMaterno.MaxLength = 50;
            txtPacienteApellidoMaterno.Name = "txtPacienteApellidoMaterno";
            txtPacienteApellidoMaterno.PlaceholderText = "Apellido materno";
            txtPacienteApellidoMaterno.Size = new Size(270, 33);
            txtPacienteApellidoMaterno.TabIndex = 20;
            // 
            // txtPacienteApellidoPaterno
            // 
            txtPacienteApellidoPaterno.BackColor = Color.White;
            txtPacienteApellidoPaterno.BorderStyle = BorderStyle.FixedSingle;
            txtPacienteApellidoPaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPacienteApellidoPaterno.Location = new Point(82, 302);
            txtPacienteApellidoPaterno.MaxLength = 50;
            txtPacienteApellidoPaterno.Name = "txtPacienteApellidoPaterno";
            txtPacienteApellidoPaterno.PlaceholderText = "Apellido paterno";
            txtPacienteApellidoPaterno.Size = new Size(270, 33);
            txtPacienteApellidoPaterno.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(82, 232);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre(s)";
            txtNombre.Size = new Size(270, 33);
            txtNombre.TabIndex = 18;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Location = new Point(82, 95);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 17;
            // 
            // txtMatriculaNoTrab
            // 
            txtMatriculaNoTrab.BackColor = Color.White;
            txtMatriculaNoTrab.BorderStyle = BorderStyle.FixedSingle;
            txtMatriculaNoTrab.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatriculaNoTrab.Location = new Point(82, 164);
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
            Controls.Add(panel1);
            Name = "frmPacientesAgregar";
            Text = "frmAgregarPaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblConsultasBuscarTitulo;
        private TextBox txtMatriculaNoTrab;
        private ComboBox cmbTipoPaciente;
        private TextBox txtPacienteApellidoPaterno;
        private TextBox txtNombre;
        private TextBox txtPacienteApellidoMaterno;
        private DateTimePicker dtmpFechaNaciUsuario;
        private Label lblPacienteFechaNaci;
        private ComboBox cmbCarrera;
        private TextBox txtGrupo;
        private ComboBox cmbGrado;
        private Label lblSubTituloIdentificacion;
        private Label lblSexo;
        private Label label4;
        private Label lblSubTituloFisiologicos;
        private TextBox textBox2;
        private TextBox txtPeso;
        private TextBox txtUltimaTemperatura;
        private TextBox txtUltimaPresionArt;
        private Button btnGuardar;
        private Button btnVaciarCampos;
        private Button btnSinFoto;
        private Label label1;
        private Button btnCambiarFoto;
        private PictureBox pcbFotoPaciente;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
    }
}
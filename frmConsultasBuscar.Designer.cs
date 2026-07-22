namespace Vitalis
{
    partial class frmConsultasBuscar
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
            dgvConsultasBuscar = new DataGridView();
            pnlBuscarPaciente = new Panel();
            cmbSexo = new ComboBox();
            lblSexo = new Label();
            label6 = new Label();
            lblCon = new Label();
            lblTurno = new Label();
            label5 = new Label();
            label4 = new Label();
            lblTipoPaciente = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            lblConsultasBuscarAvisoFecha = new Label();
            txtAnio = new TextBox();
            lblConsultasBuscarFecha = new Label();
            cbxCITA = new CheckBox();
            cbxCIR = new CheckBox();
            lblConsultaBuscarConsulta = new Label();
            lblConsultasBuscarPacientes = new Label();
            cmbDiagnostico = new ComboBox();
            cmbTurno = new ComboBox();
            cmbConsultor = new ComboBox();
            pcbFotoPaciente = new PictureBox();
            btnVaciarCampos = new Button();
            btnBuscarPaciente = new Button();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbCuatri = new ComboBox();
            txtGrupo = new TextBox();
            lblConsultasBuscarTitulo = new Label();
            pcbIconoBuscar = new PictureBox();
            txtBuscarPorNumConsul = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvConsultasBuscar).BeginInit();
            pnlBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultasBuscar
            // 
            dgvConsultasBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsultasBuscar.BackgroundColor = Color.White;
            dgvConsultasBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultasBuscar.Location = new Point(31, 447);
            dgvConsultasBuscar.Name = "dgvConsultasBuscar";
            dgvConsultasBuscar.Size = new Size(1662, 495);
            dgvConsultasBuscar.TabIndex = 13;
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(cmbSexo);
            pnlBuscarPaciente.Controls.Add(lblSexo);
            pnlBuscarPaciente.Controls.Add(label6);
            pnlBuscarPaciente.Controls.Add(lblCon);
            pnlBuscarPaciente.Controls.Add(lblTurno);
            pnlBuscarPaciente.Controls.Add(label5);
            pnlBuscarPaciente.Controls.Add(label4);
            pnlBuscarPaciente.Controls.Add(lblTipoPaciente);
            pnlBuscarPaciente.Controls.Add(btnEliminar);
            pnlBuscarPaciente.Controls.Add(btnEditar);
            pnlBuscarPaciente.Controls.Add(label3);
            pnlBuscarPaciente.Controls.Add(label2);
            pnlBuscarPaciente.Controls.Add(label1);
            pnlBuscarPaciente.Controls.Add(txtDia);
            pnlBuscarPaciente.Controls.Add(txtMes);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarAvisoFecha);
            pnlBuscarPaciente.Controls.Add(txtAnio);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarFecha);
            pnlBuscarPaciente.Controls.Add(cbxCITA);
            pnlBuscarPaciente.Controls.Add(cbxCIR);
            pnlBuscarPaciente.Controls.Add(lblConsultaBuscarConsulta);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarPacientes);
            pnlBuscarPaciente.Controls.Add(cmbDiagnostico);
            pnlBuscarPaciente.Controls.Add(cmbTurno);
            pnlBuscarPaciente.Controls.Add(cmbConsultor);
            pnlBuscarPaciente.Controls.Add(pcbFotoPaciente);
            pnlBuscarPaciente.Controls.Add(btnVaciarCampos);
            pnlBuscarPaciente.Controls.Add(btnBuscarPaciente);
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbCuatri);
            pnlBuscarPaciente.Controls.Add(txtGrupo);
            pnlBuscarPaciente.Location = new Point(31, 75);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1662, 338);
            pnlBuscarPaciente.TabIndex = 12;
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.FromArgb(239, 239, 239);
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSexo.ForeColor = Color.FromArgb(239, 239, 239);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(131, 286);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(270, 33);
            cmbSexo.TabIndex = 87;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSexo.ForeColor = Color.FromArgb(23, 147, 209);
            lblSexo.Location = new Point(46, 289);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(61, 25);
            lblSexo.TabIndex = 86;
            lblSexo.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(454, 176);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 54;
            label6.Text = "Diagnostico:";
            // 
            // lblCon
            // 
            lblCon.AutoSize = true;
            lblCon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCon.ForeColor = Color.FromArgb(23, 147, 209);
            lblCon.Location = new Point(454, 120);
            lblCon.Name = "lblCon";
            lblCon.Size = new Size(106, 25);
            lblCon.TabIndex = 53;
            lblCon.Text = "Consultor:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.FromArgb(23, 147, 209);
            lblTurno.Location = new Point(454, 69);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(71, 25);
            lblTurno.TabIndex = 52;
            lblTurno.Text = "Turno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 147, 209);
            label5.Location = new Point(46, 181);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 51;
            label5.Text = "Cuatri:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(46, 124);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 50;
            label4.Text = "Carrera:";
            // 
            // lblTipoPaciente
            // 
            lblTipoPaciente.AutoSize = true;
            lblTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoPaciente.ForeColor = Color.FromArgb(23, 147, 209);
            lblTipoPaciente.Location = new Point(46, 69);
            lblTipoPaciente.Name = "lblTipoPaciente";
            lblTipoPaciente.Size = new Size(57, 25);
            lblTipoPaciente.TabIndex = 49;
            lblTipoPaciente.Text = "Tipo:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEliminar.Location = new Point(1466, 115);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 35);
            btnEliminar.TabIndex = 48;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(10, 64, 88);
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEditar.Location = new Point(1466, 56);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 35);
            btnEditar.TabIndex = 47;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 158, 158);
            label3.Location = new Point(878, 286);
            label3.Name = "label3";
            label3.Size = new Size(507, 29);
            label3.TabIndex = 33;
            label3.Text = "Asegurese de llenar por lo menos un campo antes de buscar.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(1080, 66);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 32;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(981, 66);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 31;
            label1.Text = "/";
            // 
            // txtDia
            // 
            txtDia.BackColor = Color.FromArgb(239, 239, 239);
            txtDia.BorderStyle = BorderStyle.FixedSingle;
            txtDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDia.Location = new Point(1108, 64);
            txtDia.MaxLength = 1;
            txtDia.Name = "txtDia";
            txtDia.PlaceholderText = "Día";
            txtDia.Size = new Size(67, 33);
            txtDia.TabIndex = 30;
            // 
            // txtMes
            // 
            txtMes.BackColor = Color.FromArgb(239, 239, 239);
            txtMes.BorderStyle = BorderStyle.FixedSingle;
            txtMes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMes.Location = new Point(1007, 64);
            txtMes.MaxLength = 1;
            txtMes.Name = "txtMes";
            txtMes.PlaceholderText = "Més";
            txtMes.Size = new Size(67, 33);
            txtMes.TabIndex = 29;
            // 
            // lblConsultasBuscarAvisoFecha
            // 
            lblConsultasBuscarAvisoFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConsultasBuscarAvisoFecha.ForeColor = Color.FromArgb(158, 158, 158);
            lblConsultasBuscarAvisoFecha.Location = new Point(905, 100);
            lblConsultasBuscarAvisoFecha.Name = "lblConsultasBuscarAvisoFecha";
            lblConsultasBuscarAvisoFecha.Size = new Size(270, 33);
            lblConsultasBuscarAvisoFecha.TabIndex = 28;
            lblConsultasBuscarAvisoFecha.Text = "Ingrese unicamente numeros.";
            // 
            // txtAnio
            // 
            txtAnio.BackColor = Color.FromArgb(239, 239, 239);
            txtAnio.BorderStyle = BorderStyle.FixedSingle;
            txtAnio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnio.Location = new Point(908, 64);
            txtAnio.MaxLength = 1;
            txtAnio.Name = "txtAnio";
            txtAnio.PlaceholderText = "Año";
            txtAnio.Size = new Size(67, 33);
            txtAnio.TabIndex = 27;
            // 
            // lblConsultasBuscarFecha
            // 
            lblConsultasBuscarFecha.AutoSize = true;
            lblConsultasBuscarFecha.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblConsultasBuscarFecha.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarFecha.Location = new Point(908, 15);
            lblConsultasBuscarFecha.Name = "lblConsultasBuscarFecha";
            lblConsultasBuscarFecha.Size = new Size(85, 32);
            lblConsultasBuscarFecha.TabIndex = 23;
            lblConsultasBuscarFecha.Text = "Fecha:";
            // 
            // cbxCITA
            // 
            cbxCITA.AutoSize = true;
            cbxCITA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cbxCITA.ForeColor = Color.FromArgb(23, 147, 209);
            cbxCITA.Location = new Point(454, 280);
            cbxCITA.Name = "cbxCITA";
            cbxCITA.Size = new Size(298, 29);
            cbxCITA.TabIndex = 22;
            cbxCITA.Text = "Cita (si se programo cita o no)";
            cbxCITA.UseVisualStyleBackColor = true;
            // 
            // cbxCIR
            // 
            cbxCIR.AutoSize = true;
            cbxCIR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cbxCIR.ForeColor = Color.FromArgb(23, 147, 209);
            cbxCIR.Location = new Point(454, 233);
            cbxCIR.Name = "cbxCIR";
            cbxCIR.Size = new Size(245, 29);
            cbxCIR.TabIndex = 21;
            cbxCIR.Text = "CIR (si llevó receta o no)";
            cbxCIR.UseVisualStyleBackColor = true;
            // 
            // lblConsultaBuscarConsulta
            // 
            lblConsultaBuscarConsulta.AutoSize = true;
            lblConsultaBuscarConsulta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblConsultaBuscarConsulta.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultaBuscarConsulta.Location = new Point(454, 15);
            lblConsultaBuscarConsulta.Name = "lblConsultaBuscarConsulta";
            lblConsultaBuscarConsulta.Size = new Size(121, 32);
            lblConsultaBuscarConsulta.TabIndex = 20;
            lblConsultaBuscarConsulta.Text = "Consulta:";
            // 
            // lblConsultasBuscarPacientes
            // 
            lblConsultasBuscarPacientes.AutoSize = true;
            lblConsultasBuscarPacientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblConsultasBuscarPacientes.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarPacientes.Location = new Point(46, 15);
            lblConsultasBuscarPacientes.Name = "lblConsultasBuscarPacientes";
            lblConsultasBuscarPacientes.Size = new Size(117, 32);
            lblConsultasBuscarPacientes.TabIndex = 19;
            lblConsultasBuscarPacientes.Text = "Paciente:";
            // 
            // cmbDiagnostico
            // 
            cmbDiagnostico.BackColor = Color.FromArgb(239, 239, 239);
            cmbDiagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiagnostico.ForeColor = Color.Black;
            cmbDiagnostico.FormattingEnabled = true;
            cmbDiagnostico.Location = new Point(578, 173);
            cmbDiagnostico.Name = "cmbDiagnostico";
            cmbDiagnostico.Size = new Size(270, 33);
            cmbDiagnostico.TabIndex = 18;
            // 
            // cmbTurno
            // 
            cmbTurno.BackColor = Color.FromArgb(239, 239, 239);
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTurno.ForeColor = Color.Black;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(578, 63);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(270, 33);
            cmbTurno.TabIndex = 17;
            // 
            // cmbConsultor
            // 
            cmbConsultor.BackColor = Color.FromArgb(239, 239, 239);
            cmbConsultor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsultor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbConsultor.ForeColor = Color.Black;
            cmbConsultor.FormattingEnabled = true;
            cmbConsultor.Location = new Point(578, 114);
            cmbConsultor.Name = "cmbConsultor";
            cmbConsultor.Size = new Size(270, 33);
            cmbConsultor.TabIndex = 16;
            // 
            // pcbFotoPaciente
            // 
            pcbFotoPaciente.Image = Properties.Resources.fotoperfilusuariosinfoto;
            pcbFotoPaciente.Location = new Point(1247, 26);
            pcbFotoPaciente.Name = "pcbFotoPaciente";
            pcbFotoPaciente.Size = new Size(200, 200);
            pcbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoPaciente.TabIndex = 9;
            pcbFotoPaciente.TabStop = false;
            toolTip1.SetToolTip(pcbFotoPaciente, "Imagen del paciente");
            // 
            // btnVaciarCampos
            // 
            btnVaciarCampos.BackColor = Color.Orange;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(1080, 233);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(160, 35);
            btnVaciarCampos.TabIndex = 11;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            btnVaciarCampos.Click += btnVaciarCampos_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(10, 64, 88);
            btnBuscarPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPaciente.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarPaciente.Location = new Point(903, 233);
            btnBuscarPaciente.Margin = new Padding(0);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(160, 35);
            btnBuscarPaciente.TabIndex = 10;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.BackColor = Color.FromArgb(239, 239, 239);
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Location = new Point(131, 66);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.BackColor = Color.FromArgb(239, 239, 239);
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(131, 121);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 33);
            cmbCarrera.TabIndex = 7;
            // 
            // cmbCuatri
            // 
            cmbCuatri.BackColor = Color.FromArgb(239, 239, 239);
            cmbCuatri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuatri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuatri.ForeColor = Color.Black;
            cmbCuatri.FormattingEnabled = true;
            cmbCuatri.Location = new Point(131, 178);
            cmbCuatri.Name = "cmbCuatri";
            cmbCuatri.Size = new Size(270, 33);
            cmbCuatri.TabIndex = 6;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.FromArgb(239, 239, 239);
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(131, 237);
            txtGrupo.MaxLength = 1;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Grupo";
            txtGrupo.Size = new Size(270, 33);
            txtGrupo.TabIndex = 1;
            // 
            // lblConsultasBuscarTitulo
            // 
            lblConsultasBuscarTitulo.AutoSize = true;
            lblConsultasBuscarTitulo.BackColor = Color.Transparent;
            lblConsultasBuscarTitulo.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarTitulo.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarTitulo.Location = new Point(31, 4);
            lblConsultasBuscarTitulo.Name = "lblConsultasBuscarTitulo";
            lblConsultasBuscarTitulo.Size = new Size(721, 68);
            lblConsultasBuscarTitulo.TabIndex = 11;
            lblConsultasBuscarTitulo.Text = "Datos de la consulta a buscar";
            // 
            // pcbIconoBuscar
            // 
            pcbIconoBuscar.Image = Properties.Resources.IconoBuscar;
            pcbIconoBuscar.Location = new Point(1658, 25);
            pcbIconoBuscar.Name = "pcbIconoBuscar";
            pcbIconoBuscar.Size = new Size(35, 35);
            pcbIconoBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIconoBuscar.TabIndex = 17;
            pcbIconoBuscar.TabStop = false;
            // 
            // txtBuscarPorNumConsul
            // 
            txtBuscarPorNumConsul.BackColor = Color.White;
            txtBuscarPorNumConsul.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPorNumConsul.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPorNumConsul.Location = new Point(1369, 25);
            txtBuscarPorNumConsul.Name = "txtBuscarPorNumConsul";
            txtBuscarPorNumConsul.PlaceholderText = "Buscar por Num. consulta";
            txtBuscarPorNumConsul.Size = new Size(267, 33);
            txtBuscarPorNumConsul.TabIndex = 16;
            // 
            // frmConsultasBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(pcbIconoBuscar);
            Controls.Add(txtBuscarPorNumConsul);
            Controls.Add(dgvConsultasBuscar);
            Controls.Add(pnlBuscarPaciente);
            Controls.Add(lblConsultasBuscarTitulo);
            Name = "frmConsultasBuscar";
            Text = "frmConsultasBuscar";
            ((System.ComponentModel.ISupportInitialize)dgvConsultasBuscar).EndInit();
            pnlBuscarPaciente.ResumeLayout(false);
            pnlBuscarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cmbDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgvConsultasBuscar;
        private Panel pnlBuscarPaciente;
        private PictureBox pcbFotoPaciente;
        private Button btnVaciarCampos;
        private Button btnBuscarPaciente;
        private ComboBox cmbTipoPaciente;
        private ComboBox cmbCarrera;
        private ComboBox cmbCuatri;
        private TextBox txtGrupo;
        private Label lblConsultasBuscarTitulo;
        private ComboBox cmbTurno;
        private ComboBox cmbConsultor;
        private ComboBox cmbDiagnostico;
        private Label lblConsultasBuscarPacientes;
        private Label lblConsultaBuscarConsulta;
        private CheckBox cbxCITA;
        private CheckBox cbxCIR;
        private Label lblConsultasBuscarFecha;
        private Label lblConsultasBuscarAvisoFecha;
        private TextBox txtAnio;
        private Label label2;
        private Label label1;
        private TextBox txtDia;
        private TextBox txtMes;
        private PictureBox pcbIconoBuscar;
        private TextBox txtBuscarPorNumConsul;
        private Label label3;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label5;
        private Label label4;
        private Label lblTipoPaciente;
        private Label label6;
        private Label lblCon;
        private Label lblTurno;
        private ComboBox cmbSexo;
        private Label lblSexo;
        private ToolTip toolTip1;
    }
}
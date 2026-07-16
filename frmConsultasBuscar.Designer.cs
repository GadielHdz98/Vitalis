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
            dataGridView1 = new DataGridView();
            pnlBuscarPaciente = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            lblSexo = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            lblConsultasBuscarAvisoFecha = new Label();
            txtAño = new TextBox();
            lblConsultasBuscarFecha = new Label();
            cbxCITA = new CheckBox();
            cbxCIR = new CheckBox();
            lblConsultaBuscarConsulta = new Label();
            lblConsultasBuscarPacientes = new Label();
            cmbDiagnostico = new ComboBox();
            cmbTurno = new ComboBox();
            cmbConsultor = new ComboBox();
            pcbFotoPaciente = new PictureBox();
            button1 = new Button();
            btnBuscarPaciente = new Button();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbCuatri = new ComboBox();
            txtGrupo = new TextBox();
            lblConsultasBuscarTitulo = new Label();
            pcbIconoBuscar = new PictureBox();
            txtBuscarPorNumConsul = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 433);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1662, 509);
            dataGridView1.TabIndex = 13;
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(btnEliminar);
            pnlBuscarPaciente.Controls.Add(btnEditar);
            pnlBuscarPaciente.Controls.Add(rbtnFemenino);
            pnlBuscarPaciente.Controls.Add(rbtnMasculino);
            pnlBuscarPaciente.Controls.Add(lblSexo);
            pnlBuscarPaciente.Controls.Add(label3);
            pnlBuscarPaciente.Controls.Add(label2);
            pnlBuscarPaciente.Controls.Add(label1);
            pnlBuscarPaciente.Controls.Add(txtDia);
            pnlBuscarPaciente.Controls.Add(txtMes);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarAvisoFecha);
            pnlBuscarPaciente.Controls.Add(txtAño);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarFecha);
            pnlBuscarPaciente.Controls.Add(cbxCITA);
            pnlBuscarPaciente.Controls.Add(cbxCIR);
            pnlBuscarPaciente.Controls.Add(lblConsultaBuscarConsulta);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarPacientes);
            pnlBuscarPaciente.Controls.Add(cmbDiagnostico);
            pnlBuscarPaciente.Controls.Add(cmbTurno);
            pnlBuscarPaciente.Controls.Add(cmbConsultor);
            pnlBuscarPaciente.Controls.Add(pcbFotoPaciente);
            pnlBuscarPaciente.Controls.Add(button1);
            pnlBuscarPaciente.Controls.Add(btnBuscarPaciente);
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbCuatri);
            pnlBuscarPaciente.Controls.Add(txtGrupo);
            pnlBuscarPaciente.Location = new Point(31, 75);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1662, 332);
            pnlBuscarPaciente.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEliminar.Location = new Point(1466, 75);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 33);
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
            btnEditar.Location = new Point(1466, 26);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 33);
            btnEditar.TabIndex = 47;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnFemenino.Location = new Point(337, 288);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(39, 29);
            rbtnFemenino.TabIndex = 46;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "F";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMasculino.Location = new Point(258, 288);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(47, 29);
            rbtnMasculino.TabIndex = 45;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "M";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F);
            lblSexo.Location = new Point(106, 290);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 44;
            lblSexo.Text = "Sexo:";
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
            label2.Location = new Point(1053, 66);
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
            label1.Location = new Point(954, 66);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 31;
            label1.Text = "/";
            // 
            // txtDia
            // 
            txtDia.BackColor = Color.White;
            txtDia.BorderStyle = BorderStyle.FixedSingle;
            txtDia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDia.Location = new Point(1081, 64);
            txtDia.MaxLength = 1;
            txtDia.Name = "txtDia";
            txtDia.PlaceholderText = "Día";
            txtDia.Size = new Size(67, 33);
            txtDia.TabIndex = 30;
            // 
            // txtMes
            // 
            txtMes.BackColor = Color.White;
            txtMes.BorderStyle = BorderStyle.FixedSingle;
            txtMes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMes.Location = new Point(980, 64);
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
            lblConsultasBuscarAvisoFecha.Location = new Point(878, 100);
            lblConsultasBuscarAvisoFecha.Name = "lblConsultasBuscarAvisoFecha";
            lblConsultasBuscarAvisoFecha.Size = new Size(270, 33);
            lblConsultasBuscarAvisoFecha.TabIndex = 28;
            lblConsultasBuscarAvisoFecha.Text = "Ingrese unicamente numeros.";
            // 
            // txtAño
            // 
            txtAño.BackColor = Color.White;
            txtAño.BorderStyle = BorderStyle.FixedSingle;
            txtAño.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAño.Location = new Point(881, 64);
            txtAño.MaxLength = 1;
            txtAño.Name = "txtAño";
            txtAño.PlaceholderText = "Año";
            txtAño.Size = new Size(67, 33);
            txtAño.TabIndex = 27;
            // 
            // lblConsultasBuscarFecha
            // 
            lblConsultasBuscarFecha.AutoSize = true;
            lblConsultasBuscarFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarFecha.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarFecha.Location = new Point(881, 26);
            lblConsultasBuscarFecha.Name = "lblConsultasBuscarFecha";
            lblConsultasBuscarFecha.Size = new Size(67, 25);
            lblConsultasBuscarFecha.TabIndex = 23;
            lblConsultasBuscarFecha.Text = "Fecha:";
            // 
            // cbxCITA
            // 
            cbxCITA.AutoSize = true;
            cbxCITA.Font = new Font("Segoe UI", 14.25F);
            cbxCITA.Location = new Point(495, 288);
            cbxCITA.Name = "cbxCITA";
            cbxCITA.Size = new Size(284, 29);
            cbxCITA.TabIndex = 22;
            cbxCITA.Text = "Cita (si se programo cita o no)";
            cbxCITA.UseVisualStyleBackColor = true;
            // 
            // cbxCIR
            // 
            cbxCIR.AutoSize = true;
            cbxCIR.Font = new Font("Segoe UI", 14.25F);
            cbxCIR.Location = new Point(495, 241);
            cbxCIR.Name = "cbxCIR";
            cbxCIR.Size = new Size(234, 29);
            cbxCIR.TabIndex = 21;
            cbxCIR.Text = "CIR (si llevó receta o no)";
            cbxCIR.UseVisualStyleBackColor = true;
            // 
            // lblConsultaBuscarConsulta
            // 
            lblConsultaBuscarConsulta.AutoSize = true;
            lblConsultaBuscarConsulta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultaBuscarConsulta.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultaBuscarConsulta.Location = new Point(495, 26);
            lblConsultaBuscarConsulta.Name = "lblConsultaBuscarConsulta";
            lblConsultaBuscarConsulta.Size = new Size(95, 25);
            lblConsultaBuscarConsulta.TabIndex = 20;
            lblConsultaBuscarConsulta.Text = "Consulta:";
            // 
            // lblConsultasBuscarPacientes
            // 
            lblConsultasBuscarPacientes.AutoSize = true;
            lblConsultasBuscarPacientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarPacientes.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarPacientes.Location = new Point(106, 26);
            lblConsultasBuscarPacientes.Name = "lblConsultasBuscarPacientes";
            lblConsultasBuscarPacientes.Size = new Size(92, 25);
            lblConsultasBuscarPacientes.TabIndex = 19;
            lblConsultasBuscarPacientes.Text = "Paciente:";
            // 
            // cmbDiagnostico
            // 
            cmbDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiagnostico.ForeColor = Color.Black;
            cmbDiagnostico.FormattingEnabled = true;
            cmbDiagnostico.Location = new Point(495, 173);
            cmbDiagnostico.Name = "cmbDiagnostico";
            cmbDiagnostico.Size = new Size(270, 33);
            cmbDiagnostico.TabIndex = 18;
            // 
            // cmbTurno
            // 
            cmbTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTurno.ForeColor = Color.Black;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(495, 63);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(270, 33);
            cmbTurno.TabIndex = 17;
            // 
            // cmbConsultor
            // 
            cmbConsultor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbConsultor.ForeColor = Color.Black;
            cmbConsultor.FormattingEnabled = true;
            cmbConsultor.Location = new Point(495, 114);
            cmbConsultor.Name = "cmbConsultor";
            cmbConsultor.Size = new Size(270, 33);
            cmbConsultor.TabIndex = 16;
            // 
            // pcbFotoPaciente
            // 
            pcbFotoPaciente.Image = Properties.Resources.fotoperfilusuariosinfoto;
            pcbFotoPaciente.Location = new Point(1232, 26);
            pcbFotoPaciente.Name = "pcbFotoPaciente";
            pcbFotoPaciente.Size = new Size(200, 200);
            pcbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoPaciente.TabIndex = 9;
            pcbFotoPaciente.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(239, 239, 239);
            button1.Location = new Point(1053, 233);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 33);
            button1.TabIndex = 11;
            button1.Text = "Vaciar campos";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(10, 64, 88);
            btnBuscarPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPaciente.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarPaciente.Location = new Point(881, 233);
            btnBuscarPaciente.Margin = new Padding(0);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(150, 33);
            btnBuscarPaciente.TabIndex = 10;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Location = new Point(106, 64);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(106, 114);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 33);
            cmbCarrera.TabIndex = 7;
            // 
            // cmbCuatri
            // 
            cmbCuatri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuatri.ForeColor = Color.Black;
            cmbCuatri.FormattingEnabled = true;
            cmbCuatri.Location = new Point(106, 173);
            cmbCuatri.Name = "cmbCuatri";
            cmbCuatri.Size = new Size(270, 33);
            cmbCuatri.TabIndex = 6;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(106, 235);
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
            Controls.Add(dataGridView1);
            Controls.Add(pnlBuscarPaciente);
            Controls.Add(lblConsultasBuscarTitulo);
            Name = "frmConsultasBuscar";
            Text = "frmConsultasBuscar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlBuscarPaciente.ResumeLayout(false);
            pnlBuscarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlBuscarPaciente;
        private PictureBox pcbFotoPaciente;
        private Button button1;
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
        private TextBox txtAño;
        private Label label2;
        private Label label1;
        private TextBox txtDia;
        private TextBox txtMes;
        private PictureBox pcbIconoBuscar;
        private TextBox txtBuscarPorNumConsul;
        private Label label3;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private Label lblSexo;
        private Button btnEliminar;
        private Button btnEditar;
    }
}
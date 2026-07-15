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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblConsultasBuscarAvisoFecha = new Label();
            txtConsultaAno = new TextBox();
            lblConsultasBuscarFecha = new Label();
            cbxCITA = new CheckBox();
            cbxCIR = new CheckBox();
            lblConsultaBuscarConsulta = new Label();
            lblConsultasBuscarPacientes = new Label();
            cmbDiagnostico = new ComboBox();
            cmbTurno = new ComboBox();
            cmbConsultor = new ComboBox();
            lblSexoF = new Label();
            lblSexoM = new Label();
            lblSexo = new Label();
            pcbFotoPaciente = new PictureBox();
            button1 = new Button();
            btnBuscarPaciente = new Button();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbCuatri = new ComboBox();
            txtGrupo = new TextBox();
            lblAvisoAntesDeBuscar = new Label();
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
            dataGridView1.Location = new Point(11, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1110, 313);
            dataGridView1.TabIndex = 13;
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(label3);
            pnlBuscarPaciente.Controls.Add(label2);
            pnlBuscarPaciente.Controls.Add(label1);
            pnlBuscarPaciente.Controls.Add(textBox2);
            pnlBuscarPaciente.Controls.Add(textBox1);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarAvisoFecha);
            pnlBuscarPaciente.Controls.Add(txtConsultaAno);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarFecha);
            pnlBuscarPaciente.Controls.Add(cbxCITA);
            pnlBuscarPaciente.Controls.Add(cbxCIR);
            pnlBuscarPaciente.Controls.Add(lblConsultaBuscarConsulta);
            pnlBuscarPaciente.Controls.Add(lblConsultasBuscarPacientes);
            pnlBuscarPaciente.Controls.Add(cmbDiagnostico);
            pnlBuscarPaciente.Controls.Add(cmbTurno);
            pnlBuscarPaciente.Controls.Add(cmbConsultor);
            pnlBuscarPaciente.Controls.Add(lblSexoF);
            pnlBuscarPaciente.Controls.Add(lblSexoM);
            pnlBuscarPaciente.Controls.Add(lblSexo);
            pnlBuscarPaciente.Controls.Add(pcbFotoPaciente);
            pnlBuscarPaciente.Controls.Add(button1);
            pnlBuscarPaciente.Controls.Add(btnBuscarPaciente);
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbCuatri);
            pnlBuscarPaciente.Controls.Add(txtGrupo);
            pnlBuscarPaciente.Location = new Point(11, 75);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1094, 253);
            pnlBuscarPaciente.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 158, 158);
            label3.Location = new Point(584, 217);
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
            label2.Location = new Point(752, 40);
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
            label1.Location = new Point(660, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 31;
            label1.Text = "/";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(774, 36);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Día";
            textBox2.Size = new Size(67, 33);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(683, 36);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Més";
            textBox1.Size = new Size(67, 33);
            textBox1.TabIndex = 29;
            // 
            // lblConsultasBuscarAvisoFecha
            // 
            lblConsultasBuscarAvisoFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConsultasBuscarAvisoFecha.ForeColor = Color.FromArgb(158, 158, 158);
            lblConsultasBuscarAvisoFecha.Location = new Point(591, 72);
            lblConsultasBuscarAvisoFecha.Name = "lblConsultasBuscarAvisoFecha";
            lblConsultasBuscarAvisoFecha.Size = new Size(270, 33);
            lblConsultasBuscarAvisoFecha.TabIndex = 28;
            lblConsultasBuscarAvisoFecha.Text = "Ingrese unicamente numeros.";
            // 
            // txtConsultaAno
            // 
            txtConsultaAno.BackColor = Color.White;
            txtConsultaAno.BorderStyle = BorderStyle.FixedSingle;
            txtConsultaAno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsultaAno.Location = new Point(591, 36);
            txtConsultaAno.MaxLength = 1;
            txtConsultaAno.Name = "txtConsultaAno";
            txtConsultaAno.PlaceholderText = "Año";
            txtConsultaAno.Size = new Size(67, 33);
            txtConsultaAno.TabIndex = 27;
            // 
            // lblConsultasBuscarFecha
            // 
            lblConsultasBuscarFecha.AutoSize = true;
            lblConsultasBuscarFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarFecha.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarFecha.Location = new Point(591, 8);
            lblConsultasBuscarFecha.Name = "lblConsultasBuscarFecha";
            lblConsultasBuscarFecha.Size = new Size(67, 25);
            lblConsultasBuscarFecha.TabIndex = 23;
            lblConsultasBuscarFecha.Text = "Fecha:";
            // 
            // cbxCITA
            // 
            cbxCITA.AutoSize = true;
            cbxCITA.Font = new Font("Segoe UI", 14.25F);
            cbxCITA.Location = new Point(304, 203);
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
            cbxCIR.Location = new Point(304, 161);
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
            lblConsultaBuscarConsulta.Location = new Point(304, 8);
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
            lblConsultasBuscarPacientes.Location = new Point(21, 8);
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
            cmbDiagnostico.Location = new Point(304, 122);
            cmbDiagnostico.Name = "cmbDiagnostico";
            cmbDiagnostico.Size = new Size(270, 33);
            cmbDiagnostico.TabIndex = 18;
            // 
            // cmbTurno
            // 
            cmbTurno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTurno.ForeColor = Color.Black;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(304, 36);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(270, 33);
            cmbTurno.TabIndex = 17;
            // 
            // cmbConsultor
            // 
            cmbConsultor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbConsultor.ForeColor = Color.Black;
            cmbConsultor.FormattingEnabled = true;
            cmbConsultor.Location = new Point(304, 79);
            cmbConsultor.Name = "cmbConsultor";
            cmbConsultor.Size = new Size(270, 33);
            cmbConsultor.TabIndex = 16;
            // 
            // lblSexoF
            // 
            lblSexoF.AutoSize = true;
            lblSexoF.Font = new Font("Segoe UI", 14.25F);
            lblSexoF.Location = new Point(201, 215);
            lblSexoF.Name = "lblSexoF";
            lblSexoF.Size = new Size(21, 25);
            lblSexoF.TabIndex = 14;
            lblSexoF.Text = "F";
            // 
            // lblSexoM
            // 
            lblSexoM.AutoSize = true;
            lblSexoM.Font = new Font("Segoe UI", 14.25F);
            lblSexoM.Location = new Point(123, 215);
            lblSexoM.Name = "lblSexoM";
            lblSexoM.Size = new Size(29, 25);
            lblSexoM.TabIndex = 13;
            lblSexoM.Text = "M";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 14.25F);
            lblSexo.Location = new Point(18, 215);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo:";
            // 
            // pcbFotoPaciente
            // 
            pcbFotoPaciente.Image = Properties.Resources.Logo_ColorFondoVerde;
            pcbFotoPaciente.Location = new Point(922, 17);
            pcbFotoPaciente.Name = "pcbFotoPaciente";
            pcbFotoPaciente.Size = new Size(158, 145);
            pcbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoPaciente.TabIndex = 9;
            pcbFotoPaciente.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(239, 239, 239);
            button1.Location = new Point(935, 184);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(145, 33);
            button1.TabIndex = 11;
            button1.Text = "Vaciar campos";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(10, 64, 88);
            btnBuscarPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPaciente.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarPaciente.Location = new Point(774, 184);
            btnBuscarPaciente.Margin = new Padding(0);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(145, 33);
            btnBuscarPaciente.TabIndex = 10;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Location = new Point(20, 36);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(21, 79);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 33);
            cmbCarrera.TabIndex = 7;
            // 
            // cmbCuatri
            // 
            cmbCuatri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuatri.ForeColor = Color.Black;
            cmbCuatri.FormattingEnabled = true;
            cmbCuatri.Location = new Point(21, 125);
            cmbCuatri.Name = "cmbCuatri";
            cmbCuatri.Size = new Size(270, 33);
            cmbCuatri.TabIndex = 6;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.White;
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(21, 173);
            txtGrupo.MaxLength = 1;
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Grupo";
            txtGrupo.Size = new Size(270, 33);
            txtGrupo.TabIndex = 1;
            // 
            // lblAvisoAntesDeBuscar
            // 
            lblAvisoAntesDeBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvisoAntesDeBuscar.ForeColor = Color.FromArgb(158, 158, 158);
            lblAvisoAntesDeBuscar.Location = new Point(535, 377);
            lblAvisoAntesDeBuscar.Name = "lblAvisoAntesDeBuscar";
            lblAvisoAntesDeBuscar.Size = new Size(287, 57);
            lblAvisoAntesDeBuscar.TabIndex = 15;
            lblAvisoAntesDeBuscar.Text = "Asegurese de llenar por lo menos un campo antes de buscar.";
            // 
            // lblConsultasBuscarTitulo
            // 
            lblConsultasBuscarTitulo.AutoSize = true;
            lblConsultasBuscarTitulo.BackColor = Color.Transparent;
            lblConsultasBuscarTitulo.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultasBuscarTitulo.ForeColor = Color.FromArgb(23, 147, 209);
            lblConsultasBuscarTitulo.Location = new Point(11, 4);
            lblConsultasBuscarTitulo.Name = "lblConsultasBuscarTitulo";
            lblConsultasBuscarTitulo.Size = new Size(721, 68);
            lblConsultasBuscarTitulo.TabIndex = 11;
            lblConsultasBuscarTitulo.Text = "Datos de la consulta a buscar";
            // 
            // pcbIconoBuscar
            // 
            pcbIconoBuscar.Image = Properties.Resources.IconoBuscar;
            pcbIconoBuscar.Location = new Point(1070, 25);
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
            txtBuscarPorNumConsul.Location = new Point(796, 25);
            txtBuscarPorNumConsul.Name = "txtBuscarPorNumConsul";
            txtBuscarPorNumConsul.PlaceholderText = "Buscar por Num. consulta";
            txtBuscarPorNumConsul.Size = new Size(267, 33);
            txtBuscarPorNumConsul.TabIndex = 16;
            // 
            // frmConsultasBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 672);
            Controls.Add(pcbIconoBuscar);
            Controls.Add(txtBuscarPorNumConsul);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBuscarPaciente);
            Controls.Add(lblConsultasBuscarTitulo);
            Controls.Add(lblAvisoAntesDeBuscar);
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
        private Label lblAvisoAntesDeBuscar;
        private Label lblSexoF;
        private Label lblSexoM;
        private Label lblSexo;
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
        private TextBox txtConsultaAno;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pcbIconoBuscar;
        private TextBox txtBuscarPorNumConsul;
        private Label label3;
    }
}
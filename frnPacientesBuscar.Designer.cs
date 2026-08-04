namespace Vitalis
{
    partial class frnPacientesBuscar
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlBuscarPaciente = new Panel();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbGrado = new ComboBox();
            label7 = new Label();
            txtGrupo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            pcbFotoPaciente = new PictureBox();
            btnVaciarCampos = new Button();
            txtApellidoMaPaciente = new TextBox();
            txtApellidoPaPaciente = new TextBox();
            txtNombrePaciente = new TextBox();
            lblVitalisInicio = new Label();
            txtBuscarMatricula = new TextBox();
            pcbBuscarIcon = new PictureBox();
            dgvPacientesBuscar = new DataGridView();
            label8 = new Label();
            pnlBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscarIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesBuscar).BeginInit();
            SuspendLayout();
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbGrado);
            pnlBuscarPaciente.Controls.Add(label7);
            pnlBuscarPaciente.Controls.Add(txtGrupo);
            pnlBuscarPaciente.Controls.Add(label6);
            pnlBuscarPaciente.Controls.Add(label5);
            pnlBuscarPaciente.Controls.Add(label4);
            pnlBuscarPaciente.Controls.Add(label3);
            pnlBuscarPaciente.Controls.Add(label2);
            pnlBuscarPaciente.Controls.Add(label1);
            pnlBuscarPaciente.Controls.Add(button1);
            pnlBuscarPaciente.Controls.Add(button3);
            pnlBuscarPaciente.Controls.Add(button2);
            pnlBuscarPaciente.Controls.Add(pcbFotoPaciente);
            pnlBuscarPaciente.Controls.Add(btnVaciarCampos);
            pnlBuscarPaciente.Controls.Add(txtApellidoMaPaciente);
            pnlBuscarPaciente.Controls.Add(txtApellidoPaPaciente);
            pnlBuscarPaciente.Controls.Add(txtNombrePaciente);
            pnlBuscarPaciente.Location = new Point(32, 96);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1657, 263);
            pnlBuscarPaciente.TabIndex = 1;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.BackColor = Color.FromArgb(239, 239, 239);
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Items.AddRange(new object[] { " ", "Alumno", "Trabajador" });
            cmbTipoPaciente.Location = new Point(545, 55);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(300, 33);
            cmbTipoPaciente.TabIndex = 8;
            cmbTipoPaciente.SelectedIndexChanged += RealizarBusquedaFiltros;
            // 
            // cmbCarrera
            // 
            cmbCarrera.BackColor = Color.FromArgb(239, 239, 239);
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(545, 116);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(300, 33);
            cmbCarrera.TabIndex = 7;
            cmbCarrera.TextChanged += RealizarBusquedaFiltros;
            // 
            // cmbGrado
            // 
            cmbGrado.BackColor = Color.FromArgb(239, 239, 239);
            cmbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGrado.ForeColor = Color.Black;
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Items.AddRange(new object[] { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbGrado.Location = new Point(545, 179);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(300, 33);
            cmbGrado.TabIndex = 6;
            cmbGrado.TextChanged += RealizarBusquedaFiltros;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 147, 209);
            label7.Location = new Point(860, 58);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 55;
            label7.Text = "Grupo:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGrupo
            // 
            txtGrupo.BackColor = Color.FromArgb(239, 239, 239);
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrupo.Location = new Point(941, 55);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.PlaceholderText = "Grupo del paciente";
            txtGrupo.Size = new Size(300, 33);
            txtGrupo.TabIndex = 54;
            txtGrupo.TextChanged += RealizarBusquedaFiltros;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(467, 183);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 53;
            label6.Text = "Grado:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 147, 209);
            label5.Location = new Point(467, 120);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 52;
            label5.Text = "Carrera:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(467, 57);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 51;
            label4.Text = "Tipo:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 147, 209);
            label3.Location = new Point(28, 188);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 50;
            label3.Text = "Apellido M.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(28, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 49;
            label2.Text = "Apellido P.:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 48;
            label1.Text = "Nombre(s):";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 64, 88);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(239, 239, 239);
            button1.Location = new Point(1479, 122);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(160, 35);
            button1.TabIndex = 47;
            button1.Text = "Ver expediente";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(239, 239, 239);
            button3.Location = new Point(1479, 190);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(160, 35);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Orange;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(239, 239, 239);
            button2.Location = new Point(1479, 48);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(160, 35);
            button2.TabIndex = 16;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pcbFotoPaciente
            // 
            pcbFotoPaciente.Image = Properties.Resources.fotoperfilusuariosinfoto;
            pcbFotoPaciente.Location = new Point(1259, 36);
            pcbFotoPaciente.Name = "pcbFotoPaciente";
            pcbFotoPaciente.Size = new Size(200, 200);
            pcbFotoPaciente.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoPaciente.TabIndex = 9;
            pcbFotoPaciente.TabStop = false;
            // 
            // btnVaciarCampos
            // 
            btnVaciarCampos.Anchor = AnchorStyles.None;
            btnVaciarCampos.BackColor = Color.Orange;
            btnVaciarCampos.FlatAppearance.BorderSize = 0;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(1060, 183);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(160, 35);
            btnVaciarCampos.TabIndex = 11;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            btnVaciarCampos.Click += btnVaciarCampos_Click;
            // 
            // txtApellidoMaPaciente
            // 
            txtApellidoMaPaciente.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoMaPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoMaPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaPaciente.Location = new Point(147, 181);
            txtApellidoMaPaciente.Name = "txtApellidoMaPaciente";
            txtApellidoMaPaciente.PlaceholderText = "Apellido Materno a buscar";
            txtApellidoMaPaciente.Size = new Size(300, 33);
            txtApellidoMaPaciente.TabIndex = 5;
            txtApellidoMaPaciente.TextChanged += RealizarBusquedaFiltros;
            // 
            // txtApellidoPaPaciente
            // 
            txtApellidoPaPaciente.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoPaPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPaPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaPaciente.Location = new Point(147, 118);
            txtApellidoPaPaciente.Name = "txtApellidoPaPaciente";
            txtApellidoPaPaciente.PlaceholderText = "Apellido paterno a buscar";
            txtApellidoPaPaciente.Size = new Size(300, 33);
            txtApellidoPaPaciente.TabIndex = 4;
            txtApellidoPaPaciente.TextChanged += RealizarBusquedaFiltros;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.BackColor = Color.FromArgb(239, 239, 239);
            txtNombrePaciente.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePaciente.Location = new Point(147, 54);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.PlaceholderText = "Nombre(s) a buscar";
            txtNombrePaciente.Size = new Size(300, 33);
            txtNombrePaciente.TabIndex = 1;
            txtNombrePaciente.TextChanged += RealizarBusquedaFiltros;
            // 
            // lblVitalisInicio
            // 
            lblVitalisInicio.BackColor = Color.Transparent;
            lblVitalisInicio.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitalisInicio.ForeColor = Color.FromArgb(23, 147, 209);
            lblVitalisInicio.Location = new Point(32, 25);
            lblVitalisInicio.Name = "lblVitalisInicio";
            lblVitalisInicio.Size = new Size(715, 68);
            lblVitalisInicio.TabIndex = 6;
            lblVitalisInicio.Text = "Datos del paciente a buscar";
            // 
            // txtBuscarMatricula
            // 
            txtBuscarMatricula.BackColor = Color.White;
            txtBuscarMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarMatricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarMatricula.Location = new Point(1348, 57);
            txtBuscarMatricula.Name = "txtBuscarMatricula";
            txtBuscarMatricula.PlaceholderText = "Buscar por matricula";
            txtBuscarMatricula.Size = new Size(300, 33);
            txtBuscarMatricula.TabIndex = 8;
            // 
            // pcbBuscarIcon
            // 
            pcbBuscarIcon.Image = Properties.Resources.IconoBuscar;
            pcbBuscarIcon.Location = new Point(1654, 55);
            pcbBuscarIcon.Name = "pcbBuscarIcon";
            pcbBuscarIcon.Size = new Size(35, 35);
            pcbBuscarIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscarIcon.TabIndex = 9;
            pcbBuscarIcon.TabStop = false;
            pcbBuscarIcon.Click += pcbBuscarIcon_Click;
            // 
            // dgvPacientesBuscar
            // 
            dgvPacientesBuscar.AllowUserToAddRows = false;
            dgvPacientesBuscar.AllowUserToDeleteRows = false;
            dgvPacientesBuscar.AllowUserToResizeColumns = false;
            dgvPacientesBuscar.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(239, 239, 239);
            dgvPacientesBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPacientesBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientesBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientesBuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPacientesBuscar.BackgroundColor = Color.White;
            dgvPacientesBuscar.BorderStyle = BorderStyle.None;
            dgvPacientesBuscar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPacientesBuscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPacientesBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPacientesBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPacientesBuscar.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPacientesBuscar.EnableHeadersVisualStyles = false;
            dgvPacientesBuscar.GridColor = Color.White;
            dgvPacientesBuscar.Location = new Point(32, 397);
            dgvPacientesBuscar.MultiSelect = false;
            dgvPacientesBuscar.Name = "dgvPacientesBuscar";
            dgvPacientesBuscar.ReadOnly = true;
            dgvPacientesBuscar.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dgvPacientesBuscar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvPacientesBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientesBuscar.Size = new Size(1657, 518);
            dgvPacientesBuscar.TabIndex = 10;
            dgvPacientesBuscar.CellContentClick += dgvPacientesBuscar_CellContentClick;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 147, 209);
            label8.Location = new Point(1135, 30);
            label8.Name = "label8";
            label8.Size = new Size(197, 60);
            label8.TabIndex = 56;
            label8.Text = "Buscar directamente por matricula:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frnPacientesBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(label8);
            Controls.Add(dgvPacientesBuscar);
            Controls.Add(pcbBuscarIcon);
            Controls.Add(txtBuscarMatricula);
            Controls.Add(lblVitalisInicio);
            Controls.Add(pnlBuscarPaciente);
            Name = "frnPacientesBuscar";
            Text = " ";
            pnlBuscarPaciente.ResumeLayout(false);
            pnlBuscarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscarIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePaciente;
        private Panel pnlBuscarPaciente;
        private TextBox txtNombrePaciente;
        private Label lblVitalisInicio;
        private TextBox txtApellidoPaPaciente;
        private TextBox txtApellidoMaPaciente;
        private ComboBox cmbTipoPaciente;
        private ComboBox cmbCarrera;
        private PictureBox pcbFotoPaciente;
        private Button btnVaciarCampos;
        private TextBox txtBuscarMatricula;
        private PictureBox pcbBuscarIcon;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvPacientesBuscar;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbGrado;
        private Label label7;
        private TextBox txtGrupo;
        private Label label8;
    }
}
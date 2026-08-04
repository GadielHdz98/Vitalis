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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblConsultasBuscarTitulo = new Label();
            pcbIconoBuscar = new PictureBox();
            txtBuscarPorNumConsul = new TextBox();
            toolTip1 = new ToolTip(components);
            pnlBuscarPaciente = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label9 = new Label();
            chkCita = new CheckBox();
            chkCIR = new CheckBox();
            cmbDiagnostico = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbGrado = new ComboBox();
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
            txtApellidoMa = new TextBox();
            txtApellidoPa = new TextBox();
            txtNombre = new TextBox();
            dgvConsultasBuscar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).BeginInit();
            pnlBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultasBuscar).BeginInit();
            SuspendLayout();
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
            toolTip1.SetToolTip(pcbIconoBuscar, "Buscar consulta.");
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
            toolTip1.SetToolTip(txtBuscarPorNumConsul, "Buscar consulta por numero de matricula.");
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(button6);
            pnlBuscarPaciente.Controls.Add(button5);
            pnlBuscarPaciente.Controls.Add(button4);
            pnlBuscarPaciente.Controls.Add(label9);
            pnlBuscarPaciente.Controls.Add(chkCita);
            pnlBuscarPaciente.Controls.Add(chkCIR);
            pnlBuscarPaciente.Controls.Add(cmbDiagnostico);
            pnlBuscarPaciente.Controls.Add(label7);
            pnlBuscarPaciente.Controls.Add(label8);
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbGrado);
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
            pnlBuscarPaciente.Controls.Add(txtApellidoMa);
            pnlBuscarPaciente.Controls.Add(txtApellidoPa);
            pnlBuscarPaciente.Controls.Add(txtNombre);
            pnlBuscarPaciente.Location = new Point(31, 85);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1657, 293);
            pnlBuscarPaciente.TabIndex = 18;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.Orange;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(239, 239, 239);
            button6.Location = new Point(1092, 238);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(160, 35);
            button6.TabIndex = 65;
            button6.Text = "Vaciar campos";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Orange;
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(239, 239, 239);
            button5.Location = new Point(1488, 47);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(160, 35);
            button5.TabIndex = 64;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(239, 239, 239);
            button4.Location = new Point(1488, 109);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(160, 35);
            button4.TabIndex = 63;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(23, 147, 209);
            label9.Location = new Point(835, 57);
            label9.Name = "label9";
            label9.Size = new Size(123, 25);
            label9.TabIndex = 59;
            label9.Text = "Diagnostico:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkCita
            // 
            chkCita.AutoSize = true;
            chkCita.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCita.ForeColor = Color.FromArgb(23, 147, 209);
            chkCita.Location = new Point(838, 180);
            chkCita.Name = "chkCita";
            chkCita.Size = new Size(252, 29);
            chkCita.TabIndex = 62;
            chkCita.Text = "Cita (si se programo cita)";
            chkCita.UseVisualStyleBackColor = true;
            chkCita.CheckedChanged += actualizarBusquedaDinamica;
            // 
            // chkCIR
            // 
            chkCIR.AutoSize = true;
            chkCIR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCIR.ForeColor = Color.FromArgb(23, 147, 209);
            chkCIR.Location = new Point(838, 115);
            chkCIR.Name = "chkCIR";
            chkCIR.Size = new Size(245, 29);
            chkCIR.TabIndex = 61;
            chkCIR.Text = "CIR (si llevó receta o no)";
            chkCIR.UseVisualStyleBackColor = true;
            chkCIR.CheckedChanged += actualizarBusquedaDinamica;
            // 
            // cmbDiagnostico
            // 
            cmbDiagnostico.BackColor = Color.FromArgb(239, 239, 239);
            cmbDiagnostico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiagnostico.ForeColor = Color.Black;
            cmbDiagnostico.FormattingEnabled = true;
            cmbDiagnostico.Items.AddRange(new object[] { " ", "Alumno", "Trabajador" });
            cmbDiagnostico.Location = new Point(952, 54);
            cmbDiagnostico.Name = "cmbDiagnostico";
            cmbDiagnostico.Size = new Size(300, 33);
            cmbDiagnostico.TabIndex = 58;
            cmbDiagnostico.SelectedIndexChanged += actualizarBusquedaDinamica;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 147, 209);
            label7.Location = new Point(838, 14);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 57;
            label7.Text = "Consulta:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 147, 209);
            label8.Location = new Point(28, 14);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 56;
            label8.Text = "Paciente:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.BackColor = Color.FromArgb(239, 239, 239);
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoPaciente.ForeColor = Color.Black;
            cmbTipoPaciente.FormattingEnabled = true;
            cmbTipoPaciente.Items.AddRange(new object[] { " ", "Alumno", "Trabajador" });
            cmbTipoPaciente.Location = new Point(529, 53);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(300, 33);
            cmbTipoPaciente.TabIndex = 8;
            cmbTipoPaciente.SelectedIndexChanged += actualizarBusquedaDinamica;
            // 
            // cmbCarrera
            // 
            cmbCarrera.BackColor = Color.FromArgb(239, 239, 239);
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(529, 114);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(300, 33);
            cmbCarrera.TabIndex = 7;
            cmbCarrera.SelectedIndexChanged += actualizarBusquedaDinamica;
            // 
            // cmbGrado
            // 
            cmbGrado.BackColor = Color.FromArgb(239, 239, 239);
            cmbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGrado.ForeColor = Color.Black;
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Items.AddRange(new object[] { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbGrado.Location = new Point(529, 177);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(300, 33);
            cmbGrado.TabIndex = 6;
            cmbGrado.SelectedIndexChanged += actualizarBusquedaDinamica;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(449, 183);
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
            label5.Location = new Point(449, 120);
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
            label4.Location = new Point(449, 57);
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
            button1.Location = new Point(2207, 218);
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
            button3.Location = new Point(2207, 286);
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
            button2.Location = new Point(2207, 144);
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
            pcbFotoPaciente.Location = new Point(1276, 33);
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
            btnVaciarCampos.Location = new Point(1712, 269);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(160, 35);
            btnVaciarCampos.TabIndex = 11;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            // 
            // txtApellidoMa
            // 
            txtApellidoMa.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoMa.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoMa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMa.Location = new Point(147, 181);
            txtApellidoMa.Name = "txtApellidoMa";
            txtApellidoMa.PlaceholderText = "Apellido Materno a buscar";
            txtApellidoMa.Size = new Size(300, 33);
            txtApellidoMa.TabIndex = 5;
            txtApellidoMa.TextChanged += actualizarBusquedaDinamica;
            // 
            // txtApellidoPa
            // 
            txtApellidoPa.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoPa.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPa.Location = new Point(147, 118);
            txtApellidoPa.Name = "txtApellidoPa";
            txtApellidoPa.PlaceholderText = "Apellido paterno a buscar";
            txtApellidoPa.Size = new Size(300, 33);
            txtApellidoPa.TabIndex = 4;
            txtApellidoPa.TextChanged += actualizarBusquedaDinamica;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(239, 239, 239);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(147, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre(s) a buscar";
            txtNombre.Size = new Size(300, 33);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += actualizarBusquedaDinamica;
            // 
            // dgvConsultasBuscar
            // 
            dgvConsultasBuscar.AllowUserToAddRows = false;
            dgvConsultasBuscar.AllowUserToDeleteRows = false;
            dgvConsultasBuscar.AllowUserToResizeColumns = false;
            dgvConsultasBuscar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvConsultasBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultasBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsultasBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasBuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultasBuscar.BackgroundColor = Color.White;
            dgvConsultasBuscar.BorderStyle = BorderStyle.None;
            dgvConsultasBuscar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultasBuscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsultasBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultasBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsultasBuscar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultasBuscar.EnableHeadersVisualStyles = false;
            dgvConsultasBuscar.GridColor = Color.White;
            dgvConsultasBuscar.Location = new Point(31, 408);
            dgvConsultasBuscar.MultiSelect = false;
            dgvConsultasBuscar.Name = "dgvConsultasBuscar";
            dgvConsultasBuscar.ReadOnly = true;
            dgvConsultasBuscar.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvConsultasBuscar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultasBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasBuscar.Size = new Size(1657, 518);
            dgvConsultasBuscar.TabIndex = 19;
            // 
            // frmConsultasBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(dgvConsultasBuscar);
            Controls.Add(pnlBuscarPaciente);
            Controls.Add(pcbIconoBuscar);
            Controls.Add(txtBuscarPorNumConsul);
            Controls.Add(lblConsultasBuscarTitulo);
            Name = "frmConsultasBuscar";
            Text = "frmConsultasBuscar";
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscar).EndInit();
            pnlBuscarPaciente.ResumeLayout(false);
            pnlBuscarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultasBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cmbDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lblConsultasBuscarTitulo;
        private PictureBox pcbIconoBuscar;
        private TextBox txtBuscarPorNumConsul;
        private ToolTip toolTip1;
        private Panel pnlBuscarPaciente;
        private Label label8;
        private ComboBox cmbTipoPaciente;
        private ComboBox cmbCarrera;
        private ComboBox cmbGrado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private PictureBox pcbFotoPaciente;
        private Button btnVaciarCampos;
        private TextBox txtApellidoMa;
        private TextBox txtApellidoPa;
        private TextBox txtNombre;
        private ComboBox cmbDiagnostico;
        private Label label9;
        private Label label7;
        private CheckBox chkCita;
        private CheckBox chkCIR;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dgvConsultasBuscar;
    }
}
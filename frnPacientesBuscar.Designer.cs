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
            pnlBuscarPaciente = new Panel();
            button3 = new Button();
            button2 = new Button();
            lblAvisoAntesDeBuscar = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pcbFotoPaciente = new PictureBox();
            btnVaciarCampos = new Button();
            btnBuscarPaciente = new Button();
            cmbTipoPaciente = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbCuatri = new ComboBox();
            txtApellidoMaternoPaciente = new TextBox();
            txtApellidoPaternoPaciente = new TextBox();
            txtNombrePaciente = new TextBox();
            lblVitalisInicio = new Label();
            dataGridView1 = new DataGridView();
            txtBuscarMatricula = new TextBox();
            pictureBox1 = new PictureBox();
            pnlBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBuscarPaciente
            // 
            pnlBuscarPaciente.BackColor = Color.White;
            pnlBuscarPaciente.Controls.Add(button3);
            pnlBuscarPaciente.Controls.Add(button2);
            pnlBuscarPaciente.Controls.Add(lblAvisoAntesDeBuscar);
            pnlBuscarPaciente.Controls.Add(label3);
            pnlBuscarPaciente.Controls.Add(label2);
            pnlBuscarPaciente.Controls.Add(label1);
            pnlBuscarPaciente.Controls.Add(pcbFotoPaciente);
            pnlBuscarPaciente.Controls.Add(btnVaciarCampos);
            pnlBuscarPaciente.Controls.Add(btnBuscarPaciente);
            pnlBuscarPaciente.Controls.Add(cmbTipoPaciente);
            pnlBuscarPaciente.Controls.Add(cmbCarrera);
            pnlBuscarPaciente.Controls.Add(cmbCuatri);
            pnlBuscarPaciente.Controls.Add(txtApellidoMaternoPaciente);
            pnlBuscarPaciente.Controls.Add(txtApellidoPaternoPaciente);
            pnlBuscarPaciente.Controls.Add(txtNombrePaciente);
            pnlBuscarPaciente.Location = new Point(11, 75);
            pnlBuscarPaciente.Name = "pnlBuscarPaciente";
            pnlBuscarPaciente.Size = new Size(1094, 186);
            pnlBuscarPaciente.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(239, 239, 239);
            button3.Location = new Point(759, 111);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(145, 33);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 64, 88);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(239, 239, 239);
            button2.Location = new Point(759, 66);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(145, 33);
            button2.TabIndex = 16;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblAvisoAntesDeBuscar
            // 
            lblAvisoAntesDeBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvisoAntesDeBuscar.ForeColor = Color.FromArgb(158, 158, 158);
            lblAvisoAntesDeBuscar.Location = new Point(409, 153);
            lblAvisoAntesDeBuscar.Name = "lblAvisoAntesDeBuscar";
            lblAvisoAntesDeBuscar.Size = new Size(507, 29);
            lblAvisoAntesDeBuscar.TabIndex = 15;
            lblAvisoAntesDeBuscar.Text = "Asegurese de llenar por lo menos un campo antes de buscar.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(782, 25);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 14;
            label3.Text = "F";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(704, 25);
            label2.Name = "label2";
            label2.Size = new Size(29, 25);
            label2.TabIndex = 13;
            label2.Text = "M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(599, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 12;
            label1.Text = "Sexo:";
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
            // btnVaciarCampos
            // 
            btnVaciarCampos.BackColor = Color.DarkGoldenrod;
            btnVaciarCampos.FlatAppearance.BorderSize = 0;
            btnVaciarCampos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaciarCampos.ForeColor = Color.FromArgb(239, 239, 239);
            btnVaciarCampos.Location = new Point(599, 111);
            btnVaciarCampos.Margin = new Padding(0);
            btnVaciarCampos.Name = "btnVaciarCampos";
            btnVaciarCampos.Size = new Size(150, 33);
            btnVaciarCampos.TabIndex = 11;
            btnVaciarCampos.Text = "Vaciar campos";
            btnVaciarCampos.UseVisualStyleBackColor = false;
            btnVaciarCampos.Click += btnVaciarCampos_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(10, 64, 88);
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPaciente.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarPaciente.Location = new Point(599, 66);
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
            cmbTipoPaciente.Location = new Point(309, 22);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(270, 33);
            cmbTipoPaciente.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.ForeColor = Color.Black;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(309, 65);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(270, 33);
            cmbCarrera.TabIndex = 7;
            // 
            // cmbCuatri
            // 
            cmbCuatri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCuatri.ForeColor = Color.Black;
            cmbCuatri.FormattingEnabled = true;
            cmbCuatri.Location = new Point(309, 111);
            cmbCuatri.Name = "cmbCuatri";
            cmbCuatri.Size = new Size(270, 33);
            cmbCuatri.TabIndex = 6;
            // 
            // txtApellidoMaternoPaciente
            // 
            txtApellidoMaternoPaciente.BackColor = Color.White;
            txtApellidoMaternoPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoMaternoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaternoPaciente.Location = new Point(21, 112);
            txtApellidoMaternoPaciente.Name = "txtApellidoMaternoPaciente";
            txtApellidoMaternoPaciente.PlaceholderText = "Apellido Materno";
            txtApellidoMaternoPaciente.Size = new Size(270, 33);
            txtApellidoMaternoPaciente.TabIndex = 5;
            // 
            // txtApellidoPaternoPaciente
            // 
            txtApellidoPaternoPaciente.BackColor = Color.White;
            txtApellidoPaternoPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPaternoPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaternoPaciente.Location = new Point(21, 66);
            txtApellidoPaternoPaciente.Name = "txtApellidoPaternoPaciente";
            txtApellidoPaternoPaciente.PlaceholderText = "Apellido paterno";
            txtApellidoPaternoPaciente.Size = new Size(270, 33);
            txtApellidoPaternoPaciente.TabIndex = 4;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.BackColor = Color.White;
            txtNombrePaciente.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePaciente.Location = new Point(21, 22);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.PlaceholderText = "Nombre(s)";
            txtNombrePaciente.Size = new Size(270, 33);
            txtNombrePaciente.TabIndex = 1;
            // 
            // lblVitalisInicio
            // 
            lblVitalisInicio.BackColor = Color.Transparent;
            lblVitalisInicio.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitalisInicio.ForeColor = Color.FromArgb(23, 147, 209);
            lblVitalisInicio.Location = new Point(11, 4);
            lblVitalisInicio.Name = "lblVitalisInicio";
            lblVitalisInicio.Size = new Size(684, 68);
            lblVitalisInicio.TabIndex = 6;
            lblVitalisInicio.Text = "Datos del paciente a buscar";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1094, 268);
            dataGridView1.TabIndex = 7;
            // 
            // txtBuscarMatricula
            // 
            txtBuscarMatricula.BackColor = Color.White;
            txtBuscarMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarMatricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarMatricula.Location = new Point(782, 26);
            txtBuscarMatricula.Name = "txtBuscarMatricula";
            txtBuscarMatricula.PlaceholderText = "Buscar por matricula";
            txtBuscarMatricula.Size = new Size(267, 33);
            txtBuscarMatricula.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconoBuscar;
            pictureBox1.Location = new Point(1056, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frnPacientesBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 563);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarMatricula);
            Controls.Add(dataGridView1);
            Controls.Add(lblVitalisInicio);
            Controls.Add(pnlBuscarPaciente);
            Name = "frnPacientesBuscar";
            Text = "frmBuscarPacientes";
            pnlBuscarPaciente.ResumeLayout(false);
            pnlBuscarPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFotoPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePaciente;
        private Panel pnlBuscarPaciente;
        private Label label1;
        private TextBox txtNombrePaciente;
        private Label lblVitalisInicio;
        private TextBox txtApellidoPaternoPaciente;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtApellidoMaternoPaciente;
        private ComboBox cmbTipoPaciente;
        private ComboBox cmbCarrera;
        private ComboBox cmbCuatri;
        private PictureBox pcbFotoPaciente;
        private Button btnBuscarPaciente;
        private Button btnVaciarCampos;
        private TextBox txtBuscarMatricula;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblAvisoAntesDeBuscar;
        private Button button3;
        private Button button2;
    }
}
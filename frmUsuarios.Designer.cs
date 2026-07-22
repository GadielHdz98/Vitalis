namespace Vitalis
{
    partial class frmUsuarios
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
            dgvServiciosMedicos = new DataGridView();
            pcbIconoBuscarServicio = new PictureBox();
            txtBuscarServicioMedico = new TextBox();
            lblDiagnostico = new Label();
            pnlDiagnosticos = new Panel();
            label7 = new Label();
            txtNoTrabajador = new TextBox();
            label6 = new Label();
            txtNombreUsuario = new TextBox();
            cmbPerfil = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtApellidMaternoServicio = new TextBox();
            label3 = new Label();
            txtApellidoPaternoServicio = new TextBox();
            txtContrasenia = new TextBox();
            btnNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            txtNombreServicioMedico = new TextBox();
            btnGuardar = new Button();
            totAyuda = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvServiciosMedicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscarServicio).BeginInit();
            pnlDiagnosticos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiciosMedicos
            // 
            dgvServiciosMedicos.AllowUserToAddRows = false;
            dgvServiciosMedicos.AllowUserToDeleteRows = false;
            dgvServiciosMedicos.AllowUserToResizeColumns = false;
            dgvServiciosMedicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvServiciosMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvServiciosMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiciosMedicos.BackgroundColor = Color.White;
            dgvServiciosMedicos.BorderStyle = BorderStyle.None;
            dgvServiciosMedicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServiciosMedicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvServiciosMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvServiciosMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosMedicos.EnableHeadersVisualStyles = false;
            dgvServiciosMedicos.GridColor = Color.White;
            dgvServiciosMedicos.Location = new Point(873, 248);
            dgvServiciosMedicos.Margin = new Padding(3, 4, 3, 4);
            dgvServiciosMedicos.MultiSelect = false;
            dgvServiciosMedicos.Name = "dgvServiciosMedicos";
            dgvServiciosMedicos.ReadOnly = true;
            dgvServiciosMedicos.RowHeadersVisible = false;
            dgvServiciosMedicos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvServiciosMedicos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvServiciosMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiciosMedicos.Size = new Size(1011, 791);
            dgvServiciosMedicos.TabIndex = 15;
            dgvServiciosMedicos.SelectionChanged += dgvServiciosMedicos_SelectionChanged;
            // 
            // pcbIconoBuscarServicio
            // 
            pcbIconoBuscarServicio.Image = Properties.Resources.IconoBuscar;
            pcbIconoBuscarServicio.Location = new Point(1189, 177);
            pcbIconoBuscarServicio.Margin = new Padding(3, 4, 3, 4);
            pcbIconoBuscarServicio.Name = "pcbIconoBuscarServicio";
            pcbIconoBuscarServicio.Size = new Size(41, 47);
            pcbIconoBuscarServicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIconoBuscarServicio.TabIndex = 14;
            pcbIconoBuscarServicio.TabStop = false;
            // 
            // txtBuscarServicioMedico
            // 
            txtBuscarServicioMedico.BackColor = Color.White;
            txtBuscarServicioMedico.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarServicioMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarServicioMedico.Location = new Point(873, 180);
            txtBuscarServicioMedico.Margin = new Padding(3, 4, 3, 4);
            txtBuscarServicioMedico.MaxLength = 50;
            txtBuscarServicioMedico.Name = "txtBuscarServicioMedico";
            txtBuscarServicioMedico.PlaceholderText = "Buscar por nombre";
            txtBuscarServicioMedico.Size = new Size(308, 39);
            txtBuscarServicioMedico.TabIndex = 13;
            totAyuda.SetToolTip(txtBuscarServicioMedico, "Buscar el usuario por medio de su nombre.");
            txtBuscarServicioMedico.TextChanged += txtBuscarServicioMedico_TextChanged;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.FromArgb(23, 147, 209);
            lblDiagnostico.Location = new Point(79, 116);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(575, 86);
            lblDiagnostico.TabIndex = 12;
            lblDiagnostico.Text = "Servicios Medicos";
            // 
            // pnlDiagnosticos
            // 
            pnlDiagnosticos.BackColor = Color.White;
            pnlDiagnosticos.Controls.Add(label7);
            pnlDiagnosticos.Controls.Add(txtNoTrabajador);
            pnlDiagnosticos.Controls.Add(label6);
            pnlDiagnosticos.Controls.Add(txtNombreUsuario);
            pnlDiagnosticos.Controls.Add(cmbPerfil);
            pnlDiagnosticos.Controls.Add(label5);
            pnlDiagnosticos.Controls.Add(label4);
            pnlDiagnosticos.Controls.Add(txtApellidMaternoServicio);
            pnlDiagnosticos.Controls.Add(label3);
            pnlDiagnosticos.Controls.Add(txtApellidoPaternoServicio);
            pnlDiagnosticos.Controls.Add(txtContrasenia);
            pnlDiagnosticos.Controls.Add(btnNuevo);
            pnlDiagnosticos.Controls.Add(label2);
            pnlDiagnosticos.Controls.Add(label1);
            pnlDiagnosticos.Controls.Add(btnEliminar);
            pnlDiagnosticos.Controls.Add(txtNombreServicioMedico);
            pnlDiagnosticos.Controls.Add(btnGuardar);
            pnlDiagnosticos.Location = new Point(85, 248);
            pnlDiagnosticos.Margin = new Padding(3, 4, 3, 4);
            pnlDiagnosticos.Name = "pnlDiagnosticos";
            pnlDiagnosticos.Size = new Size(747, 791);
            pnlDiagnosticos.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 147, 209);
            label7.Location = new Point(45, 55);
            label7.Name = "label7";
            label7.Size = new Size(185, 32);
            label7.TabIndex = 80;
            label7.Text = "No. Trabajador";
            // 
            // txtNoTrabajador
            // 
            txtNoTrabajador.BackColor = Color.FromArgb(239, 239, 239);
            txtNoTrabajador.BorderStyle = BorderStyle.FixedSingle;
            txtNoTrabajador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoTrabajador.Location = new Point(235, 52);
            txtNoTrabajador.Margin = new Padding(3, 4, 3, 4);
            txtNoTrabajador.MaxLength = 50;
            txtNoTrabajador.Name = "txtNoTrabajador";
            txtNoTrabajador.PlaceholderText = "No. Trabajador";
            txtNoTrabajador.Size = new Size(308, 39);
            txtNoTrabajador.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(77, 361);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 78;
            label6.Text = "Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(235, 359);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.MaxLength = 50;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre del usuario.";
            txtNombreUsuario.Size = new Size(308, 39);
            txtNombreUsuario.TabIndex = 77;
            // 
            // cmbPerfil
            // 
            cmbPerfil.BackColor = Color.FromArgb(239, 239, 239);
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.ForeColor = Color.Black;
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Doctor", "Enfermera", "Administrador" });
            cmbPerfil.Location = new Point(234, 431);
            cmbPerfil.Margin = new Padding(3, 4, 3, 4);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(308, 40);
            cmbPerfil.TabIndex = 76;
            totAyuda.SetToolTip(cmbPerfil, "Ingrese el tipo de perfil del usuario");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 147, 209);
            label5.Location = new Point(77, 435);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 75;
            label5.Text = "Perfil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(75, 288);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 74;
            label4.Text = "Apellido M.:";
            // 
            // txtApellidMaternoServicio
            // 
            txtApellidMaternoServicio.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidMaternoServicio.BorderStyle = BorderStyle.FixedSingle;
            txtApellidMaternoServicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidMaternoServicio.Location = new Point(234, 285);
            txtApellidMaternoServicio.Margin = new Padding(3, 4, 3, 4);
            txtApellidMaternoServicio.MaxLength = 50;
            txtApellidMaternoServicio.Name = "txtApellidMaternoServicio";
            txtApellidMaternoServicio.PlaceholderText = "Apellido materno";
            txtApellidMaternoServicio.Size = new Size(308, 39);
            txtApellidMaternoServicio.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 147, 209);
            label3.Location = new Point(75, 204);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 72;
            label3.Text = "Apellido P.:";
            // 
            // txtApellidoPaternoServicio
            // 
            txtApellidoPaternoServicio.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoPaternoServicio.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPaternoServicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaternoServicio.Location = new Point(234, 201);
            txtApellidoPaternoServicio.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaternoServicio.MaxLength = 50;
            txtApellidoPaternoServicio.Name = "txtApellidoPaternoServicio";
            txtApellidoPaternoServicio.PlaceholderText = "Apellido paterno";
            txtApellidoPaternoServicio.Size = new Size(308, 39);
            txtApellidoPaternoServicio.TabIndex = 71;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(239, 239, 239);
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenia.Location = new Point(234, 504);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.MaxLength = 50;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(308, 39);
            txtContrasenia.TabIndex = 70;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(10, 64, 88);
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(239, 239, 239);
            btnNuevo.Location = new Point(297, 577);
            btnNuevo.Margin = new Padding(0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(183, 47);
            btnNuevo.TabIndex = 69;
            btnNuevo.Text = "Nuevo";
            totAyuda.SetToolTip(btnNuevo, "Crear un nuevo trabajador con su usuario");
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(77, 507);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 68;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(75, 124);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 67;
            label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEliminar.Location = new Point(519, 577);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(183, 47);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "Eliminar";
            totAyuda.SetToolTip(btnEliminar, "Eliminar trabajador");
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombreServicioMedico
            // 
            txtNombreServicioMedico.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreServicioMedico.BorderStyle = BorderStyle.FixedSingle;
            txtNombreServicioMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreServicioMedico.Location = new Point(234, 121);
            txtNombreServicioMedico.Margin = new Padding(3, 4, 3, 4);
            txtNombreServicioMedico.MaxLength = 50;
            txtNombreServicioMedico.Name = "txtNombreServicioMedico";
            txtNombreServicioMedico.PlaceholderText = "Nombre del  trabajador";
            txtNombreServicioMedico.Size = new Size(308, 39);
            txtNombreServicioMedico.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(58, 154, 138);
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGuardar.Location = new Point(74, 577);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(183, 47);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            totAyuda.SetToolTip(btnGuardar, "Guardar o Actualizar los datos");
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dgvServiciosMedicos);
            Controls.Add(pcbIconoBuscarServicio);
            Controls.Add(txtBuscarServicioMedico);
            Controls.Add(lblDiagnostico);
            Controls.Add(pnlDiagnosticos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiciosMedicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIconoBuscarServicio).EndInit();
            pnlDiagnosticos.ResumeLayout(false);
            pnlDiagnosticos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServiciosMedicos;
        private PictureBox pcbIconoBuscarServicio;
        private TextBox txtBuscarServicioMedico;
        private Label lblDiagnostico;
        private Panel pnlDiagnosticos;
        private Button btnNuevo;
        private Label label2;
        private Label label1;
        private Button btnEliminar;
        private TextBox txtNombreServicioMedico;
        private Button btnGuardar;
        private Label label4;
        private TextBox txtApellidMaternoServicio;
        private Label label3;
        private TextBox txtApellidoPaternoServicio;
        private TextBox txtContrasenia;
        private Label label5;
        private ComboBox cmbPerfil;
        private Label label6;
        private TextBox txtNombreUsuario;
        private Label label7;
        private TextBox txtNoTrabajador;
        private ToolTip totAyuda;
    }
}
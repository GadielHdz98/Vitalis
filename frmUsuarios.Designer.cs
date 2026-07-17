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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvServiciosMedicos = new DataGridView();
            pcbIconoBuscarServicio = new PictureBox();
            txtBuscarServicioMedico = new TextBox();
            lblDiagnostico = new Label();
            pnlDiagnosticos = new Panel();
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
            label6 = new Label();
            txtNombreUsuario = new TextBox();
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(239, 239, 239);
            dgvServiciosMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvServiciosMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiciosMedicos.BackgroundColor = Color.White;
            dgvServiciosMedicos.BorderStyle = BorderStyle.None;
            dgvServiciosMedicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServiciosMedicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvServiciosMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvServiciosMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosMedicos.EnableHeadersVisualStyles = false;
            dgvServiciosMedicos.GridColor = Color.White;
            dgvServiciosMedicos.Location = new Point(764, 187);
            dgvServiciosMedicos.MultiSelect = false;
            dgvServiciosMedicos.Name = "dgvServiciosMedicos";
            dgvServiciosMedicos.ReadOnly = true;
            dgvServiciosMedicos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvServiciosMedicos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvServiciosMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiciosMedicos.Size = new Size(885, 593);
            dgvServiciosMedicos.TabIndex = 15;
            // 
            // pcbIconoBuscarServicio
            // 
            pcbIconoBuscarServicio.Image = Properties.Resources.IconoBuscar;
            pcbIconoBuscarServicio.Location = new Point(1040, 133);
            pcbIconoBuscarServicio.Name = "pcbIconoBuscarServicio";
            pcbIconoBuscarServicio.Size = new Size(36, 35);
            pcbIconoBuscarServicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIconoBuscarServicio.TabIndex = 14;
            pcbIconoBuscarServicio.TabStop = false;
            // 
            // txtBuscarServicioMedico
            // 
            txtBuscarServicioMedico.BackColor = Color.White;
            txtBuscarServicioMedico.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarServicioMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarServicioMedico.Location = new Point(764, 135);
            txtBuscarServicioMedico.MaxLength = 50;
            txtBuscarServicioMedico.Name = "txtBuscarServicioMedico";
            txtBuscarServicioMedico.PlaceholderText = "Buscar servicio medico";
            txtBuscarServicioMedico.Size = new Size(270, 33);
            txtBuscarServicioMedico.TabIndex = 13;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.FromArgb(23, 147, 209);
            lblDiagnostico.Location = new Point(69, 87);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(455, 68);
            lblDiagnostico.TabIndex = 12;
            lblDiagnostico.Text = "Servicios Medicos";
            // 
            // pnlDiagnosticos
            // 
            pnlDiagnosticos.BackColor = Color.White;
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
            pnlDiagnosticos.Location = new Point(74, 186);
            pnlDiagnosticos.Name = "pnlDiagnosticos";
            pnlDiagnosticos.Size = new Size(654, 593);
            pnlDiagnosticos.TabIndex = 11;
            // 
            // cmbPerfil
            // 
            cmbPerfil.BackColor = Color.FromArgb(239, 239, 239);
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.ForeColor = Color.FromArgb(239, 239, 239);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(204, 294);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(270, 33);
            cmbPerfil.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 147, 209);
            label5.Location = new Point(66, 297);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 75;
            label5.Text = "Perfil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 147, 209);
            label4.Location = new Point(65, 187);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 74;
            label4.Text = "Apellido M.:";
            // 
            // txtApellidMaternoServicio
            // 
            txtApellidMaternoServicio.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidMaternoServicio.BorderStyle = BorderStyle.FixedSingle;
            txtApellidMaternoServicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidMaternoServicio.Location = new Point(204, 185);
            txtApellidMaternoServicio.MaxLength = 50;
            txtApellidMaternoServicio.Name = "txtApellidMaternoServicio";
            txtApellidMaternoServicio.PlaceholderText = "Apellido materno";
            txtApellidMaternoServicio.Size = new Size(270, 33);
            txtApellidMaternoServicio.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 147, 209);
            label3.Location = new Point(65, 124);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 72;
            label3.Text = "Apellido P.:";
            // 
            // txtApellidoPaternoServicio
            // 
            txtApellidoPaternoServicio.BackColor = Color.FromArgb(239, 239, 239);
            txtApellidoPaternoServicio.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPaternoServicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaternoServicio.Location = new Point(204, 122);
            txtApellidoPaternoServicio.MaxLength = 50;
            txtApellidoPaternoServicio.Name = "txtApellidoPaternoServicio";
            txtApellidoPaternoServicio.PlaceholderText = "Apellido paterno";
            txtApellidoPaternoServicio.Size = new Size(270, 33);
            txtApellidoPaternoServicio.TabIndex = 71;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(239, 239, 239);
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenia.Location = new Point(204, 349);
            txtContrasenia.MaxLength = 50;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = "Contraseña";
            txtContrasenia.Size = new Size(270, 33);
            txtContrasenia.TabIndex = 70;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(10, 64, 88);
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(239, 239, 239);
            btnNuevo.Location = new Point(260, 433);
            btnNuevo.Margin = new Padding(0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(160, 35);
            btnNuevo.TabIndex = 69;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(66, 351);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 68;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 147, 209);
            label1.Location = new Point(65, 64);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 67;
            label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEliminar.Location = new Point(454, 433);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 35);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtNombreServicioMedico
            // 
            txtNombreServicioMedico.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreServicioMedico.BorderStyle = BorderStyle.FixedSingle;
            txtNombreServicioMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreServicioMedico.Location = new Point(204, 62);
            txtNombreServicioMedico.MaxLength = 50;
            txtNombreServicioMedico.Name = "txtNombreServicioMedico";
            txtNombreServicioMedico.PlaceholderText = "Nombre del servicio";
            txtNombreServicioMedico.Size = new Size(270, 33);
            txtNombreServicioMedico.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 64, 88);
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGuardar.Location = new Point(65, 433);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 35);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(23, 147, 209);
            label6.Location = new Point(66, 242);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 78;
            label6.Text = "Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(205, 240);
            txtNombreUsuario.MaxLength = 50;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre del usuario.";
            txtNombreUsuario.Size = new Size(270, 33);
            txtNombreUsuario.TabIndex = 77;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(dgvServiciosMedicos);
            Controls.Add(pcbIconoBuscarServicio);
            Controls.Add(txtBuscarServicioMedico);
            Controls.Add(lblDiagnostico);
            Controls.Add(pnlDiagnosticos);
            Name = "frmUsuarios";
            Text = "Usuarios";
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
    }
}
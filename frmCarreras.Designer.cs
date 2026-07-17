namespace Vitalis
{
    partial class frmCarreras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvCarreras = new DataGridView();
            pcbBuscar = new PictureBox();
            txtBuscarCarrera = new TextBox();
            lblDiagnostico = new Label();
            pnlDiagnosticos = new Panel();
            btnNuevo = new Button();
            lblDescripcion = new Label();
            lblcarrera = new Label();
            btnEliminar = new Button();
            rchtxtDescripcionCarrera = new RichTextBox();
            txtNombreCarrera = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            pnlDiagnosticos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dgvCarreras.AllowUserToDeleteRows = false;
            dgvCarreras.AllowUserToResizeColumns = false;
            dgvCarreras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvCarreras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarreras.Anchor = AnchorStyles.None;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarreras.BackgroundColor = Color.White;
            dgvCarreras.BorderStyle = BorderStyle.None;
            dgvCarreras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarreras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.GridColor = Color.White;
            dgvCarreras.Location = new Point(764, 187);
            dgvCarreras.MultiSelect = false;
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.ReadOnly = true;
            dgvCarreras.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvCarreras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarreras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarreras.Size = new Size(885, 593);
            dgvCarreras.TabIndex = 15;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.IconoBuscar;
            pcbBuscar.Location = new Point(1040, 126);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(36, 35);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 14;
            pcbBuscar.TabStop = false;
            // 
            // txtBuscarCarrera
            // 
            txtBuscarCarrera.BackColor = Color.White;
            txtBuscarCarrera.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarCarrera.Location = new Point(764, 128);
            txtBuscarCarrera.MaxLength = 50;
            txtBuscarCarrera.Name = "txtBuscarCarrera";
            txtBuscarCarrera.PlaceholderText = "Buscar carrera";
            txtBuscarCarrera.Size = new Size(270, 33);
            txtBuscarCarrera.TabIndex = 13;
            txtBuscarCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.FromArgb(23, 147, 209);
            lblDiagnostico.Location = new Point(74, 95);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(225, 68);
            lblDiagnostico.TabIndex = 12;
            lblDiagnostico.Text = "Carreras";
            // 
            // pnlDiagnosticos
            // 
            pnlDiagnosticos.BackColor = Color.White;
            pnlDiagnosticos.Controls.Add(btnNuevo);
            pnlDiagnosticos.Controls.Add(lblDescripcion);
            pnlDiagnosticos.Controls.Add(lblcarrera);
            pnlDiagnosticos.Controls.Add(btnEliminar);
            pnlDiagnosticos.Controls.Add(rchtxtDescripcionCarrera);
            pnlDiagnosticos.Controls.Add(txtNombreCarrera);
            pnlDiagnosticos.Controls.Add(btnGuardar);
            pnlDiagnosticos.Location = new Point(74, 186);
            pnlDiagnosticos.Name = "pnlDiagnosticos";
            pnlDiagnosticos.Size = new Size(654, 593);
            pnlDiagnosticos.TabIndex = 11;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(10, 64, 88);
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.FromArgb(239, 239, 239);
            btnNuevo.Location = new Point(265, 362);
            btnNuevo.Margin = new Padding(0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(160, 35);
            btnNuevo.TabIndex = 69;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.FromArgb(23, 147, 209);
            lblDescripcion.Location = new Point(65, 150);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 25);
            lblDescripcion.TabIndex = 68;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblcarrera
            // 
            lblcarrera.AutoSize = true;
            lblcarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcarrera.ForeColor = Color.FromArgb(23, 147, 209);
            lblcarrera.Location = new Point(65, 64);
            lblcarrera.Name = "lblcarrera";
            lblcarrera.Size = new Size(91, 25);
            lblcarrera.TabIndex = 67;
            lblcarrera.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEliminar.Location = new Point(461, 362);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 35);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnBorrar_Click;
            // 
            // rchtxtDescripcionCarrera
            // 
            rchtxtDescripcionCarrera.BackColor = Color.FromArgb(239, 239, 239);
            rchtxtDescripcionCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxtDescripcionCarrera.ForeColor = Color.Black;
            rchtxtDescripcionCarrera.Location = new Point(200, 147);
            rchtxtDescripcionCarrera.Name = "rchtxtDescripcionCarrera";
            rchtxtDescripcionCarrera.Size = new Size(270, 147);
            rchtxtDescripcionCarrera.TabIndex = 62;
            rchtxtDescripcionCarrera.Tag = "Tratamiento";
            rchtxtDescripcionCarrera.Text = "";
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreCarrera.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(200, 62);
            txtNombreCarrera.MaxLength = 50;
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Nombre carrera";
            txtNombreCarrera.Size = new Size(270, 33);
            txtNombreCarrera.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 64, 88);
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(239, 239, 239);
            btnGuardar.Location = new Point(65, 362);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 35);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(dgvCarreras);
            Controls.Add(pcbBuscar);
            Controls.Add(txtBuscarCarrera);
            Controls.Add(lblDiagnostico);
            Controls.Add(pnlDiagnosticos);
            Name = "frmCarreras";
            Text = "frmCarreras";
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            pnlDiagnosticos.ResumeLayout(false);
            pnlDiagnosticos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarreras;
        private PictureBox pcbBuscar;
        private TextBox txtBuscarCarrera;
        private Label lblDiagnostico;
        private Panel pnlDiagnosticos;
        private Button btnNuevo;
        private Label lblDescripcion;
        private Label lblcarrera;
        private Button btnEliminar;
        private RichTextBox rchtxtDescripcionCarrera;
        private TextBox txtNombreCarrera;
        private Button btnGuardar;
    }
}
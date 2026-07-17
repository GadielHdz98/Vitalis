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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvCarreras = new DataGridView();
            pcbBuscar = new PictureBox();
            txtBuscarCarrera = new TextBox();
            lblDiagnostico = new Label();
            pnlDiagnosticos = new Panel();
            button1 = new Button();
            lblDescripcion = new Label();
            lblcarrera = new Label();
            btnEliminar = new Button();
            rchtxtDescripcionCarrera = new RichTextBox();
            txtNombreCarrera = new TextBox();
            btnEditar = new Button();
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(239, 239, 239);
            dgvCarreras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarreras.Anchor = AnchorStyles.None;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarreras.BackgroundColor = Color.White;
            dgvCarreras.BorderStyle = BorderStyle.None;
            dgvCarreras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarreras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.GridColor = Color.White;
            dgvCarreras.Location = new Point(764, 187);
            dgvCarreras.MultiSelect = false;
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.ReadOnly = true;
            dgvCarreras.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dgvCarreras.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarreras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarreras.Size = new Size(885, 593);
            dgvCarreras.TabIndex = 15;
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
            pnlDiagnosticos.Controls.Add(button1);
            pnlDiagnosticos.Controls.Add(lblDescripcion);
            pnlDiagnosticos.Controls.Add(lblcarrera);
            pnlDiagnosticos.Controls.Add(btnEliminar);
            pnlDiagnosticos.Controls.Add(rchtxtDescripcionCarrera);
            pnlDiagnosticos.Controls.Add(txtNombreCarrera);
            pnlDiagnosticos.Controls.Add(btnEditar);
            pnlDiagnosticos.Location = new Point(74, 186);
            pnlDiagnosticos.Name = "pnlDiagnosticos";
            pnlDiagnosticos.Size = new Size(654, 593);
            pnlDiagnosticos.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 64, 88);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(239, 239, 239);
            button1.Location = new Point(265, 362);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(160, 35);
            button1.TabIndex = 69;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = false;
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
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(10, 64, 88);
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(239, 239, 239);
            btnEditar.Location = new Point(65, 362);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 35);
            btnEditar.TabIndex = 65;
            btnEditar.Text = "Guardar";
            btnEditar.UseVisualStyleBackColor = false;
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
        private Button button1;
        private Label lblDescripcion;
        private Label lblcarrera;
        private Button btnEliminar;
        private RichTextBox rchtxtDescripcionCarrera;
        private TextBox txtNombreCarrera;
        private Button btnEditar;
    }
}
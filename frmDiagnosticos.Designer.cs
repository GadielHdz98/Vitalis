namespace Vitalis
{
    partial class frmDiagnosticos
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
            pnlDiagnosticos = new Panel();
            btnNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            rchtxtSintomas = new RichTextBox();
            txtNombreDiagnostico = new TextBox();
            btnGuardar = new Button();
            lblDiagnostico = new Label();
            txtBuscarDiagnostico = new TextBox();
            pictureBox1 = new PictureBox();
            dgvDiagnosticos = new DataGridView();
            pnlDiagnosticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiagnosticos).BeginInit();
            SuspendLayout();
            // 
            // pnlDiagnosticos
            // 
            pnlDiagnosticos.BackColor = Color.White;
            pnlDiagnosticos.Controls.Add(btnNuevo);
            pnlDiagnosticos.Controls.Add(label2);
            pnlDiagnosticos.Controls.Add(label1);
            pnlDiagnosticos.Controls.Add(btnEliminar);
            pnlDiagnosticos.Controls.Add(rchtxtSintomas);
            pnlDiagnosticos.Controls.Add(txtNombreDiagnostico);
            pnlDiagnosticos.Controls.Add(btnGuardar);
            pnlDiagnosticos.Location = new Point(74, 186);
            pnlDiagnosticos.Name = "pnlDiagnosticos";
            pnlDiagnosticos.Size = new Size(654, 593);
            pnlDiagnosticos.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 147, 209);
            label2.Location = new Point(65, 150);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 68;
            label2.Text = "Sintomas:";
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
            btnEliminar.Location = new Point(461, 362);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 35);
            btnEliminar.TabIndex = 66;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // rchtxtSintomas
            // 
            rchtxtSintomas.BackColor = Color.FromArgb(239, 239, 239);
            rchtxtSintomas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rchtxtSintomas.ForeColor = Color.Black;
            rchtxtSintomas.Location = new Point(184, 147);
            rchtxtSintomas.Name = "rchtxtSintomas";
            rchtxtSintomas.Size = new Size(270, 147);
            rchtxtSintomas.TabIndex = 62;
            rchtxtSintomas.Tag = "Tratamiento";
            rchtxtSintomas.Text = "";
            // 
            // txtNombreDiagnostico
            // 
            txtNombreDiagnostico.BackColor = Color.FromArgb(239, 239, 239);
            txtNombreDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            txtNombreDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreDiagnostico.Location = new Point(184, 62);
            txtNombreDiagnostico.MaxLength = 50;
            txtNombreDiagnostico.Name = "txtNombreDiagnostico";
            txtNombreDiagnostico.PlaceholderText = "Nombre diagnostico.";
            txtNombreDiagnostico.Size = new Size(270, 33);
            txtNombreDiagnostico.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(58, 154, 138);
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
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.ForeColor = Color.FromArgb(23, 147, 209);
            lblDiagnostico.Location = new Point(74, 90);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(335, 68);
            lblDiagnostico.TabIndex = 2;
            lblDiagnostico.Text = "Diagnosticos";
            // 
            // txtBuscarDiagnostico
            // 
            txtBuscarDiagnostico.BackColor = Color.White;
            txtBuscarDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDiagnostico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarDiagnostico.Location = new Point(769, 136);
            txtBuscarDiagnostico.MaxLength = 50;
            txtBuscarDiagnostico.Name = "txtBuscarDiagnostico";
            txtBuscarDiagnostico.PlaceholderText = "Buscar diagnostico";
            txtBuscarDiagnostico.Size = new Size(270, 33);
            txtBuscarDiagnostico.TabIndex = 3;
            txtBuscarDiagnostico.TextChanged += txtBuscarDiagnostico_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconoBuscar;
            pictureBox1.Location = new Point(1045, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvDiagnosticos
            // 
            dgvDiagnosticos.AllowUserToAddRows = false;
            dgvDiagnosticos.AllowUserToDeleteRows = false;
            dgvDiagnosticos.AllowUserToResizeColumns = false;
            dgvDiagnosticos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvDiagnosticos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiagnosticos.BackgroundColor = Color.White;
            dgvDiagnosticos.BorderStyle = BorderStyle.None;
            dgvDiagnosticos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDiagnosticos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDiagnosticos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDiagnosticos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDiagnosticos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDiagnosticos.EnableHeadersVisualStyles = false;
            dgvDiagnosticos.GridColor = Color.White;
            dgvDiagnosticos.Location = new Point(769, 186);
            dgvDiagnosticos.MultiSelect = false;
            dgvDiagnosticos.Name = "dgvDiagnosticos";
            dgvDiagnosticos.ReadOnly = true;
            dgvDiagnosticos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvDiagnosticos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDiagnosticos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiagnosticos.Size = new Size(885, 593);
            dgvDiagnosticos.TabIndex = 10;
            dgvDiagnosticos.SelectionChanged += dgvDiagnosticos_SelectionChanged;
            // 
            // frmDiagnosticos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1703, 861);
            Controls.Add(dgvDiagnosticos);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarDiagnostico);
            Controls.Add(lblDiagnostico);
            Controls.Add(pnlDiagnosticos);
            Name = "frmDiagnosticos";
            Text = "frmDiagnosticos";
            pnlDiagnosticos.ResumeLayout(false);
            pnlDiagnosticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiagnosticos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDiagnosticos;
        private Label lblDiagnostico;
        private TextBox txtNombreDiagnostico;
        private RichTextBox rchtxtSintomas;
        private Label label2;
        private Label label1;
        private TextBox txtBuscarDiagnostico;
        private PictureBox pictureBox1;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dgvDiagnosticos;
    }
}
namespace Vitalis
{
    partial class frmAdministracion
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
            pnlContenedorAdministracion = new Panel();
            pnlAdministracionTopBar = new Panel();
            BtnCarreras = new Button();
            btnUsuarios = new Button();
            btnDiagnosticos = new Button();
            pnlAdministracionTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedorAdministracion
            // 
            pnlContenedorAdministracion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedorAdministracion.BackColor = Color.White;
            pnlContenedorAdministracion.Location = new Point(0, 70);
            pnlContenedorAdministracion.Name = "pnlContenedorAdministracion";
            pnlContenedorAdministracion.Size = new Size(1719, 900);
            pnlContenedorAdministracion.TabIndex = 11;
            // 
            // pnlAdministracionTopBar
            // 
            pnlAdministracionTopBar.BackColor = Color.FromArgb(58, 154, 138);
            pnlAdministracionTopBar.Controls.Add(BtnCarreras);
            pnlAdministracionTopBar.Controls.Add(btnUsuarios);
            pnlAdministracionTopBar.Controls.Add(btnDiagnosticos);
            pnlAdministracionTopBar.Dock = DockStyle.Top;
            pnlAdministracionTopBar.Location = new Point(0, 0);
            pnlAdministracionTopBar.Name = "pnlAdministracionTopBar";
            pnlAdministracionTopBar.Size = new Size(1719, 70);
            pnlAdministracionTopBar.TabIndex = 10;
            // 
            // BtnCarreras
            // 
            BtnCarreras.BackColor = Color.FromArgb(58, 154, 138);
            BtnCarreras.Cursor = Cursors.Hand;
            BtnCarreras.FlatAppearance.BorderSize = 0;
            BtnCarreras.FlatStyle = FlatStyle.Flat;
            BtnCarreras.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCarreras.ForeColor = Color.FromArgb(239, 239, 239);
            BtnCarreras.Location = new Point(186, 0);
            BtnCarreras.Margin = new Padding(0);
            BtnCarreras.Name = "BtnCarreras";
            BtnCarreras.Size = new Size(185, 70);
            BtnCarreras.TabIndex = 3;
            BtnCarreras.Text = "Carreras";
            BtnCarreras.UseVisualStyleBackColor = false;
            BtnCarreras.Click += BtnCarreras_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(58, 154, 138);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.FromArgb(239, 239, 239);
            btnUsuarios.Location = new Point(371, 0);
            btnUsuarios.Margin = new Padding(0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(185, 70);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnDiagnosticos
            // 
            btnDiagnosticos.BackColor = Color.FromArgb(58, 154, 138);
            btnDiagnosticos.FlatAppearance.BorderSize = 0;
            btnDiagnosticos.FlatStyle = FlatStyle.Flat;
            btnDiagnosticos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiagnosticos.ForeColor = Color.FromArgb(239, 239, 239);
            btnDiagnosticos.Location = new Point(1, 0);
            btnDiagnosticos.Margin = new Padding(0);
            btnDiagnosticos.Name = "btnDiagnosticos";
            btnDiagnosticos.Size = new Size(185, 70);
            btnDiagnosticos.TabIndex = 2;
            btnDiagnosticos.Text = "Diagnosticos";
            btnDiagnosticos.UseVisualStyleBackColor = false;
            btnDiagnosticos.Click += btnDiagnosticos_Click;
            // 
            // frmAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(pnlContenedorAdministracion);
            Controls.Add(pnlAdministracionTopBar);
            Name = "frmAdministracion";
            Text = "frmAdministracion";
            pnlAdministracionTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedorAdministracion;
        private Panel pnlAdministracionTopBar;
        private Button BtnCarreras;
        private Button btnUsuarios;
        private Button btnDiagnosticos;
    }
}
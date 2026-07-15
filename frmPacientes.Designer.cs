namespace Vitalis
{
    partial class frmPacientes
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
            pnlBuscarPacientes = new Panel();
            pnlContenedorPacientes = new Panel();
            pnlPacientesTopBar = new Panel();
            btnBuscarPacientesTopBar = new Button();
            btnAgregarPacientesTopBar = new Button();
            btnPacientesRecientesTopBar = new Button();
            pnlBuscarPacientes.SuspendLayout();
            pnlPacientesTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBuscarPacientes
            // 
            pnlBuscarPacientes.Controls.Add(pnlContenedorPacientes);
            pnlBuscarPacientes.Controls.Add(pnlPacientesTopBar);
            pnlBuscarPacientes.Dock = DockStyle.Fill;
            pnlBuscarPacientes.Location = new Point(0, 0);
            pnlBuscarPacientes.Name = "pnlBuscarPacientes";
            pnlBuscarPacientes.Size = new Size(1719, 970);
            pnlBuscarPacientes.TabIndex = 0;
            // 
            // pnlContenedorPacientes
            // 
            pnlContenedorPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedorPacientes.BackColor = Color.White;
            pnlContenedorPacientes.Location = new Point(0, 70);
            pnlContenedorPacientes.Name = "pnlContenedorPacientes";
            pnlContenedorPacientes.Size = new Size(1719, 900);
            pnlContenedorPacientes.TabIndex = 9;
            // 
            // pnlPacientesTopBar
            // 
            pnlPacientesTopBar.BackColor = Color.FromArgb(58, 154, 138);
            pnlPacientesTopBar.Controls.Add(btnBuscarPacientesTopBar);
            pnlPacientesTopBar.Controls.Add(btnAgregarPacientesTopBar);
            pnlPacientesTopBar.Controls.Add(btnPacientesRecientesTopBar);
            pnlPacientesTopBar.Dock = DockStyle.Top;
            pnlPacientesTopBar.Location = new Point(0, 0);
            pnlPacientesTopBar.Name = "pnlPacientesTopBar";
            pnlPacientesTopBar.Size = new Size(1719, 70);
            pnlPacientesTopBar.TabIndex = 8;
            // 
            // btnBuscarPacientesTopBar
            // 
            btnBuscarPacientesTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnBuscarPacientesTopBar.Cursor = Cursors.Hand;
            btnBuscarPacientesTopBar.FlatAppearance.BorderSize = 0;
            btnBuscarPacientesTopBar.FlatStyle = FlatStyle.Flat;
            btnBuscarPacientesTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPacientesTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarPacientesTopBar.Location = new Point(186, 0);
            btnBuscarPacientesTopBar.Margin = new Padding(0);
            btnBuscarPacientesTopBar.Name = "btnBuscarPacientesTopBar";
            btnBuscarPacientesTopBar.Size = new Size(185, 70);
            btnBuscarPacientesTopBar.TabIndex = 3;
            btnBuscarPacientesTopBar.Text = "Buscar";
            btnBuscarPacientesTopBar.UseVisualStyleBackColor = false;
            btnBuscarPacientesTopBar.Click += btnBuscarPacientesTopBar_Click;
            // 
            // btnAgregarPacientesTopBar
            // 
            btnAgregarPacientesTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnAgregarPacientesTopBar.FlatAppearance.BorderSize = 0;
            btnAgregarPacientesTopBar.FlatStyle = FlatStyle.Flat;
            btnAgregarPacientesTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPacientesTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnAgregarPacientesTopBar.Location = new Point(371, 0);
            btnAgregarPacientesTopBar.Margin = new Padding(0);
            btnAgregarPacientesTopBar.Name = "btnAgregarPacientesTopBar";
            btnAgregarPacientesTopBar.Size = new Size(185, 70);
            btnAgregarPacientesTopBar.TabIndex = 4;
            btnAgregarPacientesTopBar.Text = "Agregar";
            btnAgregarPacientesTopBar.UseVisualStyleBackColor = false;
            btnAgregarPacientesTopBar.Click += btnAgregarPacientesTopBar_Click;
            // 
            // btnPacientesRecientesTopBar
            // 
            btnPacientesRecientesTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnPacientesRecientesTopBar.FlatAppearance.BorderSize = 0;
            btnPacientesRecientesTopBar.FlatStyle = FlatStyle.Flat;
            btnPacientesRecientesTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientesRecientesTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnPacientesRecientesTopBar.Location = new Point(1, 0);
            btnPacientesRecientesTopBar.Margin = new Padding(0);
            btnPacientesRecientesTopBar.Name = "btnPacientesRecientesTopBar";
            btnPacientesRecientesTopBar.Size = new Size(185, 70);
            btnPacientesRecientesTopBar.TabIndex = 2;
            btnPacientesRecientesTopBar.Text = "Recientes";
            btnPacientesRecientesTopBar.UseVisualStyleBackColor = false;
            btnPacientesRecientesTopBar.Click += btnPacientesRecientesTopBar_Click;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(pnlBuscarPacientes);
            Name = "frmPacientes";
            Text = "Pacientes";
            Load += frmPacientes_Load;
            pnlBuscarPacientes.ResumeLayout(false);
            pnlPacientesTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBuscarPacientes;
        private Panel pnlContenedorPacientes;
        private Panel pnlPacientesTopBar;
        private Button btnBuscarPacientesTopBar;
        private Button btnAgregarPacientesTopBar;
        private Button btnPacientesRecientesTopBar;
    }
}
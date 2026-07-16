namespace Vitalis
{
    partial class frmConsultas
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
            pnlConsultasTopBar = new Panel();
            panel2 = new Panel();
            btnBuscarConsultasTopBar = new Button();
            btnAgregarConsultasTopBar = new Button();
            btnConsultasRecientesTopBar = new Button();
            pnlContenedorConsultas = new Panel();
            pnlConsultasTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConsultasTopBar
            // 
            pnlConsultasTopBar.BackColor = Color.FromArgb(58, 154, 138);
            pnlConsultasTopBar.Controls.Add(panel2);
            pnlConsultasTopBar.Controls.Add(btnBuscarConsultasTopBar);
            pnlConsultasTopBar.Controls.Add(btnAgregarConsultasTopBar);
            pnlConsultasTopBar.Controls.Add(btnConsultasRecientesTopBar);
            pnlConsultasTopBar.Dock = DockStyle.Top;
            pnlConsultasTopBar.Location = new Point(0, 0);
            pnlConsultasTopBar.Name = "pnlConsultasTopBar";
            pnlConsultasTopBar.Size = new Size(1719, 70);
            pnlConsultasTopBar.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 10;
            // 
            // btnBuscarConsultasTopBar
            // 
            btnBuscarConsultasTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnBuscarConsultasTopBar.Cursor = Cursors.Hand;
            btnBuscarConsultasTopBar.FlatAppearance.BorderSize = 0;
            btnBuscarConsultasTopBar.FlatStyle = FlatStyle.Flat;
            btnBuscarConsultasTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarConsultasTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnBuscarConsultasTopBar.Location = new Point(186, 0);
            btnBuscarConsultasTopBar.Margin = new Padding(0);
            btnBuscarConsultasTopBar.Name = "btnBuscarConsultasTopBar";
            btnBuscarConsultasTopBar.Size = new Size(185, 70);
            btnBuscarConsultasTopBar.TabIndex = 3;
            btnBuscarConsultasTopBar.Text = "Buscar";
            btnBuscarConsultasTopBar.UseVisualStyleBackColor = false;
            btnBuscarConsultasTopBar.Click += btnBuscarConsultasTopBar_Click;
            // 
            // btnAgregarConsultasTopBar
            // 
            btnAgregarConsultasTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnAgregarConsultasTopBar.FlatAppearance.BorderSize = 0;
            btnAgregarConsultasTopBar.FlatStyle = FlatStyle.Flat;
            btnAgregarConsultasTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarConsultasTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnAgregarConsultasTopBar.Location = new Point(371, 0);
            btnAgregarConsultasTopBar.Margin = new Padding(0);
            btnAgregarConsultasTopBar.Name = "btnAgregarConsultasTopBar";
            btnAgregarConsultasTopBar.Size = new Size(185, 70);
            btnAgregarConsultasTopBar.TabIndex = 4;
            btnAgregarConsultasTopBar.Text = "Agregar";
            btnAgregarConsultasTopBar.UseVisualStyleBackColor = false;
            btnAgregarConsultasTopBar.Click += btnAgregarConsultasTopBar_Click;
            // 
            // btnConsultasRecientesTopBar
            // 
            btnConsultasRecientesTopBar.BackColor = Color.FromArgb(58, 154, 138);
            btnConsultasRecientesTopBar.FlatAppearance.BorderSize = 0;
            btnConsultasRecientesTopBar.FlatStyle = FlatStyle.Flat;
            btnConsultasRecientesTopBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultasRecientesTopBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnConsultasRecientesTopBar.Location = new Point(1, 0);
            btnConsultasRecientesTopBar.Margin = new Padding(0);
            btnConsultasRecientesTopBar.Name = "btnConsultasRecientesTopBar";
            btnConsultasRecientesTopBar.Size = new Size(185, 70);
            btnConsultasRecientesTopBar.TabIndex = 2;
            btnConsultasRecientesTopBar.Text = "Recientes";
            btnConsultasRecientesTopBar.UseVisualStyleBackColor = false;
            btnConsultasRecientesTopBar.Click += btnConsultasRecientesTopBar_Click;
            // 
            // pnlContenedorConsultas
            // 
            pnlContenedorConsultas.Dock = DockStyle.Fill;
            pnlContenedorConsultas.Location = new Point(0, 70);
            pnlContenedorConsultas.Name = "pnlContenedorConsultas";
            pnlContenedorConsultas.Size = new Size(1719, 900);
            pnlContenedorConsultas.TabIndex = 10;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
            Controls.Add(pnlContenedorConsultas);
            Controls.Add(pnlConsultasTopBar);
            Name = "frmConsultas";
            Text = "frmConsultas";
            pnlConsultasTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlConsultasTopBar;
        private Button btnBuscarConsultasTopBar;
        private Button btnAgregarConsultasTopBar;
        private Button btnConsultasRecientesTopBar;
        private Panel panel2;
        private Panel pnlContenedorConsultas;
    }
}
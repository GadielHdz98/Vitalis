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
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            panel1 = new Panel();
            btnBuscarPacientesTopBar = new Button();
            btnAgregarPacientesTopBar = new Button();
            btnPacientesRecientesTopBar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 154, 138);
            panel1.Controls.Add(btnBuscarPacientesTopBar);
            panel1.Controls.Add(btnAgregarPacientesTopBar);
            panel1.Controls.Add(btnPacientesRecientesTopBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 70);
            panel1.TabIndex = 9;
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
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 672);
            Controls.Add(panel1);
            Name = "frmConsultas";
            Text = "frmConsultas";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Button btnBuscarPacientesTopBar;
        private Button btnAgregarPacientesTopBar;
        private Button btnPacientesRecientesTopBar;
    }
}
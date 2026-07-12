namespace Vitalis
{
    partial class frmPrincipal
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
            pnlSideBar = new Panel();
            pnlPerfilUsuarioSideBar = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrarSesionSideBar = new Button();
            lblRolUsuarioSideBar = new Label();
            lblNombreUsuarioSideBar = new Label();
            pcbFotoDePerfilUsuario = new PictureBox();
            btnAyudaSideBar = new Button();
            btnConsultasSideBar = new Button();
            btnPacientesSideBar = new Button();
            btnInicioSideBar = new Button();
            pnlLogoVitalisSideBar = new Panel();
            pcbLogoVitalisSideBar = new PictureBox();
            pnlContenedor = new Panel();
            pnlSideBar.SuspendLayout();
            pnlPerfilUsuarioSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFotoDePerfilUsuario).BeginInit();
            pnlLogoVitalisSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogoVitalisSideBar).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(58, 154, 138);
            pnlSideBar.Controls.Add(pnlPerfilUsuarioSideBar);
            pnlSideBar.Controls.Add(btnAyudaSideBar);
            pnlSideBar.Controls.Add(btnConsultasSideBar);
            pnlSideBar.Controls.Add(btnPacientesSideBar);
            pnlSideBar.Controls.Add(btnInicioSideBar);
            pnlSideBar.Controls.Add(pnlLogoVitalisSideBar);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(185, 711);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlPerfilUsuarioSideBar
            // 
            pnlPerfilUsuarioSideBar.BorderStyle = BorderStyle.FixedSingle;
            pnlPerfilUsuarioSideBar.Controls.Add(pictureBox1);
            pnlPerfilUsuarioSideBar.Controls.Add(btnCerrarSesionSideBar);
            pnlPerfilUsuarioSideBar.Controls.Add(lblRolUsuarioSideBar);
            pnlPerfilUsuarioSideBar.Controls.Add(lblNombreUsuarioSideBar);
            pnlPerfilUsuarioSideBar.Controls.Add(pcbFotoDePerfilUsuario);
            pnlPerfilUsuarioSideBar.Dock = DockStyle.Bottom;
            pnlPerfilUsuarioSideBar.Location = new Point(0, 550);
            pnlPerfilUsuarioSideBar.Name = "pnlPerfilUsuarioSideBar";
            pnlPerfilUsuarioSideBar.Size = new Size(185, 161);
            pnlPerfilUsuarioSideBar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconoSalir2;
            pictureBox1.Location = new Point(0, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesionSideBar
            // 
            btnCerrarSesionSideBar.BackColor = Color.FromArgb(58, 154, 138);
            btnCerrarSesionSideBar.FlatAppearance.BorderSize = 0;
            btnCerrarSesionSideBar.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionSideBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesionSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnCerrarSesionSideBar.Location = new Point(6, 119);
            btnCerrarSesionSideBar.Name = "btnCerrarSesionSideBar";
            btnCerrarSesionSideBar.Size = new Size(179, 30);
            btnCerrarSesionSideBar.TabIndex = 8;
            btnCerrarSesionSideBar.Text = "Cerrar sesión";
            btnCerrarSesionSideBar.UseVisualStyleBackColor = false;
            // 
            // lblRolUsuarioSideBar
            // 
            lblRolUsuarioSideBar.AutoEllipsis = true;
            lblRolUsuarioSideBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolUsuarioSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            lblRolUsuarioSideBar.Location = new Point(3, 86);
            lblRolUsuarioSideBar.Name = "lblRolUsuarioSideBar";
            lblRolUsuarioSideBar.RightToLeft = RightToLeft.No;
            lblRolUsuarioSideBar.Size = new Size(182, 30);
            lblRolUsuarioSideBar.TabIndex = 7;
            lblRolUsuarioSideBar.Text = "Rol del usuario";
            lblRolUsuarioSideBar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuarioSideBar
            // 
            lblNombreUsuarioSideBar.AutoEllipsis = true;
            lblNombreUsuarioSideBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuarioSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            lblNombreUsuarioSideBar.Location = new Point(3, 36);
            lblNombreUsuarioSideBar.Name = "lblNombreUsuarioSideBar";
            lblNombreUsuarioSideBar.RightToLeft = RightToLeft.No;
            lblNombreUsuarioSideBar.Size = new Size(180, 50);
            lblNombreUsuarioSideBar.TabIndex = 6;
            lblNombreUsuarioSideBar.Text = "Luis Gadiel Hernandez Bautista";
            lblNombreUsuarioSideBar.TextAlign = ContentAlignment.TopCenter;
            // 
            // pcbFotoDePerfilUsuario
            // 
            pcbFotoDePerfilUsuario.Image = Properties.Resources.fotoUsuarioVacia1;
            pcbFotoDePerfilUsuario.Location = new Point(77, 3);
            pcbFotoDePerfilUsuario.Name = "pcbFotoDePerfilUsuario";
            pcbFotoDePerfilUsuario.Size = new Size(30, 30);
            pcbFotoDePerfilUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFotoDePerfilUsuario.TabIndex = 5;
            pcbFotoDePerfilUsuario.TabStop = false;
            // 
            // btnAyudaSideBar
            // 
            btnAyudaSideBar.BackColor = Color.FromArgb(58, 154, 138);
            btnAyudaSideBar.Dock = DockStyle.Top;
            btnAyudaSideBar.FlatAppearance.BorderSize = 0;
            btnAyudaSideBar.FlatStyle = FlatStyle.Flat;
            btnAyudaSideBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyudaSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnAyudaSideBar.Location = new Point(0, 351);
            btnAyudaSideBar.Margin = new Padding(0);
            btnAyudaSideBar.Name = "btnAyudaSideBar";
            btnAyudaSideBar.Size = new Size(185, 70);
            btnAyudaSideBar.TabIndex = 4;
            btnAyudaSideBar.Text = "Ayuda";
            btnAyudaSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnAyudaSideBar.UseVisualStyleBackColor = false;
            // 
            // btnConsultasSideBar
            // 
            btnConsultasSideBar.BackColor = Color.FromArgb(58, 154, 138);
            btnConsultasSideBar.Dock = DockStyle.Top;
            btnConsultasSideBar.FlatAppearance.BorderSize = 0;
            btnConsultasSideBar.FlatStyle = FlatStyle.Flat;
            btnConsultasSideBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultasSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnConsultasSideBar.Location = new Point(0, 281);
            btnConsultasSideBar.Margin = new Padding(0);
            btnConsultasSideBar.Name = "btnConsultasSideBar";
            btnConsultasSideBar.Size = new Size(185, 70);
            btnConsultasSideBar.TabIndex = 3;
            btnConsultasSideBar.Text = "Consultas";
            btnConsultasSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultasSideBar.UseVisualStyleBackColor = false;
            // 
            // btnPacientesSideBar
            // 
            btnPacientesSideBar.BackColor = Color.FromArgb(58, 154, 138);
            btnPacientesSideBar.Dock = DockStyle.Top;
            btnPacientesSideBar.FlatAppearance.BorderSize = 0;
            btnPacientesSideBar.FlatStyle = FlatStyle.Flat;
            btnPacientesSideBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientesSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnPacientesSideBar.Location = new Point(0, 211);
            btnPacientesSideBar.Margin = new Padding(0);
            btnPacientesSideBar.Name = "btnPacientesSideBar";
            btnPacientesSideBar.Size = new Size(185, 70);
            btnPacientesSideBar.TabIndex = 2;
            btnPacientesSideBar.Text = "Pacientes";
            btnPacientesSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientesSideBar.UseVisualStyleBackColor = false;
            // 
            // btnInicioSideBar
            // 
            btnInicioSideBar.BackColor = Color.FromArgb(58, 154, 138);
            btnInicioSideBar.Dock = DockStyle.Top;
            btnInicioSideBar.FlatAppearance.BorderSize = 0;
            btnInicioSideBar.FlatStyle = FlatStyle.Flat;
            btnInicioSideBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicioSideBar.ForeColor = Color.FromArgb(239, 239, 239);
            btnInicioSideBar.Location = new Point(0, 141);
            btnInicioSideBar.Margin = new Padding(0);
            btnInicioSideBar.Name = "btnInicioSideBar";
            btnInicioSideBar.Size = new Size(185, 70);
            btnInicioSideBar.TabIndex = 1;
            btnInicioSideBar.Text = "Inicio";
            btnInicioSideBar.TextAlign = ContentAlignment.MiddleLeft;
            btnInicioSideBar.UseVisualStyleBackColor = false;
            // 
            // pnlLogoVitalisSideBar
            // 
            pnlLogoVitalisSideBar.Controls.Add(pcbLogoVitalisSideBar);
            pnlLogoVitalisSideBar.Dock = DockStyle.Top;
            pnlLogoVitalisSideBar.Location = new Point(0, 0);
            pnlLogoVitalisSideBar.Name = "pnlLogoVitalisSideBar";
            pnlLogoVitalisSideBar.Size = new Size(185, 141);
            pnlLogoVitalisSideBar.TabIndex = 0;
            // 
            // pcbLogoVitalisSideBar
            // 
            pcbLogoVitalisSideBar.Image = Properties.Resources.Logo_fondoVerdeMenuSideBar;
            pcbLogoVitalisSideBar.Location = new Point(18, 0);
            pcbLogoVitalisSideBar.Margin = new Padding(0);
            pcbLogoVitalisSideBar.Name = "pcbLogoVitalisSideBar";
            pcbLogoVitalisSideBar.Size = new Size(144, 137);
            pcbLogoVitalisSideBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogoVitalisSideBar.TabIndex = 0;
            pcbLogoVitalisSideBar.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(185, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1149, 711);
            pnlContenedor.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 239, 239);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1334, 711);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSideBar);
            DoubleBuffered = true;
            MinimumSize = new Size(1000, 620);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            pnlSideBar.ResumeLayout(false);
            pnlPerfilUsuarioSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFotoDePerfilUsuario).EndInit();
            pnlLogoVitalisSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogoVitalisSideBar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcb_logomenu;
        private PictureBox pcb_iniciomenu;
        private PictureBox pcb_pacientesmenu;
        private PictureBox pcb_consultasmenu;
        private Label lbl_iniciosb;
        private Label label4;
        private Panel pnlSideBar;
        private Panel pnlLogoVitalisSideBar;
        private PictureBox pcbLogoVitalisSideBar;
        private Button btnInicioSideBar;
        private Button btnAyudaSideBar;
        private Button btnConsultasSideBar;
        private Button btnPacientesSideBar;
        private Panel pnlPerfilUsuarioSideBar;
        private PictureBox pcbFotoDePerfilUsuario;
        private Label lblNombreUsuarioSideBar;
        private Label lblRolUsuarioSideBar;
        private Button btnCerrarSesionSideBar;
        private PictureBox pictureBox1;
        private Panel pnlContenedor;
    }
}
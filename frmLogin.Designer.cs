namespace Vitalis
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            lblLogin = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            pnlImagenesLogin = new Panel();
            pnlLogin = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlImagenesLogin.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Logo_fondoVerdeMenuSideBar;
            pictureBox1.Location = new Point(-49, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(28, 76);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nombre Usuario";
            txtUser.Size = new Size(300, 33);
            txtUser.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(134, 14);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(87, 32);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(28, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(300, 33);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.FromArgb(10, 64, 88);
            btnIngresar.BackgroundImageLayout = ImageLayout.Center;
            btnIngresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(102, 184);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(160, 45);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btn_ingresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.FromArgb(10, 64, 88);
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(102, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(160, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btn_salir_Click;
            // 
            // pnlImagenesLogin
            // 
            pnlImagenesLogin.Controls.Add(pictureBox1);
            pnlImagenesLogin.Dock = DockStyle.Left;
            pnlImagenesLogin.Location = new Point(0, 0);
            pnlImagenesLogin.Name = "pnlImagenesLogin";
            pnlImagenesLogin.Size = new Size(200, 361);
            pnlImagenesLogin.TabIndex = 6;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnSalir);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(txtUser);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(200, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(360, 361);
            pnlLogin.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.Logo_fondoVerdeMenuSideBar;
            pictureBox2.Location = new Point(505, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 315);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 154, 138);
            ClientSize = new Size(744, 361);
            Controls.Add(pnlLogin);
            Controls.Add(pnlImagenesLogin);
            Controls.Add(pictureBox2);
            MaximumSize = new Size(760, 400);
            MinimumSize = new Size(760, 400);
            Name = "frmLogin";
            Text = "Vitalis";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlImagenesLogin.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Label lblLogin;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnSalir;
        private Panel pnlImagenesLogin;
        private Panel pnlLogin;
        private PictureBox pictureBox2;
    }
}

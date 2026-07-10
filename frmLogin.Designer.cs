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
            txt_user = new TextBox();
            label1 = new Label();
            txt_password = new TextBox();
            btn_ingresar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_GH_VerFondo_Verde_para_el_SideBar;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(520, 546);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_user.Location = new Point(604, 130);
            txt_user.Name = "txt_user";
            txt_user.PlaceholderText = "Nombre Usuario";
            txt_user.Size = new Size(300, 33);
            txt_user.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(717, 67);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(604, 206);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Contraseña";
            txt_password.Size = new Size(300, 33);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(10, 64, 88);
            btn_ingresar.BackgroundImageLayout = ImageLayout.Center;
            btn_ingresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.ForeColor = Color.White;
            btn_ingresar.Location = new Point(679, 324);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(160, 45);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(10, 64, 88);
            btn_salir.BackgroundImageLayout = ImageLayout.Center;
            btn_salir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(679, 393);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(160, 45);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 154, 138);
            ClientSize = new Size(970, 546);
            Controls.Add(btn_salir);
            Controls.Add(btn_ingresar);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_user);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "Vitalis";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_user;
        private Label label1;
        private TextBox txt_password;
        private Button btn_ingresar;
        private Button btn_salir;
    }
}

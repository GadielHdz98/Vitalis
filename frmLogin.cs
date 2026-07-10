namespace Vitalis
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txt_user.Text;
                login.Password = txt_password.Text;

                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

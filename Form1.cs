namespace Nk_Colletion_New
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ariana" && txtPassword.Text == "12345")
            {
                MessageBox.Show("Bienvenido al Sistema Tienda NK Collection, Ariana");
                Formapertura apertura = new Formapertura();
                apertura.Show();
                this.Hide();
            }
            else
            {
                if (txtUsuario.Text != "Ariana" || txtPassword.Text != "12345")
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }
    }
}

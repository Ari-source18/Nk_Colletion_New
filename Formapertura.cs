using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Nk_Colletion_New
{
    public partial class Formapertura : Form
    {
        public Formapertura()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Está seguro de que desea continuar?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Abrir el formulario Menú
                Main menu = new Main();
                menu.Show();

                // Ocultar la ventana actual (opcional)
                this.Hide();
            }
            else
            {
                // Limpiar los TextBox
                txtsaldoinicial.Clear();
                txtvalordolar.Clear();

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.Show();

            this.Close(); // Cierra la pantalla actual
        }
    }
}

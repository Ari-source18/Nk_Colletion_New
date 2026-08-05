using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nk_Colletion_New
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        public void AbrirFormularioEnPanel(Form formulario)
        {
            Panel_Hijo.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Panel_Hijo.Controls.Add(formulario);
            Panel_Hijo.Tag = formulario;

            formulario.Show();
        }

        private void Panel_Padre_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_ventas());
        }
    }
}

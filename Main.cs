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

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_proveedores());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_caja());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_mantenimiento());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_reporte());
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_credito());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form_devoluciones());
        }
    }
}

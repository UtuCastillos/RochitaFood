using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Interfaces
{
    public partial class GestionDeInventario : Form
    {
        public GestionDeInventario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionDeInventario_Load(object sender, EventArgs e)
        {
            Form cerrarSesion = new Login();
            this.Hide();
            cerrarSesion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_domicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {
            Form GestionDeClientes = new GestionDeClientes();
            this.Hide();
            GestionDeClientes.Show();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            Form AppGeneral = new AppGeneral();
            this.Hide();
            AppGeneral.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form cerrarSesion = new Login();
            this.Hide();
            cerrarSesion.Show();
        }
    }
}

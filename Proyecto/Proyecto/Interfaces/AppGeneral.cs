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
    public partial class AppGeneral : Form
    {
        public AppGeneral()
        {
            InitializeComponent();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            //Creo un Objeto (Formulario) que se guarde como "cerrarSesion"
            Form cerrarSesion = new Login();
            //Oculto la ventana actual y abro la otra (que seria Login)
            this.Hide();
            cerrarSesion.Show();

        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {
            Form GestionDeClientes = new GestionDeClientes();
            this.Hide();
            GestionDeClientes.Show();
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_perfil_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cerrarSesion = new Login();
            this.Hide();
            cerrarSesion.Show();
        }
    }
}

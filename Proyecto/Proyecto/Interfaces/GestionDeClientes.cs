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
    public partial class GestionDeClientes : Form
    {
        public GestionDeClientes()
        {
            InitializeComponent();
        }

        

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form Volver = new AppGeneral();
            this.Hide();
            Volver.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtBox_Codigo.Text = dataGridView1[0, fila].Value.ToString();
            textBox_Nombre.Text = dataGridView1[1, fila].Value.ToString();
            textBox_telefono.Text = dataGridView1[2, fila].Value.ToString();
            textBox_domicilio.Text = dataGridView1[3, fila].Value.ToString();

        }

        void limpiar()
        {
            txtBox_Codigo.Text = "";
            textBox_Nombre.Text = "";
            textBox_domicilio.Text = "";
            textBox_telefono.Text = "";
            
        }
    }
}

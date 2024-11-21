using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDefinitiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserva form6 = new FormReserva();
            form6.ShowDialog();
        }

      
        private void vehclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehicle form5 = new FormVehicle();
            form5.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios form2 = new FormUsuarios();
            form2.ShowDialog();
        }

        private void contacteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContracte form7 = new FormContracte();
            form7.ShowDialog();

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargos form3 = new FormCargos();
            form3.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form4 = new FormCliente();
            form4.ShowDialog();
        }
    }
}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

 


        

   

        private void AbrirFormhijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormUsuarios());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCargos());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormReserva());

        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormContracte());

        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormVehicle());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCliente());

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

           private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

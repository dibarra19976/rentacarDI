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
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.rentacarDataSet.reserva);

        }
    }
}

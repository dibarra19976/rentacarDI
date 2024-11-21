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
    public partial class FormVehicle : Form
    {
        public FormVehicle()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehicle' Puede moverla o quitarla según sea necesario.
            this.vehicleTableAdapter.Fill(this.rentacarDataSet.vehicle);

        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveFirst();
        }

        private void vehicleDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveNext();

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveLast();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.RemoveCurrent();

        }
    }
}

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
    public partial class FormCargos : Form
    {
        public FormCargos()
        {
            InitializeComponent();
        }

        private void carrecsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carrecsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.carrecs' Puede moverla o quitarla según sea necesario.
            this.carrecsTableAdapter.Fill(this.rentacarDataSet.carrecs);

        }
    }
}

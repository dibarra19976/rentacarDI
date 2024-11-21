using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDefinitiu
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=rentacar;User=userRentACar;Password=1234;Trusted_Connection=True;TrustServerCertificate=True");
            conn.Open();
            String sql = "SELECT dbo.validar_usuario('" + textBox1.Text + "','" + textBox2.Text + "') AS 'sel';";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                label1.Text = reader["sel"].ToString();

            }
        }
    }
}

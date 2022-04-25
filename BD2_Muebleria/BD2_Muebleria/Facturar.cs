using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD2_Muebleria
{
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=CHESPAVIL;Initial Catalog=MuebleriaMultimedia;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            string nombre = nameBox.Text;
            string apellido = lastNameBox.Text;
            con.Open();
            SqlCommand c = new SqlCommand("EXEC insertFacturacion '" + nombre + "','" + apellido + "'", con);
            SqlDataAdapter cIdFacturacion = new SqlDataAdapter(c);
            DataTable datosFacturacion = new DataTable();
            cIdFacturacion.Fill(datosFacturacion);
            int id = Convert.ToInt32(datosFacturacion.Rows[0]["idFactura"].ToString());
            con.Close();
            Compra comp = new Compra(id);
            comp.Show();
        }
    }
}

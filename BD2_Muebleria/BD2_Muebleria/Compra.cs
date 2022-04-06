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
    public partial class Compra : Form
    {
        int factura;
        public Compra(int idFactura)
        {
            InitializeComponent();
            factura = idFactura;
            this.Text = "Carrito del cliente con número de factura " + idFactura.ToString();
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-JA4GCM36;Initial Catalog=MuebleriaMultimedia;Integrated Security=True");
            actualizarMuebles();

        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JA4GCM36;Initial Catalog=MuebleriaMultimedia;Integrated Security=True");
        
        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'muebleriaMultimediaDataSet.Mueble' Puede moverla o quitarla según sea necesario.
            this.muebleTableAdapter.Fill(this.muebleriaMultimediaDataSet.Mueble);
            // TODO: This line of code loads data into the 'muebleriaMultimediaDataSet.Compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.muebleriaMultimediaDataSet.Compra);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void actualizarMuebles()
        {
            con.Open();
            SqlCommand c = new SqlCommand("EXEC ConsultaInventario", con);
            SqlDataAdapter cData = new SqlDataAdapter(c);
            DataTable dData = new DataTable();
            cData.Fill(dData);
            dataGridView2.DataSource = dData;
            dataGridView2.RowTemplate.Height = 30;
            con.Close();
        }
        private void buttomAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            int idMueble = Convert.ToInt32(numericUpDown1.Value); 
            int cantidad = Convert.ToInt32(numericUpDown2.Value);
            SqlCommand c = new SqlCommand("EXEC FacturarLineaCompra '" + factura + "','" + idMueble + "','" + cantidad + "'", con);
            SqlDataAdapter cData = new SqlDataAdapter(c);
            DataTable dData = new DataTable();
            cData.Fill(dData);
            SqlCommand c2 = new SqlCommand("SELECT * FROM Compra WHERE fk_factura = '" + factura + "'", con);
            SqlDataAdapter cCompras = new SqlDataAdapter(c2);
            DataTable dCompras = new DataTable();
            cCompras.Fill(dCompras);
            dataGridView1.DataSource = dCompras;
            dataGridView1.RowTemplate.Height = 30;
 
            con.Close();
            actualizarMuebles();
        }
    }
}

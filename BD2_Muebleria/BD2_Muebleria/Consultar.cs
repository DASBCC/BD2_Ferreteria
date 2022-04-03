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

namespace BD2_Muebleria
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            CBTipoMueble.Enabled = false;
            bConsultar.Enabled = false;
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JA4GCM36;Initial Catalog=MuebleriaMultimedia;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bConsultar.Enabled = true;
            if (CBTipoConsulta.SelectedIndex == 1)
            {
                CBTipoMueble.Enabled = true;
                getOpciones();

            }
            else if (CBTipoConsulta.SelectedIndex == 0)
            {
                CBTipoMueble.Enabled = false;
            }
        }

        void getOpciones()
        {
            con.Open();
            SqlCommand c = new SqlCommand("SELECT nombre FROM TipoMueble", con);
            SqlDataAdapter cTipos = new SqlDataAdapter(c);
            DataTable datosTipos = new DataTable();
            cTipos.Fill(datosTipos);
            int i = 0;
            while (i <= CBTipoConsulta.Items.Count){
                CBTipoMueble.Items.Insert(i, datosTipos.Rows[i]["nombre"]);
                i++;
            }
            con.Close();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            int tipoConsulta = CBTipoConsulta.SelectedIndex + 1;
            int tipoMueble = -1;
            if (string.IsNullOrEmpty(CBTipoMueble.SelectedText))
            {
                tipoMueble = CBTipoMueble.SelectedIndex + 1;
            }
            con.Open();
            SqlCommand c = new SqlCommand("EXEC ConsultarMuebles '" + tipoConsulta + "','" + tipoMueble + "'", con);
            SqlDataAdapter cData = new SqlDataAdapter(c);
            DataTable dData = new DataTable();
            cData.Fill(dData);
            dataGridView1.DataSource = dData;
            con.Close();
        }
    }
}

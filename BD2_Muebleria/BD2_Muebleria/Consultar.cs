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
using System.IO;

namespace BD2_Muebleria
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            CBTipoMueble.Enabled = false;
            bConsultar.Enabled = false;
            bInsertar.Enabled = false;
            numericUpDown1.Enabled = false;
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
            // TODO: esta línea de código carga datos en la tabla 'muebleriaMultimediaDataSet.Mueble' Puede moverla o quitarla según sea necesario.
            this.muebleTableAdapter.Fill(this.muebleriaMultimediaDataSet.Mueble);

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
            dataGridView1.RowTemplate.Height = 75;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            con.Close();
            bInsertar.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        private void muebleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.muebleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif | *.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                SqlCommand c = new SqlCommand("UPDATE Mueble SET imagen = @imagenInterfaz WHERE idMueble = '" + numericUpDown1.Value.ToString() + "'", con);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                c.Parameters.AddWithValue("imagenInterfaz", ms.ToArray());
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se ingresó la foto exitosamente al mueble con índice " + numericUpDown1.Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown1.Value = dataGridView1.CurrentRow.Index;
            MessageBox.Show(e.RowIndex.ToString());
        }
    }
}

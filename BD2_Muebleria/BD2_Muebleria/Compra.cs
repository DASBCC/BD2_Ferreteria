using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Muebleria
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.muebleriaMultimediaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muebleriaMultimediaDataSet.Compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.muebleriaMultimediaDataSet.Compra);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

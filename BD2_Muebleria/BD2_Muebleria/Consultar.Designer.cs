namespace BD2_Muebleria
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBTipoMueble = new System.Windows.Forms.ComboBox();
            this.bConsultar = new System.Windows.Forms.Button();
            this.muebleriaMultimediaDataSet = new BD2_Muebleria.MuebleriaMultimediaDataSet();
            this.muebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muebleTableAdapter = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter();
            this.tableAdapterManager = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bInsertar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(50, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(917, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Consulta:";
            // 
            // CBTipoConsulta
            // 
            this.CBTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoConsulta.FormattingEnabled = true;
            this.CBTipoConsulta.Items.AddRange(new object[] {
            "Total de muebles",
            "Tipo de mueble"});
            this.CBTipoConsulta.Location = new System.Drawing.Point(235, 33);
            this.CBTipoConsulta.Name = "CBTipoConsulta";
            this.CBTipoConsulta.Size = new System.Drawing.Size(202, 33);
            this.CBTipoConsulta.TabIndex = 2;
            this.CBTipoConsulta.Text = "Seleccionar Tipo";
            this.CBTipoConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de mueble:";
            // 
            // CBTipoMueble
            // 
            this.CBTipoMueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoMueble.ForeColor = System.Drawing.Color.Black;
            this.CBTipoMueble.FormattingEnabled = true;
            this.CBTipoMueble.Location = new System.Drawing.Point(235, 91);
            this.CBTipoMueble.Name = "CBTipoMueble";
            this.CBTipoMueble.Size = new System.Drawing.Size(202, 33);
            this.CBTipoMueble.TabIndex = 4;
            this.CBTipoMueble.Text = "Seleccionar Tipo";
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(503, 34);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(186, 66);
            this.bConsultar.TabIndex = 5;
            this.bConsultar.Text = "Consultar";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // muebleriaMultimediaDataSet
            // 
            this.muebleriaMultimediaDataSet.DataSetName = "MuebleriaMultimediaDataSet";
            this.muebleriaMultimediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muebleBindingSource
            // 
            this.muebleBindingSource.DataMember = "Mueble";
            this.muebleBindingSource.DataSource = this.muebleriaMultimediaDataSet;
            // 
            // muebleTableAdapter
            // 
            this.muebleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.FacturacionTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.MuebleTableAdapter = this.muebleTableAdapter;
            this.tableAdapterManager.TipoMuebleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insertar Imagen:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(220, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bInsertar
            // 
            this.bInsertar.Location = new System.Drawing.Point(503, 150);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(184, 66);
            this.bInsertar.TabIndex = 9;
            this.bInsertar.Text = "Insertar Imagen";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(762, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1012, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bInsertar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bConsultar);
            this.Controls.Add(this.CBTipoMueble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBTipoConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTipoConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBTipoMueble;
        private System.Windows.Forms.Button bConsultar;
        private MuebleriaMultimediaDataSet muebleriaMultimediaDataSet;
        private System.Windows.Forms.BindingSource muebleBindingSource;
        private MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter muebleTableAdapter;
        private MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bInsertar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
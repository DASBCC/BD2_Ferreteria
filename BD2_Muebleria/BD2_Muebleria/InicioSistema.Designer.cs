namespace BD2_Muebleria
{
    partial class InicioSistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.muebleriaMultimediaDataSet = new BD2_Muebleria.MuebleriaMultimediaDataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager();
            this.muebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muebleTableAdapter = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // muebleriaMultimediaDataSet
            // 
            this.muebleriaMultimediaDataSet.DataSetName = "MuebleriaMultimediaDataSet";
            this.muebleriaMultimediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.muebleriaMultimediaDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.MuebleTableAdapter = null;
            this.tableAdapterManager.TipoMuebleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // InicioSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "InicioSistema";
            this.Text = "InicioSistema";
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MuebleriaMultimediaDataSet muebleriaMultimediaDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private MuebleriaMultimediaDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource muebleBindingSource;
        private MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter muebleTableAdapter;
    }
}


namespace BD2_Muebleria
{
    partial class Form1
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
            System.Windows.Forms.Label idMaterialLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.muebleriaMultimediaDataSet = new BD2_Muebleria.MuebleriaMultimediaDataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager();
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idMaterialLabel1 = new System.Windows.Forms.Label();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muebleTableAdapter = new BD2_Muebleria.MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter();
            idMaterialLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idMaterialLabel
            // 
            idMaterialLabel.AutoSize = true;
            idMaterialLabel.Location = new System.Drawing.Point(581, 102);
            idMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idMaterialLabel.Name = "idMaterialLabel";
            idMaterialLabel.Size = new System.Drawing.Size(72, 16);
            idMaterialLabel.TabIndex = 4;
            idMaterialLabel.Text = "id Material:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(581, 130);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 16);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "nombre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 203);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
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
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.materialBindingNavigatorSaveItem});
            this.materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialBindingNavigator.Size = new System.Drawing.Size(1491, 39);
            this.materialBindingNavigator.TabIndex = 3;
            this.materialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // materialBindingNavigatorSaveItem
            // 
            this.materialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialBindingNavigatorSaveItem.Image")));
            this.materialBindingNavigatorSaveItem.Name = "materialBindingNavigatorSaveItem";
            this.materialBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.materialBindingNavigatorSaveItem.Text = "Guardar datos";
            this.materialBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialBindingNavigatorSaveItem_Click_2);
            // 
            // idMaterialLabel1
            // 
            this.idMaterialLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "idMaterial", true));
            this.idMaterialLabel1.Location = new System.Drawing.Point(667, 102);
            this.idMaterialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMaterialLabel1.Name = "idMaterialLabel1";
            this.idMaterialLabel1.Size = new System.Drawing.Size(133, 28);
            this.idMaterialLabel1.TabIndex = 5;
            this.idMaterialLabel1.Text = "label1";
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "nombre", true));
            this.nombreLabel1.Location = new System.Drawing.Point(667, 130);
            this.nombreLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(133, 28);
            this.nombreLabel1.TabIndex = 7;
            this.nombreLabel1.Text = "label1";
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AutoGenerateColumns = false;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.materialDataGridView.DataSource = this.materialBindingSource;
            this.materialDataGridView.Location = new System.Drawing.Point(565, 222);
            this.materialDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.RowHeadersWidth = 51;
            this.materialDataGridView.Size = new System.Drawing.Size(327, 196);
            this.materialDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMaterial";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMaterial";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 615);
            this.Controls.Add(this.materialDataGridView);
            this.Controls.Add(idMaterialLabel);
            this.Controls.Add(this.idMaterialLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(this.materialBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muebleriaMultimediaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MuebleriaMultimediaDataSet muebleriaMultimediaDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private MuebleriaMultimediaDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private MuebleriaMultimediaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton materialBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idMaterialLabel1;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource muebleBindingSource;
        private MuebleriaMultimediaDataSetTableAdapters.MuebleTableAdapter muebleTableAdapter;
    }
}


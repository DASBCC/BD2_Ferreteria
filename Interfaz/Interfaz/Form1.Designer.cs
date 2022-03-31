
namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAgregarInventario = new System.Windows.Forms.Button();
            this.BConsultar = new System.Windows.Forms.Button();
            this.BFacturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAgregarInventario
            // 
            this.BAgregarInventario.Location = new System.Drawing.Point(176, 85);
            this.BAgregarInventario.Name = "BAgregarInventario";
            this.BAgregarInventario.Size = new System.Drawing.Size(184, 49);
            this.BAgregarInventario.TabIndex = 0;
            this.BAgregarInventario.Text = "Agregar a inventario";
            this.BAgregarInventario.UseVisualStyleBackColor = true;
            this.BAgregarInventario.Click += new System.EventHandler(this.BAgregarInventario_Click);
            // 
            // BConsultar
            // 
            this.BConsultar.Location = new System.Drawing.Point(176, 195);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(184, 49);
            this.BConsultar.TabIndex = 1;
            this.BConsultar.Text = "Consultar";
            this.BConsultar.UseVisualStyleBackColor = true;
            // 
            // BFacturar
            // 
            this.BFacturar.Location = new System.Drawing.Point(176, 305);
            this.BFacturar.Name = "BFacturar";
            this.BFacturar.Size = new System.Drawing.Size(184, 49);
            this.BFacturar.TabIndex = 2;
            this.BFacturar.Text = "Facturar";
            this.BFacturar.UseVisualStyleBackColor = true;
            this.BFacturar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 473);
            this.Controls.Add(this.BFacturar);
            this.Controls.Add(this.BConsultar);
            this.Controls.Add(this.BAgregarInventario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAgregarInventario;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Button BFacturar;
    }
}


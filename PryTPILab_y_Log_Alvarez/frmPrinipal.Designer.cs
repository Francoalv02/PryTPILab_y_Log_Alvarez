namespace PryTPILab_y_Log_Alvarez
{
    partial class frmPrinipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinipal));
            this.mspPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodsLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspPrincipal
            // 
            this.mspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.mspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspPrincipal.Name = "mspPrincipal";
            this.mspPrincipal.Size = new System.Drawing.Size(529, 24);
            this.mspPrincipal.TabIndex = 0;
            this.mspPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.sistemaToolStripMenuItem.Text = "Bienvenidos";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.listadoDeTodsLosClientesToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem,
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            this.agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            this.agregarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarNuevoClienteToolStripMenuItem.Text = "Agregar Nuevo Cliente";
            this.agregarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // listadoDeTodsLosClientesToolStripMenuItem
            // 
            this.listadoDeTodsLosClientesToolStripMenuItem.Name = "listadoDeTodsLosClientesToolStripMenuItem";
            this.listadoDeTodsLosClientesToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.listadoDeTodsLosClientesToolStripMenuItem.Text = "Listado de Tods los Clientes";
            this.listadoDeTodsLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodsLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem.Name = "listadoDeClientesDeudoresToolStripMenuItem";
            this.listadoDeClientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.listadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de Clientes Deudores";
            this.listadoDeClientesDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeudoresToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeUnaCiudadToolStripMenuItem
            // 
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Name = "listadoDeClientesDeUnaCiudadToolStripMenuItem";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Text = "Listado de Clientes de una Ciudad";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeUnaCiudadToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrinipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 341);
            this.Controls.Add(this.mspPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.mspPrincipal;
            this.Name = "frmPrinipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.frmPrinipal_Load);
            this.mspPrincipal.ResumeLayout(false);
            this.mspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodsLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeUnaCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


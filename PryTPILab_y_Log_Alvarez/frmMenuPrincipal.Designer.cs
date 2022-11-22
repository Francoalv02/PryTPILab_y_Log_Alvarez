namespace PryTPILab_y_Log_Alvarez
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.mspPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.clToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.mspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspPrincipal.Name = "mspPrincipal";
            this.mspPrincipal.Size = new System.Drawing.Size(531, 24);
            this.mspPrincipal.TabIndex = 2;
            this.mspPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.sistemaToolStripMenuItem.Text = "Bienvenidos";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // clToolStripMenuItem
            // 
            this.clToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónDeClientesToolStripMenuItem,
            this.buscarClientesToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.clToolStripMenuItem.Name = "clToolStripMenuItem";
            this.clToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clToolStripMenuItem.Text = "Clientes";
            // 
            // actualizaciónDeClientesToolStripMenuItem
            // 
            this.actualizaciónDeClientesToolStripMenuItem.Name = "actualizaciónDeClientesToolStripMenuItem";
            this.actualizaciónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.actualizaciónDeClientesToolStripMenuItem.Text = "Agregar Nuevo Cliente";
            this.actualizaciónDeClientesToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónDeClientesToolStripMenuItem_Click);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.buscarClientesToolStripMenuItem.Text = "Actualización De Clientes";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosClientesToolStripMenuItem,
            this.clientesDeudoresToolStripMenuItem,
            this.porActividadToolStripMenuItem,
            this.porCiudadToolStripMenuItem,
            this.porBarrioToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // todosLosClientesToolStripMenuItem
            // 
            this.todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            this.todosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.todosLosClientesToolStripMenuItem.Text = "Todos Los Clientes";
            this.todosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.todosLosClientesToolStripMenuItem_Click);
            // 
            // clientesDeudoresToolStripMenuItem
            // 
            this.clientesDeudoresToolStripMenuItem.Name = "clientesDeudoresToolStripMenuItem";
            this.clientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.clientesDeudoresToolStripMenuItem.Text = "Clientes Deudores";
            this.clientesDeudoresToolStripMenuItem.Click += new System.EventHandler(this.clientesDeudoresToolStripMenuItem_Click);
            // 
            // porActividadToolStripMenuItem
            // 
            this.porActividadToolStripMenuItem.Name = "porActividadToolStripMenuItem";
            this.porActividadToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porActividadToolStripMenuItem.Text = "Por Actividad";
            this.porActividadToolStripMenuItem.Click += new System.EventHandler(this.porActividadToolStripMenuItem_Click);
            // 
            // porCiudadToolStripMenuItem
            // 
            this.porCiudadToolStripMenuItem.Name = "porCiudadToolStripMenuItem";
            this.porCiudadToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porCiudadToolStripMenuItem.Text = "Por Ciudad";
            this.porCiudadToolStripMenuItem.Click += new System.EventHandler(this.porCiudadToolStripMenuItem_Click);
            // 
            // porBarrioToolStripMenuItem
            // 
            this.porBarrioToolStripMenuItem.Name = "porBarrioToolStripMenuItem";
            this.porBarrioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porBarrioToolStripMenuItem.Text = "Por Barrio";
            this.porBarrioToolStripMenuItem.Click += new System.EventHandler(this.porBarrioToolStripMenuItem_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 364);
            this.Controls.Add(this.mspPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.mspPrincipal.ResumeLayout(false);
            this.mspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porBarrioToolStripMenuItem;
    }
}
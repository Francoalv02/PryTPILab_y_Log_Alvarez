namespace PryTPILab_y_Log_Alvarez
{
    partial class frmListadoClientes
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMostrarListado = new System.Windows.Forms.Button();
            this.dgwTodosClientes = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(287, 269);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(162, 47);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar Lista";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnMostrarListado
            // 
            this.btnMostrarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListado.Location = new System.Drawing.Point(472, 269);
            this.btnMostrarListado.Name = "btnMostrarListado";
            this.btnMostrarListado.Size = new System.Drawing.Size(162, 47);
            this.btnMostrarListado.TabIndex = 18;
            this.btnMostrarListado.Text = "Mostrar Listado";
            this.btnMostrarListado.UseVisualStyleBackColor = true;
            this.btnMostrarListado.Click += new System.EventHandler(this.btnMostrarListado_Click);
            // 
            // dgwTodosClientes
            // 
            this.dgwTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Deuda,
            this.Barrio,
            this.Ciudad,
            this.Actividad,
            this.Saldo,
            this.LimiteDeuda});
            this.dgwTodosClientes.Location = new System.Drawing.Point(-4, 0);
            this.dgwTodosClientes.Name = "dgwTodosClientes";
            this.dgwTodosClientes.Size = new System.Drawing.Size(638, 246);
            this.dgwTodosClientes.TabIndex = 17;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.Width = 48;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Deuda
            // 
            this.Deuda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 64;
            // 
            // Barrio
            // 
            this.Barrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.Width = 59;
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 65;
            // 
            // Actividad
            // 
            this.Actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.Width = 76;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 59;
            // 
            // LimiteDeuda
            // 
            this.LimiteDeuda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LimiteDeuda.HeaderText = "LimiteDeuda";
            this.LimiteDeuda.Name = "LimiteDeuda";
            this.LimiteDeuda.Width = 91;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 335);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMostrarListado);
            this.Controls.Add(this.dgwTodosClientes);
            this.Name = "frmListadoClientes";
            this.Text = "Listado De Todos Los Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMostrarListado;
        private System.Windows.Forms.DataGridView dgwTodosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteDeuda;
    }
}
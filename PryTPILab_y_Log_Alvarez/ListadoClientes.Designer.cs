namespace PryTPILab_y_Log_Alvarez
{
    partial class ListadoClientes
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
            this.dgwTodosClientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarListado = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTodosClientes
            // 
            this.dgwTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreyApellido,
            this.Actividad,
            this.Ciudad,
            this.Barrio,
            this.Direccion,
            this.Saldo});
            this.dgwTodosClientes.Location = new System.Drawing.Point(0, 0);
            this.dgwTodosClientes.Name = "dgwTodosClientes";
            this.dgwTodosClientes.Size = new System.Drawing.Size(728, 274);
            this.dgwTodosClientes.TabIndex = 14;
            // 
            // btnMostrarListado
            // 
            this.btnMostrarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListado.Location = new System.Drawing.Point(362, 297);
            this.btnMostrarListado.Name = "btnMostrarListado";
            this.btnMostrarListado.Size = new System.Drawing.Size(162, 47);
            this.btnMostrarListado.TabIndex = 15;
            this.btnMostrarListado.Text = "Mostrar Listado";
            this.btnMostrarListado.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(554, 297);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(162, 47);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar Lista";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.Width = 48;
            // 
            // NombreyApellido
            // 
            this.NombreyApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreyApellido.HeaderText = "Nombre y Apellido";
            this.NombreyApellido.Name = "NombreyApellido";
            // 
            // Actividad
            // 
            this.Actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Barrio
            // 
            this.Barrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 356);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMostrarListado);
            this.Controls.Add(this.dgwTodosClientes);
            this.Name = "ListadoClientes";
            this.Text = "ListadoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTodosClientes;
        private System.Windows.Forms.Button btnMostrarListado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}
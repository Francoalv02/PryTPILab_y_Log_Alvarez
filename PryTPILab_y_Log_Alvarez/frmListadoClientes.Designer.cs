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
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(434, 331);
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
            this.btnMostrarListado.Location = new System.Drawing.Point(619, 331);
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
            this.dgwTodosClientes.Location = new System.Drawing.Point(-4, 0);
            this.dgwTodosClientes.Name = "dgwTodosClientes";
            this.dgwTodosClientes.Size = new System.Drawing.Size(800, 304);
            this.dgwTodosClientes.TabIndex = 17;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 399);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMostrarListado);
            this.Controls.Add(this.dgwTodosClientes);
            this.Name = "frmListadoClientes";
            this.Text = "Listado De Todos Los Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTodosClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMostrarListado;
        private System.Windows.Forms.DataGridView dgwTodosClientes;
    }
}
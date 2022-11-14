namespace PryTPILab_y_Log_Alvarez
{
    partial class frmListadoClientesDeudores
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
            this.btn = new System.Windows.Forms.Button();
            this.dgwGrillaDeudores = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResultadoPromedio = new System.Windows.Forms.Label();
            this.lblResultadoCantidad = new System.Windows.Forms.Label();
            this.lblResultadoDeuda = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrillaDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(469, 362);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(131, 37);
            this.btn.TabIndex = 14;
            this.btn.Text = "Buscar Cliente";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgwGrillaDeudores
            // 
            this.dgwGrillaDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGrillaDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreyApellido,
            this.Deuda});
            this.dgwGrillaDeudores.Location = new System.Drawing.Point(-1, 3);
            this.dgwGrillaDeudores.Name = "dgwGrillaDeudores";
            this.dgwGrillaDeudores.Size = new System.Drawing.Size(622, 220);
            this.dgwGrillaDeudores.TabIndex = 13;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // NombreyApellido
            // 
            this.NombreyApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreyApellido.HeaderText = "Nombre y Apellido";
            this.NombreyApellido.Name = "NombreyApellido";
            // 
            // Deuda
            // 
            this.Deuda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuda.Location = new System.Drawing.Point(12, 238);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(251, 27);
            this.lblDeuda.TabIndex = 15;
            this.lblDeuda.Text = "Deuda Total:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantidad.Location = new System.Drawing.Point(12, 280);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(251, 32);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad de Deudores:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromedio.Location = new System.Drawing.Point(12, 321);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(251, 32);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio de la Deuda:";
            // 
            // lblResultadoPromedio
            // 
            this.lblResultadoPromedio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPromedio.Location = new System.Drawing.Point(189, 321);
            this.lblResultadoPromedio.Name = "lblResultadoPromedio";
            this.lblResultadoPromedio.Size = new System.Drawing.Size(65, 32);
            this.lblResultadoPromedio.TabIndex = 20;
            // 
            // lblResultadoCantidad
            // 
            this.lblResultadoCantidad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCantidad.Location = new System.Drawing.Point(189, 280);
            this.lblResultadoCantidad.Name = "lblResultadoCantidad";
            this.lblResultadoCantidad.Size = new System.Drawing.Size(65, 24);
            this.lblResultadoCantidad.TabIndex = 19;
            // 
            // lblResultadoDeuda
            // 
            this.lblResultadoDeuda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultadoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDeuda.Location = new System.Drawing.Point(128, 238);
            this.lblResultadoDeuda.Name = "lblResultadoDeuda";
            this.lblResultadoDeuda.Size = new System.Drawing.Size(79, 27);
            this.lblResultadoDeuda.TabIndex = 18;
            this.lblResultadoDeuda.Click += new System.EventHandler(this.lblResultadoDeuda_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(332, 362);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(131, 37);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar Todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmListadoClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 411);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblResultadoPromedio);
            this.Controls.Add(this.lblResultadoCantidad);
            this.Controls.Add(this.lblResultadoDeuda);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dgwGrillaDeudores);
            this.Name = "frmListadoClientesDeudores";
            this.Text = "frmListadoClientesDeudores";
            this.Load += new System.EventHandler(this.frmListadoClientesDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGrillaDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgwGrillaDeudores;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResultadoPromedio;
        private System.Windows.Forms.Label lblResultadoCantidad;
        private System.Windows.Forms.Label lblResultadoDeuda;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}
namespace PryTPILab_y_Log_Alvarez
{
    partial class frmBusquedaCliente
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
            this.txtBusquedaDni = new System.Windows.Forms.TextBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblnNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblResultadoNombreCliente = new System.Windows.Forms.Label();
            this.lblResultadoDeuda = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblResultadoSaldo = new System.Windows.Forms.Label();
            this.lblLimiteDeuda = new System.Windows.Forms.Label();
            this.gbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.txtLimiteDeuda = new System.Windows.Forms.TextBox();
            this.gbCargaDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaDni
            // 
            this.txtBusquedaDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaDni.Location = new System.Drawing.Point(163, 34);
            this.txtBusquedaDni.Name = "txtBusquedaDni";
            this.txtBusquedaDni.Size = new System.Drawing.Size(207, 26);
            this.txtBusquedaDni.TabIndex = 1;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(19, 37);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(115, 20);
            this.lblCodigoCliente.TabIndex = 2;
            this.lblCodigoCliente.Text = "Dni del Cliente:";
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(239, 85);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(131, 37);
            this.btnCargarCliente.TabIndex = 11;
            this.btnCargarCliente.Text = "Buscar Cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(23, 480);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 37);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(185, 480);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 37);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(339, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 37);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblnNombre
            // 
            this.lblnNombre.AutoSize = true;
            this.lblnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnNombre.Location = new System.Drawing.Point(17, 61);
            this.lblnNombre.Name = "lblnNombre";
            this.lblnNombre.Size = new System.Drawing.Size(69, 20);
            this.lblnNombre.TabIndex = 4;
            this.lblnNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(17, 122);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(61, 20);
            this.lblDeuda.TabIndex = 9;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblResultadoNombreCliente
            // 
            this.lblResultadoNombreCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNombreCliente.Location = new System.Drawing.Point(101, 61);
            this.lblResultadoNombreCliente.Name = "lblResultadoNombreCliente";
            this.lblResultadoNombreCliente.Size = new System.Drawing.Size(294, 33);
            this.lblResultadoNombreCliente.TabIndex = 10;
            // 
            // lblResultadoDeuda
            // 
            this.lblResultadoDeuda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDeuda.Location = new System.Drawing.Point(101, 122);
            this.lblResultadoDeuda.Name = "lblResultadoDeuda";
            this.lblResultadoDeuda.Size = new System.Drawing.Size(294, 33);
            this.lblResultadoDeuda.TabIndex = 11;
            this.lblResultadoDeuda.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(17, 178);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 12;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblResultadoSaldo
            // 
            this.lblResultadoSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSaldo.Location = new System.Drawing.Point(101, 178);
            this.lblResultadoSaldo.Name = "lblResultadoSaldo";
            this.lblResultadoSaldo.Size = new System.Drawing.Size(294, 33);
            this.lblResultadoSaldo.TabIndex = 13;
            // 
            // lblLimiteDeuda
            // 
            this.lblLimiteDeuda.AutoSize = true;
            this.lblLimiteDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteDeuda.Location = new System.Drawing.Point(17, 238);
            this.lblLimiteDeuda.Name = "lblLimiteDeuda";
            this.lblLimiteDeuda.Size = new System.Drawing.Size(129, 20);
            this.lblLimiteDeuda.TabIndex = 14;
            this.lblLimiteDeuda.Text = "Limite de Deuda:";
            // 
            // gbCargaDeDatos
            // 
            this.gbCargaDeDatos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbCargaDeDatos.Controls.Add(this.txtLimiteDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblLimiteDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblResultadoSaldo);
            this.gbCargaDeDatos.Controls.Add(this.lblSaldo);
            this.gbCargaDeDatos.Controls.Add(this.lblResultadoDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblResultadoNombreCliente);
            this.gbCargaDeDatos.Controls.Add(this.lblDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblnNombre);
            this.gbCargaDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDeDatos.Location = new System.Drawing.Point(1, 137);
            this.gbCargaDeDatos.Name = "gbCargaDeDatos";
            this.gbCargaDeDatos.Size = new System.Drawing.Size(469, 293);
            this.gbCargaDeDatos.TabIndex = 10;
            this.gbCargaDeDatos.TabStop = false;
            this.gbCargaDeDatos.Text = "Datos del Cliente";
            this.gbCargaDeDatos.Enter += new System.EventHandler(this.gbCargaDeDatos_Enter);
            // 
            // txtLimiteDeuda
            // 
            this.txtLimiteDeuda.Enabled = false;
            this.txtLimiteDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteDeuda.Location = new System.Drawing.Point(152, 228);
            this.txtLimiteDeuda.Name = "txtLimiteDeuda";
            this.txtLimiteDeuda.Size = new System.Drawing.Size(243, 35);
            this.txtLimiteDeuda.TabIndex = 15;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 529);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.txtBusquedaDni);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Name = "frmBusquedaCliente";
            this.Text = " Busqueda de un Cliente";
            this.Load += new System.EventHandler(this.frmBusquedaCliente_Load);
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusquedaDni;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblnNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblResultadoNombreCliente;
        private System.Windows.Forms.Label lblResultadoDeuda;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblResultadoSaldo;
        private System.Windows.Forms.Label lblLimiteDeuda;
        private System.Windows.Forms.GroupBox gbCargaDeDatos;
        private System.Windows.Forms.TextBox txtLimiteDeuda;
    }
}
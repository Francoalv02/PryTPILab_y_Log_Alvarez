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
            this.gbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblnNombre = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbCargaDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargaDeDatos
            // 
            this.gbCargaDeDatos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbCargaDeDatos.Controls.Add(this.label1);
            this.gbCargaDeDatos.Controls.Add(this.lblNombreCliente);
            this.gbCargaDeDatos.Controls.Add(this.lblDeuda);
            this.gbCargaDeDatos.Controls.Add(this.lblnNombre);
            this.gbCargaDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDeDatos.Location = new System.Drawing.Point(22, 148);
            this.gbCargaDeDatos.Name = "gbCargaDeDatos";
            this.gbCargaDeDatos.Size = new System.Drawing.Size(448, 190);
            this.gbCargaDeDatos.TabIndex = 10;
            this.gbCargaDeDatos.TabStop = false;
            this.gbCargaDeDatos.Text = "Datos del Cliente";
            this.gbCargaDeDatos.Enter += new System.EventHandler(this.gbCargaDeDatos_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 11;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(101, 48);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(294, 33);
            this.lblNombreCliente.TabIndex = 10;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(17, 122);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(54, 20);
            this.lblDeuda.TabIndex = 9;
            this.lblDeuda.Text = "Saldo:";
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
            // txtNombreApellido
            // 
            this.txtNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreApellido.Location = new System.Drawing.Point(163, 34);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(207, 26);
            this.txtNombreApellido.TabIndex = 1;
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(19, 37);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(116, 20);
            this.lblCodigoCliente.TabIndex = 2;
            this.lblCodigoCliente.Text = "Codigo Cliente:";
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(23, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 37);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(194, 376);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 37);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(339, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 37);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 440);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "frmBusquedaCliente";
            this.Text = " Busqueda de un Cliente";
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaDeDatos;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblnNombre;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
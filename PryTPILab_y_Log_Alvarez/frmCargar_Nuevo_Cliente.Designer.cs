namespace PryTPILab_y_Log_Alvarez
{
    partial class frmCargar_Nuevo_Cliente
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
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblNombreyApellido = new System.Windows.Forms.Label();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.txtLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.lblciudad = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.gbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.gbCargaDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(173, 271);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(131, 37);
            this.btnCargarCliente.TabIndex = 0;
            this.btnCargarCliente.Text = "Cargar Cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreApellido.Location = new System.Drawing.Point(186, 53);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(206, 26);
            this.txtNombreApellido.TabIndex = 1;
            // 
            // lblNombreyApellido
            // 
            this.lblNombreyApellido.AutoSize = true;
            this.lblNombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreyApellido.Location = new System.Drawing.Point(24, 53);
            this.lblNombreyApellido.Name = "lblNombreyApellido";
            this.lblNombreyApellido.Size = new System.Drawing.Size(140, 20);
            this.lblNombreyApellido.TabIndex = 2;
            this.lblNombreyApellido.Text = "Nombre y Apellido:";
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(24, 118);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(135, 20);
            this.lblLimiteDeCredito.TabIndex = 4;
            this.lblLimiteDeCredito.Text = "Limite De Credito:";
            // 
            // txtLimiteDeCredito
            // 
            this.txtLimiteDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteDeCredito.Location = new System.Drawing.Point(186, 112);
            this.txtLimiteDeCredito.Name = "txtLimiteDeCredito";
            this.txtLimiteDeCredito.Size = new System.Drawing.Size(206, 26);
            this.txtLimiteDeCredito.TabIndex = 3;
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(24, 176);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(63, 20);
            this.lblciudad.TabIndex = 6;
            this.lblciudad.Text = "Ciudad:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(331, 271);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 37);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // cbCiudad
            // 
            this.cbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(186, 168);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(206, 28);
            this.cbCiudad.TabIndex = 8;
            // 
            // gbCargaDeDatos
            // 
            this.gbCargaDeDatos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbCargaDeDatos.Controls.Add(this.cbCiudad);
            this.gbCargaDeDatos.Controls.Add(this.txtNombreApellido);
            this.gbCargaDeDatos.Controls.Add(this.txtLimiteDeCredito);
            this.gbCargaDeDatos.Controls.Add(this.lblLimiteDeCredito);
            this.gbCargaDeDatos.Controls.Add(this.lblNombreyApellido);
            this.gbCargaDeDatos.Controls.Add(this.lblciudad);
            this.gbCargaDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDeDatos.Location = new System.Drawing.Point(12, 12);
            this.gbCargaDeDatos.Name = "gbCargaDeDatos";
            this.gbCargaDeDatos.Size = new System.Drawing.Size(420, 233);
            this.gbCargaDeDatos.TabIndex = 9;
            this.gbCargaDeDatos.TabStop = false;
            this.gbCargaDeDatos.Text = "Carga de Datos";
            // 
            // frmCargar_Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(459, 320);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Name = "frmCargar_Nuevo_Cliente";
            this.Text = "Cargar Nuevo Cliente";
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblNombreyApellido;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.TextBox txtLimiteDeCredito;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.GroupBox gbCargaDeDatos;
    }
}
namespace PryTPILab_y_Log_Alvarez
{
    partial class frmListadoClienteDeUnaCiudad
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
            this.dgwLisCiudad = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblNombreMayorPromedio = new System.Windows.Forms.Label();
            this.lblMayorPromedio = new System.Windows.Forms.Label();
            this.lblNombreTotalSueldo = new System.Windows.Forms.Label();
            this.lblNombreMenorPromedio = new System.Windows.Forms.Label();
            this.lblMenorPromedio = new System.Windows.Forms.Label();
            this.lblTotalSueldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLisCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLisCiudad
            // 
            this.dgwLisCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLisCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreyApellido});
            this.dgwLisCiudad.Location = new System.Drawing.Point(2, 101);
            this.dgwLisCiudad.Name = "dgwLisCiudad";
            this.dgwLisCiudad.Size = new System.Drawing.Size(635, 184);
            this.dgwLisCiudad.TabIndex = 14;
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
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(35, 417);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(111, 37);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cbActividad
            // 
            this.cbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(227, 30);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(329, 28);
            this.cbActividad.TabIndex = 16;
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(21, 33);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(261, 49);
            this.lblActividad.TabIndex = 17;
            this.lblActividad.Text = "Seleccione una actividad:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 296);
            this.label1.TabIndex = 18;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(247, 417);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 37);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(445, 417);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(111, 37);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // lblNombreMayorPromedio
            // 
            this.lblNombreMayorPromedio.AutoSize = true;
            this.lblNombreMayorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMayorPromedio.Location = new System.Drawing.Point(14, 303);
            this.lblNombreMayorPromedio.Name = "lblNombreMayorPromedio";
            this.lblNombreMayorPromedio.Size = new System.Drawing.Size(123, 20);
            this.lblNombreMayorPromedio.TabIndex = 21;
            this.lblNombreMayorPromedio.Text = "Mayor Promedio";
            // 
            // lblMayorPromedio
            // 
            this.lblMayorPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMayorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorPromedio.Location = new System.Drawing.Point(149, 303);
            this.lblMayorPromedio.Name = "lblMayorPromedio";
            this.lblMayorPromedio.Size = new System.Drawing.Size(133, 30);
            this.lblMayorPromedio.TabIndex = 22;
            this.lblMayorPromedio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombreTotalSueldo
            // 
            this.lblNombreTotalSueldo.AutoSize = true;
            this.lblNombreTotalSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTotalSueldo.Location = new System.Drawing.Point(11, 355);
            this.lblNombreTotalSueldo.Name = "lblNombreTotalSueldo";
            this.lblNombreTotalSueldo.Size = new System.Drawing.Size(132, 20);
            this.lblNombreTotalSueldo.TabIndex = 23;
            this.lblNombreTotalSueldo.Text = "Total de Sueldos:";
            // 
            // lblNombreMenorPromedio
            // 
            this.lblNombreMenorPromedio.AutoSize = true;
            this.lblNombreMenorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMenorPromedio.Location = new System.Drawing.Point(331, 303);
            this.lblNombreMenorPromedio.Name = "lblNombreMenorPromedio";
            this.lblNombreMenorPromedio.Size = new System.Drawing.Size(125, 20);
            this.lblNombreMenorPromedio.TabIndex = 24;
            this.lblNombreMenorPromedio.Text = "Menor Promedio";
            // 
            // lblMenorPromedio
            // 
            this.lblMenorPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMenorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorPromedio.Location = new System.Drawing.Point(466, 303);
            this.lblMenorPromedio.Name = "lblMenorPromedio";
            this.lblMenorPromedio.Size = new System.Drawing.Size(133, 30);
            this.lblMenorPromedio.TabIndex = 25;
            // 
            // lblTotalSueldo
            // 
            this.lblTotalSueldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSueldo.Location = new System.Drawing.Point(149, 355);
            this.lblTotalSueldo.Name = "lblTotalSueldo";
            this.lblTotalSueldo.Size = new System.Drawing.Size(133, 30);
            this.lblTotalSueldo.TabIndex = 26;
            // 
            // frmListadoClienteDeUnaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 464);
            this.Controls.Add(this.lblTotalSueldo);
            this.Controls.Add(this.lblMenorPromedio);
            this.Controls.Add(this.lblNombreMenorPromedio);
            this.Controls.Add(this.lblNombreTotalSueldo);
            this.Controls.Add(this.lblMayorPromedio);
            this.Controls.Add(this.lblNombreMayorPromedio);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgwLisCiudad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoClienteDeUnaCiudad";
            this.Text = "Listado Cliente De Una Ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLisCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLisCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellido;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblNombreMayorPromedio;
        private System.Windows.Forms.Label lblMayorPromedio;
        private System.Windows.Forms.Label lblNombreTotalSueldo;
        private System.Windows.Forms.Label lblNombreMenorPromedio;
        private System.Windows.Forms.Label lblMenorPromedio;
        private System.Windows.Forms.Label lblTotalSueldo;
    }
}
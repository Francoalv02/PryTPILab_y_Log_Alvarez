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
            this.dgwGillaDeudores = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGillaDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(479, 207);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(131, 37);
            this.btn.TabIndex = 14;
            this.btn.Text = "Buscar Cliente";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // dgwGillaDeudores
            // 
            this.dgwGillaDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGillaDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreyApellido,
            this.Deuda});
            this.dgwGillaDeudores.Location = new System.Drawing.Point(-1, 3);
            this.dgwGillaDeudores.Name = "dgwGillaDeudores";
            this.dgwGillaDeudores.Size = new System.Drawing.Size(622, 177);
            this.dgwGillaDeudores.TabIndex = 13;
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
            this.Deuda.HeaderText = "Saldo";
            this.Deuda.Name = "Deuda";
            // 
            // frmListadoClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 266);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dgwGillaDeudores);
            this.Name = "frmListadoClientesDeudores";
            this.Text = "frmListadoClientesDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.dgwGillaDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgwGillaDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}
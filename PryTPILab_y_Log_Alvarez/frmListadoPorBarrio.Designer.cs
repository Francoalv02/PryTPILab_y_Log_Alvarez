namespace PryTPILab_y_Log_Alvarez
{
    partial class frmListadoPorBarrio
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
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.dgwLisBarrio = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLisBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBarrio
            // 
            this.cbBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(227, 39);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(329, 28);
            this.cbBarrio.TabIndex = 29;
            // 
            // dgwLisBarrio
            // 
            this.dgwLisBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLisBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreyApellido});
            this.dgwLisBarrio.Location = new System.Drawing.Point(2, 110);
            this.dgwLisBarrio.Name = "dgwLisBarrio";
            this.dgwLisBarrio.Size = new System.Drawing.Size(635, 184);
            this.dgwLisBarrio.TabIndex = 27;
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
            // lblBarrio
            // 
            this.lblBarrio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(21, 42);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(261, 49);
            this.lblBarrio.TabIndex = 30;
            this.lblBarrio.Text = "Seleccione un Barrio:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 296);
            this.label1.TabIndex = 31;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(514, 309);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(111, 37);
            this.btnListar.TabIndex = 28;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmListadoPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 374);
            this.Controls.Add(this.cbBarrio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgwLisBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoPorBarrio";
            this.Text = "frmListadoPorBarrio";
            this.Load += new System.EventHandler(this.frmListadoPorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLisBarrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBarrio;
        private System.Windows.Forms.DataGridView dgwLisBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellido;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
    }
}
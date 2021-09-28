namespace ProyectoZambranito.Vista
{
    partial class frmClientes
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 2;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = global::ProyectoZambranito.Properties.Resources.Webp_net_resizeimage__8_;
            this.btnClientes.Location = new System.Drawing.Point(92, 198);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(171, 137);
            this.btnClientes.TabIndex = 13;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(373, 111);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(236, 20);
            this.txtNombreCliente.TabIndex = 14;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(282, 185);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(571, 252);
            this.dtgClientes.TabIndex = 15;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(903, 583);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridView dtgClientes;
    }
}
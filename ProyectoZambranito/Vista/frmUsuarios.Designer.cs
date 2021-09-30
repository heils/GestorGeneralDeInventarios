
namespace ProyectoZambranito.Vista
{
    partial class frmUsuarios
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btbGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(26, 89);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.Size = new System.Drawing.Size(860, 229);
            this.dtgUsuarios.TabIndex = 16;
            // 
            // btbGestionarUsuarios
            // 
            this.btbGestionarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbGestionarUsuarios.Location = new System.Drawing.Point(582, 21);
            this.btbGestionarUsuarios.Name = "btbGestionarUsuarios";
            this.btbGestionarUsuarios.Size = new System.Drawing.Size(237, 39);
            this.btbGestionarUsuarios.TabIndex = 17;
            this.btbGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btbGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btbGestionarUsuarios.Click += new System.EventHandler(this.btbGestionarUsuarios_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 386);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 46);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(915, 444);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btbGestionarUsuarios);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btbGestionarUsuarios;
        private System.Windows.Forms.Button btnRegresar;
    }
}
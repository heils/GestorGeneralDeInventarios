
namespace ProyectoZambranito.Vista
{
    partial class frmProveedores
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
            this.tbcProveedores = new System.Windows.Forms.TabControl();
            this.tbpProveedores = new System.Windows.Forms.TabPage();
            this.gbMostrarProveedores = new System.Windows.Forms.GroupBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.tbpEliminarProveedor = new System.Windows.Forms.TabPage();
            this.gbEliminarProveedor = new System.Windows.Forms.GroupBox();
            this.lblTextoId = new System.Windows.Forms.Label();
            this.txtIdProveedorEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.tbpAgregar = new System.Windows.Forms.TabPage();
            this.gbAgregarProveedor = new System.Windows.Forms.GroupBox();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtCedulaProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcProveedores.SuspendLayout();
            this.tbpProveedores.SuspendLayout();
            this.gbMostrarProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.tbpEliminarProveedor.SuspendLayout();
            this.gbEliminarProveedor.SuspendLayout();
            this.tbpAgregar.SuspendLayout();
            this.gbAgregarProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcProveedores
            // 
            this.tbcProveedores.Controls.Add(this.tbpProveedores);
            this.tbcProveedores.Controls.Add(this.tbpEliminarProveedor);
            this.tbcProveedores.Controls.Add(this.tbpAgregar);
            this.tbcProveedores.Location = new System.Drawing.Point(12, 12);
            this.tbcProveedores.Name = "tbcProveedores";
            this.tbcProveedores.SelectedIndex = 0;
            this.tbcProveedores.Size = new System.Drawing.Size(776, 446);
            this.tbcProveedores.TabIndex = 0;
            // 
            // tbpProveedores
            // 
            this.tbpProveedores.Controls.Add(this.gbMostrarProveedores);
            this.tbpProveedores.Location = new System.Drawing.Point(4, 22);
            this.tbpProveedores.Name = "tbpProveedores";
            this.tbpProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProveedores.Size = new System.Drawing.Size(768, 420);
            this.tbpProveedores.TabIndex = 0;
            this.tbpProveedores.Text = "Provedores";
            this.tbpProveedores.UseVisualStyleBackColor = true;
            // 
            // gbMostrarProveedores
            // 
            this.gbMostrarProveedores.Controls.Add(this.btnCarga);
            this.gbMostrarProveedores.Controls.Add(this.btnBuscarProveedor);
            this.gbMostrarProveedores.Controls.Add(this.txtIdProveedor);
            this.gbMostrarProveedores.Controls.Add(this.label1);
            this.gbMostrarProveedores.Controls.Add(this.dtgProveedores);
            this.gbMostrarProveedores.Location = new System.Drawing.Point(6, 6);
            this.gbMostrarProveedores.Name = "gbMostrarProveedores";
            this.gbMostrarProveedores.Size = new System.Drawing.Size(756, 403);
            this.gbMostrarProveedores.TabIndex = 0;
            this.gbMostrarProveedores.TabStop = false;
            // 
            // btnCarga
            // 
            this.btnCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarga.Location = new System.Drawing.Point(6, 366);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(114, 23);
            this.btnCarga.TabIndex = 4;
            this.btnCarga.Text = "Mostrar Provedores";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(549, 30);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(325, 32);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(186, 20);
            this.txtIdProveedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el id del proveedor que desea ver";
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Location = new System.Drawing.Point(6, 74);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.Size = new System.Drawing.Size(744, 246);
            this.dtgProveedores.TabIndex = 0;
            // 
            // tbpEliminarProveedor
            // 
            this.tbpEliminarProveedor.Controls.Add(this.gbEliminarProveedor);
            this.tbpEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpEliminarProveedor.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminarProveedor.Name = "tbpEliminarProveedor";
            this.tbpEliminarProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarProveedor.Size = new System.Drawing.Size(768, 420);
            this.tbpEliminarProveedor.TabIndex = 1;
            this.tbpEliminarProveedor.Text = "Eliminara un proveedor";
            this.tbpEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // gbEliminarProveedor
            // 
            this.gbEliminarProveedor.Controls.Add(this.lblTextoId);
            this.gbEliminarProveedor.Controls.Add(this.txtIdProveedorEliminar);
            this.gbEliminarProveedor.Controls.Add(this.btnEliminarProveedor);
            this.gbEliminarProveedor.Location = new System.Drawing.Point(20, 34);
            this.gbEliminarProveedor.Name = "gbEliminarProveedor";
            this.gbEliminarProveedor.Size = new System.Drawing.Size(494, 297);
            this.gbEliminarProveedor.TabIndex = 1;
            this.gbEliminarProveedor.TabStop = false;
            // 
            // lblTextoId
            // 
            this.lblTextoId.AutoSize = true;
            this.lblTextoId.Location = new System.Drawing.Point(6, 40);
            this.lblTextoId.Name = "lblTextoId";
            this.lblTextoId.Size = new System.Drawing.Size(299, 16);
            this.lblTextoId.TabIndex = 2;
            this.lblTextoId.Text = "Ingrese el \"ID\" del proveedor que desea eliminar";
            // 
            // txtIdProveedorEliminar
            // 
            this.txtIdProveedorEliminar.Location = new System.Drawing.Point(320, 40);
            this.txtIdProveedorEliminar.Name = "txtIdProveedorEliminar";
            this.txtIdProveedorEliminar.Size = new System.Drawing.Size(147, 22);
            this.txtIdProveedorEliminar.TabIndex = 1;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(256, 239);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(136, 29);
            this.btnEliminarProveedor.TabIndex = 0;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // tbpAgregar
            // 
            this.tbpAgregar.Controls.Add(this.gbAgregarProveedor);
            this.tbpAgregar.Location = new System.Drawing.Point(4, 22);
            this.tbpAgregar.Name = "tbpAgregar";
            this.tbpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgregar.Size = new System.Drawing.Size(768, 420);
            this.tbpAgregar.TabIndex = 2;
            this.tbpAgregar.Text = "Agregar un proveedor";
            this.tbpAgregar.UseVisualStyleBackColor = true;
            // 
            // gbAgregarProveedor
            // 
            this.gbAgregarProveedor.Controls.Add(this.btnAgregarProveedor);
            this.gbAgregarProveedor.Controls.Add(this.txtCorreoProveedor);
            this.gbAgregarProveedor.Controls.Add(this.txtTelefonoProveedor);
            this.gbAgregarProveedor.Controls.Add(this.txtCedulaProveedor);
            this.gbAgregarProveedor.Controls.Add(this.txtDireccionProveedor);
            this.gbAgregarProveedor.Controls.Add(this.txtNombreProveedor);
            this.gbAgregarProveedor.Controls.Add(this.label6);
            this.gbAgregarProveedor.Controls.Add(this.label5);
            this.gbAgregarProveedor.Controls.Add(this.label4);
            this.gbAgregarProveedor.Controls.Add(this.label3);
            this.gbAgregarProveedor.Controls.Add(this.label2);
            this.gbAgregarProveedor.Location = new System.Drawing.Point(6, 6);
            this.gbAgregarProveedor.Name = "gbAgregarProveedor";
            this.gbAgregarProveedor.Size = new System.Drawing.Size(756, 408);
            this.gbAgregarProveedor.TabIndex = 10;
            this.gbAgregarProveedor.TabStop = false;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(400, 340);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(184, 37);
            this.btnAgregarProveedor.TabIndex = 20;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(155, 348);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(161, 20);
            this.txtCorreoProveedor.TabIndex = 19;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(155, 272);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(161, 20);
            this.txtTelefonoProveedor.TabIndex = 18;
            // 
            // txtCedulaProveedor
            // 
            this.txtCedulaProveedor.Location = new System.Drawing.Point(155, 189);
            this.txtCedulaProveedor.Name = "txtCedulaProveedor";
            this.txtCedulaProveedor.Size = new System.Drawing.Size(161, 20);
            this.txtCedulaProveedor.TabIndex = 17;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(155, 113);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(161, 20);
            this.txtDireccionProveedor.TabIndex = 16;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(155, 36);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(161, 20);
            this.txtNombreProveedor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre ";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.tbcProveedores);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.tbcProveedores.ResumeLayout(false);
            this.tbpProveedores.ResumeLayout(false);
            this.gbMostrarProveedores.ResumeLayout(false);
            this.gbMostrarProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.tbpEliminarProveedor.ResumeLayout(false);
            this.gbEliminarProveedor.ResumeLayout(false);
            this.gbEliminarProveedor.PerformLayout();
            this.tbpAgregar.ResumeLayout(false);
            this.gbAgregarProveedor.ResumeLayout(false);
            this.gbAgregarProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcProveedores;
        private System.Windows.Forms.TabPage tbpProveedores;
        private System.Windows.Forms.TabPage tbpEliminarProveedor;
        private System.Windows.Forms.TabPage tbpAgregar;
        private System.Windows.Forms.GroupBox gbMostrarProveedores;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.GroupBox gbEliminarProveedor;
        private System.Windows.Forms.Label lblTextoId;
        private System.Windows.Forms.TextBox txtIdProveedorEliminar;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.GroupBox gbAgregarProveedor;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtCedulaProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarProveedor;
    }
}
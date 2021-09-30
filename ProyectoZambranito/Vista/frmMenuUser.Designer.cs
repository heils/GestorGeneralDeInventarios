
namespace ProyectoZambranito.Vista
{
    partial class frmMenuUser
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.ptbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::ProyectoZambranito.Properties.Resources.boton;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventario.Location = new System.Drawing.Point(174, 31);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(155, 150);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::ProyectoZambranito.Properties.Resources.clientes2;
            this.btnCliente.Location = new System.Drawing.Point(174, 215);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(155, 150);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnCaja
            // 
            this.btnCaja.BackgroundImage = global::ProyectoZambranito.Properties.Resources.caja;
            this.btnCaja.Location = new System.Drawing.Point(174, 413);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(155, 154);
            this.btnCaja.TabIndex = 2;
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // ptbImagenUsuario
            // 
            this.ptbImagenUsuario.Image = global::ProyectoZambranito.Properties.Resources._90;
            this.ptbImagenUsuario.Location = new System.Drawing.Point(12, 31);
            this.ptbImagenUsuario.Name = "ptbImagenUsuario";
            this.ptbImagenUsuario.Size = new System.Drawing.Size(99, 111);
            this.ptbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenUsuario.TabIndex = 3;
            this.ptbImagenUsuario.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 215);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 271);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(12, 337);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 20);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(12, 425);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(10, 502);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::ProyectoZambranito.Properties.Resources.botonAyuda2;
            this.btnAyuda.Location = new System.Drawing.Point(494, 473);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(162, 29);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackgroundImage = global::ProyectoZambranito.Properties.Resources.acerca_de;
            this.btnAcercaDe.Location = new System.Drawing.Point(494, 523);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(162, 24);
            this.btnAcercaDe.TabIndex = 10;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = global::ProyectoZambranito.Properties.Resources.cerrarseseion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(494, 564);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 24);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoZambranito.Properties.Resources.Sin_título_4;
            this.ClientSize = new System.Drawing.Size(668, 617);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.ptbImagenUsuario);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuUser";
            this.Load += new System.EventHandler(this.frmMenuUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.PictureBox ptbImagenUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
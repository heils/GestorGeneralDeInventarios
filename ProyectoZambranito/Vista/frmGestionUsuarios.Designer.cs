
namespace ProyectoZambranito.Vista
{
    partial class btnRegresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnRegresar));
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btmCrearUsuario = new System.Windows.Forms.Button();
            this.txtIdUsuarioEliminar = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcGestorUsuarios = new System.Windows.Forms.TabControl();
            this.tbAgregar = new System.Windows.Forms.TabPage();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbcGestorUsuarios.SuspendLayout();
            this.tbAgregar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.tbEliminar.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(176, 189);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(186, 40);
            this.btnEliminarUsuario.TabIndex = 0;
            this.btnEliminarUsuario.Text = "Eliminar un Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btmCrearUsuario
            // 
            this.btmCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCrearUsuario.Location = new System.Drawing.Point(6, 345);
            this.btmCrearUsuario.Name = "btmCrearUsuario";
            this.btmCrearUsuario.Size = new System.Drawing.Size(188, 37);
            this.btmCrearUsuario.TabIndex = 1;
            this.btmCrearUsuario.Text = "Agregar un  usuario";
            this.btmCrearUsuario.UseVisualStyleBackColor = true;
            this.btmCrearUsuario.Click += new System.EventHandler(this.btmCrearUsuario_Click);
            // 
            // txtIdUsuarioEliminar
            // 
            this.txtIdUsuarioEliminar.Location = new System.Drawing.Point(233, 54);
            this.txtIdUsuarioEliminar.Name = "txtIdUsuarioEliminar";
            this.txtIdUsuarioEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuarioEliminar.TabIndex = 2;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(298, 197);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(298, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(298, 58);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(100, 20);
            this.txtNick.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID del usuario a eliminar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(207, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(174, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(142, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(217, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rol";
            // 
            // tbcGestorUsuarios
            // 
            this.tbcGestorUsuarios.Controls.Add(this.tbAgregar);
            this.tbcGestorUsuarios.Controls.Add(this.tbEliminar);
            this.tbcGestorUsuarios.Location = new System.Drawing.Point(12, 12);
            this.tbcGestorUsuarios.Name = "tbcGestorUsuarios";
            this.tbcGestorUsuarios.SelectedIndex = 0;
            this.tbcGestorUsuarios.Size = new System.Drawing.Size(460, 426);
            this.tbcGestorUsuarios.TabIndex = 13;
            // 
            // tbAgregar
            // 
            this.tbAgregar.Controls.Add(this.gbAgregar);
            this.tbAgregar.Location = new System.Drawing.Point(4, 22);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgregar.Size = new System.Drawing.Size(452, 400);
            this.tbAgregar.TabIndex = 0;
            this.tbAgregar.Text = "Agregar Usuario";
            this.tbAgregar.UseVisualStyleBackColor = true;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.cbxRol);
            this.gbAgregar.Controls.Add(this.btmCrearUsuario);
            this.gbAgregar.Controls.Add(this.txtNombre);
            this.gbAgregar.Controls.Add(this.label5);
            this.gbAgregar.Controls.Add(this.txtContrasenia);
            this.gbAgregar.Controls.Add(this.label4);
            this.gbAgregar.Controls.Add(this.txtNick);
            this.gbAgregar.Controls.Add(this.label3);
            this.gbAgregar.Controls.Add(this.label2);
            this.gbAgregar.Location = new System.Drawing.Point(6, 6);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(424, 388);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar Usuario";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cbxRol.Location = new System.Drawing.Point(277, 260);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 21);
            this.cbxRol.TabIndex = 12;
            // 
            // tbEliminar
            // 
            this.tbEliminar.Controls.Add(this.gbEliminar);
            this.tbEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(452, 400);
            this.tbEliminar.TabIndex = 1;
            this.tbEliminar.Text = "Eliminar Usuario";
            this.tbEliminar.UseVisualStyleBackColor = true;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.btnEliminarUsuario);
            this.gbEliminar.Controls.Add(this.txtIdUsuarioEliminar);
            this.gbEliminar.Controls.Add(this.label1);
            this.gbEliminar.Location = new System.Drawing.Point(6, 18);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(368, 235);
            this.gbEliminar.TabIndex = 0;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar usuario";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::ProyectoZambranito.Properties.Resources.REGRESAR_TAMAÑOREAL;
            this.button1.Location = new System.Drawing.Point(503, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.tbcGestorUsuarios);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnRegresar";
            this.Text = "Gestor de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.tbcGestorUsuarios.ResumeLayout(false);
            this.tbAgregar.ResumeLayout(false);
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.tbEliminar.ResumeLayout(false);
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btmCrearUsuario;
        private System.Windows.Forms.TextBox txtIdUsuarioEliminar;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tbcGestorUsuarios;
        private System.Windows.Forms.TabPage tbAgregar;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.GroupBox gbEliminar;
    }
}
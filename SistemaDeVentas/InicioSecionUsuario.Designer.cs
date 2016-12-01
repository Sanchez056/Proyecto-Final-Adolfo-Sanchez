namespace SistemaDeVentas
{
    partial class InicioSecionUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSecionUsuario));
            this.NombreUsuarioerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContraseñaerrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TiposUsuarioscomboBox1 = new System.Windows.Forms.ComboBox();
            this.TiposUsuarioslabel = new System.Windows.Forms.Label();
            this.Contraseñalabel2 = new System.Windows.Forms.Label();
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.NombreUsuariostextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IniciarSeccionbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreUsuarioerrorProvider1
            // 
            this.NombreUsuarioerrorProvider1.ContainerControl = this;
            // 
            // ContraseñaerrorProvider2
            // 
            this.ContraseñaerrorProvider2.ContainerControl = this;
            // 
            // TiposUsuarioscomboBox1
            // 
            this.TiposUsuarioscomboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TiposUsuarioscomboBox1.FormattingEnabled = true;
            this.TiposUsuarioscomboBox1.Location = new System.Drawing.Point(45, 167);
            this.TiposUsuarioscomboBox1.Name = "TiposUsuarioscomboBox1";
            this.TiposUsuarioscomboBox1.Size = new System.Drawing.Size(251, 23);
            this.TiposUsuarioscomboBox1.TabIndex = 8;
            // 
            // TiposUsuarioslabel
            // 
            this.TiposUsuarioslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TiposUsuarioslabel.AutoSize = true;
            this.TiposUsuarioslabel.ForeColor = System.Drawing.Color.White;
            this.TiposUsuarioslabel.Location = new System.Drawing.Point(45, 149);
            this.TiposUsuarioslabel.Name = "TiposUsuarioslabel";
            this.TiposUsuarioslabel.Size = new System.Drawing.Size(82, 15);
            this.TiposUsuarioslabel.TabIndex = 9;
            this.TiposUsuarioslabel.Text = "TiposUsuarios:";
            // 
            // Contraseñalabel2
            // 
            this.Contraseñalabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Contraseñalabel2.AutoSize = true;
            this.Contraseñalabel2.ForeColor = System.Drawing.Color.White;
            this.Contraseñalabel2.Location = new System.Drawing.Point(45, 96);
            this.Contraseñalabel2.Name = "Contraseñalabel2";
            this.Contraseñalabel2.Size = new System.Drawing.Size(72, 15);
            this.Contraseñalabel2.TabIndex = 10;
            this.Contraseñalabel2.Text = "Contraseñas:";
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.ForeColor = System.Drawing.Color.White;
            this.NombreUsuariolabel.Location = new System.Drawing.Point(45, 45);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(110, 15);
            this.NombreUsuariolabel.TabIndex = 11;
            this.NombreUsuariolabel.Text = "Nombre  de Usuario:";
            // 
            // NombreUsuariostextBox1
            // 
            this.NombreUsuariostextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NombreUsuariostextBox1.Location = new System.Drawing.Point(45, 63);
            this.NombreUsuariostextBox1.Name = "NombreUsuariostextBox1";
            this.NombreUsuariostextBox1.Size = new System.Drawing.Size(251, 21);
            this.NombreUsuariostextBox1.TabIndex = 12;
            // 
            // ContraseñatextBox2
            // 
            this.ContraseñatextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContraseñatextBox2.Location = new System.Drawing.Point(45, 114);
            this.ContraseñatextBox2.Name = "ContraseñatextBox2";
            this.ContraseñatextBox2.PasswordChar = '*';
            this.ContraseñatextBox2.Size = new System.Drawing.Size(251, 21);
            this.ContraseñatextBox2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ContraseñatextBox2);
            this.panel1.Controls.Add(this.NombreUsuariostextBox1);
            this.panel1.Controls.Add(this.NombreUsuariolabel);
            this.panel1.Controls.Add(this.Contraseñalabel2);
            this.panel1.Controls.Add(this.TiposUsuarioslabel);
            this.panel1.Controls.Add(this.TiposUsuarioscomboBox1);
            this.panel1.Controls.Add(this.IniciarSeccionbutton1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 292);
            this.panel1.TabIndex = 0;
            // 
            // IniciarSeccionbutton1
            // 
            this.IniciarSeccionbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IniciarSeccionbutton1.BackColor = System.Drawing.Color.AliceBlue;
            this.IniciarSeccionbutton1.Image = global::SistemaDeVentas.Properties.Resources.access;
            this.IniciarSeccionbutton1.Location = new System.Drawing.Point(89, 209);
            this.IniciarSeccionbutton1.Name = "IniciarSeccionbutton1";
            this.IniciarSeccionbutton1.Size = new System.Drawing.Size(150, 42);
            this.IniciarSeccionbutton1.TabIndex = 7;
            this.IniciarSeccionbutton1.Text = "Iniciar Sesion";
            this.IniciarSeccionbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IniciarSeccionbutton1.UseVisualStyleBackColor = false;
            this.IniciarSeccionbutton1.Click += new System.EventHandler(this.IniciarSeccionbutton1_Click_1);
            // 
            // InicioSecionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 319);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "InicioSecionUsuario";
            this.Text = "Seccion de Usuario";
            this.Load += new System.EventHandler(this.InicioSecionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider NombreUsuarioerrorProvider1;
        private System.Windows.Forms.ErrorProvider ContraseñaerrorProvider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ContraseñatextBox2;
        private System.Windows.Forms.TextBox NombreUsuariostextBox1;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.Label Contraseñalabel2;
        private System.Windows.Forms.Label TiposUsuarioslabel;
        private System.Windows.Forms.ComboBox TiposUsuarioscomboBox1;
        private System.Windows.Forms.Button IniciarSeccionbutton1;
    }
}
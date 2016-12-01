namespace SistemaDeVentas
{
    partial class RegistroDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeUsuarios));
            this.IdLabel = new System.Windows.Forms.Label();
            this.UsuarioIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariostextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariosLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.ConfimarContraseñatextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.ComfimarContraseñalabel2 = new System.Windows.Forms.Label();
            this.TipoUsuarioscomboBox = new System.Windows.Forms.ComboBox();
            this.TipoUsuarioslabel = new System.Windows.Forms.Label();
            this.BuscarerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreUsuarioserrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContraseñaerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfimarContraseñaerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.RegistrosUsuarioslabel = new System.Windows.Forms.Label();
            this.ElegirTipoUsuarioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Editarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioserrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfimarContraseñaerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElegirTipoUsuarioserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            resources.ApplyResources(this.IdLabel, "IdLabel");
            this.IdLabel.Name = "IdLabel";
            // 
            // UsuarioIdtextBox
            // 
            resources.ApplyResources(this.UsuarioIdtextBox, "UsuarioIdtextBox");
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            // 
            // NombreUsuariostextBox
            // 
            resources.ApplyResources(this.NombreUsuariostextBox, "NombreUsuariostextBox");
            this.NombreUsuariostextBox.Name = "NombreUsuariostextBox";
            // 
            // NombreUsuariosLabel
            // 
            resources.ApplyResources(this.NombreUsuariosLabel, "NombreUsuariosLabel");
            this.NombreUsuariosLabel.Name = "NombreUsuariosLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ContraseñatextBox
            // 
            resources.ApplyResources(this.ContraseñatextBox, "ContraseñatextBox");
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            // 
            // ConfimarContraseñatextBox1
            // 
            resources.ApplyResources(this.ConfimarContraseñatextBox1, "ConfimarContraseñatextBox1");
            this.ConfimarContraseñatextBox1.Name = "ConfimarContraseñatextBox1";
            // 
            // ContraseñaLabel
            // 
            resources.ApplyResources(this.ContraseñaLabel, "ContraseñaLabel");
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            // 
            // ComfimarContraseñalabel2
            // 
            resources.ApplyResources(this.ComfimarContraseñalabel2, "ComfimarContraseñalabel2");
            this.ComfimarContraseñalabel2.Name = "ComfimarContraseñalabel2";
            // 
            // TipoUsuarioscomboBox
            // 
            this.TipoUsuarioscomboBox.BackColor = System.Drawing.Color.DimGray;
            this.TipoUsuarioscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoUsuarioscomboBox.FormattingEnabled = true;
            resources.ApplyResources(this.TipoUsuarioscomboBox, "TipoUsuarioscomboBox");
            this.TipoUsuarioscomboBox.Name = "TipoUsuarioscomboBox";
            this.TipoUsuarioscomboBox.SelectedIndexChanged += new System.EventHandler(this.TipoUsuarioscomboBox_SelectedIndexChanged);
            // 
            // TipoUsuarioslabel
            // 
            resources.ApplyResources(this.TipoUsuarioslabel, "TipoUsuarioslabel");
            this.TipoUsuarioslabel.Name = "TipoUsuarioslabel";
            // 
            // BuscarerrorProvider1
            // 
            this.BuscarerrorProvider1.ContainerControl = this;
            // 
            // NombreUsuarioserrorProvider1
            // 
            this.NombreUsuarioserrorProvider1.ContainerControl = this;
            // 
            // ContraseñaerrorProvider1
            // 
            this.ContraseñaerrorProvider1.ContainerControl = this;
            // 
            // ConfimarContraseñaerrorProvider1
            // 
            this.ConfimarContraseñaerrorProvider1.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.ForeColor = System.Drawing.Color.Black;
            this.Eliminarbutton.Image = global::SistemaDeVentas.Properties.Resources.delete_user;
            resources.ApplyResources(this.Eliminarbutton, "Eliminarbutton");
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.ForeColor = System.Drawing.Color.Black;
            this.Guardarbutton.Image = global::SistemaDeVentas.Properties.Resources.save;
            resources.ApplyResources(this.Guardarbutton, "Guardarbutton");
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ForeColor = System.Drawing.Color.Black;
            this.Nuevobutton.Image = global::SistemaDeVentas.Properties.Resources.add_user;
            resources.ApplyResources(this.Nuevobutton, "Nuevobutton");
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::SistemaDeVentas.Properties.Resources.search;
            resources.ApplyResources(this.Buscarbutton, "Buscarbutton");
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistrosUsuarioslabel
            // 
            resources.ApplyResources(this.RegistrosUsuarioslabel, "RegistrosUsuarioslabel");
            this.RegistrosUsuarioslabel.Name = "RegistrosUsuarioslabel";
            // 
            // ElegirTipoUsuarioserrorProvider
            // 
            this.ElegirTipoUsuarioserrorProvider.ContainerControl = this;
            // 
            // Editarbutton
            // 
            this.Editarbutton.ForeColor = System.Drawing.Color.Black;
            this.Editarbutton.Image = global::SistemaDeVentas.Properties.Resources.ark;
            resources.ApplyResources(this.Editarbutton, "Editarbutton");
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // RegistroDeUsuarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.RegistrosUsuarioslabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TipoUsuarioslabel);
            this.Controls.Add(this.TipoUsuarioscomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ComfimarContraseñalabel2);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.ConfimarContraseñatextBox1);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombreUsuariosLabel);
            this.Controls.Add(this.NombreUsuariostextBox);
            this.Controls.Add(this.UsuarioIdtextBox);
            this.Controls.Add(this.IdLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistroDeUsuarios";
            this.Load += new System.EventHandler(this.RegistroDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioserrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfimarContraseñaerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElegirTipoUsuarioserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox UsuarioIdtextBox;
        private System.Windows.Forms.TextBox NombreUsuariostextBox;
        private System.Windows.Forms.Label NombreUsuariosLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.TextBox ConfimarContraseñatextBox1;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.Label ComfimarContraseñalabel2;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox TipoUsuarioscomboBox;
        private System.Windows.Forms.Label TipoUsuarioslabel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider1;
        private System.Windows.Forms.ErrorProvider NombreUsuarioserrorProvider1;
        private System.Windows.Forms.ErrorProvider ContraseñaerrorProvider1;
        private System.Windows.Forms.ErrorProvider ConfimarContraseñaerrorProvider1;
        private System.Windows.Forms.Label RegistrosUsuarioslabel;
        private System.Windows.Forms.ErrorProvider ElegirTipoUsuarioserrorProvider;
        private System.Windows.Forms.Button Editarbutton;
    }
}
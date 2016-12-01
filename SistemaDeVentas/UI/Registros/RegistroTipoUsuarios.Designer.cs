namespace SistemaDeVentas.UI.Registros
{
    partial class RegistroTipoUsuarios
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
            this.button1 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ArtculosgroupBox = new System.Windows.Forms.GroupBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Detallelabel = new System.Windows.Forms.Label();
            this.DetalletextBox = new System.Windows.Forms.TextBox();
            this.TipoIdtextBox = new System.Windows.Forms.TextBox();
            this.TipoIdlabel = new System.Windows.Forms.Label();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalleerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Editarbutton = new System.Windows.Forms.Button();
            this.ArtculosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::SistemaDeVentas.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(293, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.ForeColor = System.Drawing.Color.Black;
            this.Guardarbutton.Image = global::SistemaDeVentas.Properties.Resources.save1;
            this.Guardarbutton.Location = new System.Drawing.Point(105, 189);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(93, 39);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ForeColor = System.Drawing.Color.Black;
            this.Nuevobutton.Image = global::SistemaDeVentas.Properties.Resources.new1;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 189);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(87, 39);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ArtculosgroupBox
            // 
            this.ArtculosgroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ArtculosgroupBox.Controls.Add(this.Buscarbutton);
            this.ArtculosgroupBox.Controls.Add(this.Detallelabel);
            this.ArtculosgroupBox.Controls.Add(this.DetalletextBox);
            this.ArtculosgroupBox.Controls.Add(this.TipoIdtextBox);
            this.ArtculosgroupBox.Controls.Add(this.TipoIdlabel);
            this.ArtculosgroupBox.ForeColor = System.Drawing.Color.White;
            this.ArtculosgroupBox.Location = new System.Drawing.Point(27, 12);
            this.ArtculosgroupBox.Name = "ArtculosgroupBox";
            this.ArtculosgroupBox.Size = new System.Drawing.Size(326, 157);
            this.ArtculosgroupBox.TabIndex = 4;
            this.ArtculosgroupBox.TabStop = false;
            this.ArtculosgroupBox.Text = "Tipo Usuarios";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::SistemaDeVentas.Properties.Resources.search2;
            this.Buscarbutton.Location = new System.Drawing.Point(143, 32);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 39);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Detallelabel
            // 
            this.Detallelabel.AutoSize = true;
            this.Detallelabel.Location = new System.Drawing.Point(22, 79);
            this.Detallelabel.Name = "Detallelabel";
            this.Detallelabel.Size = new System.Drawing.Size(43, 13);
            this.Detallelabel.TabIndex = 4;
            this.Detallelabel.Text = "Detalle:";
            // 
            // DetalletextBox
            // 
            this.DetalletextBox.Location = new System.Drawing.Point(25, 96);
            this.DetalletextBox.Name = "DetalletextBox";
            this.DetalletextBox.Size = new System.Drawing.Size(144, 20);
            this.DetalletextBox.TabIndex = 1;
            // 
            // TipoIdtextBox
            // 
            this.TipoIdtextBox.Location = new System.Drawing.Point(25, 51);
            this.TipoIdtextBox.Name = "TipoIdtextBox";
            this.TipoIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.TipoIdtextBox.TabIndex = 2;
            // 
            // TipoIdlabel
            // 
            this.TipoIdlabel.AutoSize = true;
            this.TipoIdlabel.Location = new System.Drawing.Point(22, 32);
            this.TipoIdlabel.Name = "TipoIdlabel";
            this.TipoIdlabel.Size = new System.Drawing.Size(40, 13);
            this.TipoIdlabel.TabIndex = 1;
            this.TipoIdlabel.Text = "TipoId:";
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // DetalleerrorProvider
            // 
            this.DetalleerrorProvider.ContainerControl = this;
            // 
            // Editarbutton
            // 
            this.Editarbutton.ForeColor = System.Drawing.Color.Black;
            this.Editarbutton.Image = global::SistemaDeVentas.Properties.Resources.ark;
            this.Editarbutton.Location = new System.Drawing.Point(204, 189);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(83, 39);
            this.Editarbutton.TabIndex = 113;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // RegistroTipoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 252);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ArtculosgroupBox);
            this.Name = "RegistroTipoUsuarios";
            this.Text = "RegistroTipoUsuarios";
            this.ArtculosgroupBox.ResumeLayout(false);
            this.ArtculosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox ArtculosgroupBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label Detallelabel;
        private System.Windows.Forms.TextBox DetalletextBox;
        private System.Windows.Forms.TextBox TipoIdtextBox;
        private System.Windows.Forms.Label TipoIdlabel;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider DetalleerrorProvider;
        private System.Windows.Forms.Button Editarbutton;
    }
}
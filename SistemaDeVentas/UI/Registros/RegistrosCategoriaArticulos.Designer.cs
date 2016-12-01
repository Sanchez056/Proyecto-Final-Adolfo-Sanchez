namespace SistemaDeVentas.UI.Registros
{
    partial class RegistrosCategoriaArticulos
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
            this.ArtculosgroupBox = new System.Windows.Forms.GroupBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.CategoriaIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DescripcionerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Editarbutton = new System.Windows.Forms.Button();
            this.ArtculosgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ArtculosgroupBox
            // 
            this.ArtculosgroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ArtculosgroupBox.Controls.Add(this.Buscarbutton);
            this.ArtculosgroupBox.Controls.Add(this.label2);
            this.ArtculosgroupBox.Controls.Add(this.DescripciontextBox);
            this.ArtculosgroupBox.Controls.Add(this.CategoriaIdtextBox);
            this.ArtculosgroupBox.Controls.Add(this.label1);
            this.ArtculosgroupBox.ForeColor = System.Drawing.Color.White;
            this.ArtculosgroupBox.Location = new System.Drawing.Point(36, 12);
            this.ArtculosgroupBox.Name = "ArtculosgroupBox";
            this.ArtculosgroupBox.Size = new System.Drawing.Size(326, 157);
            this.ArtculosgroupBox.TabIndex = 0;
            this.ArtculosgroupBox.TabStop = false;
            this.ArtculosgroupBox.Text = "Categorias";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion:";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(25, 96);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(144, 20);
            this.DescripciontextBox.TabIndex = 1;
            // 
            // CategoriaIdtextBox
            // 
            this.CategoriaIdtextBox.Location = new System.Drawing.Point(25, 51);
            this.CategoriaIdtextBox.Name = "CategoriaIdtextBox";
            this.CategoriaIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoriaIdtextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "CategoriaId:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ForeColor = System.Drawing.Color.Black;
            this.Nuevobutton.Image = global::SistemaDeVentas.Properties.Resources.new1;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 189);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(87, 41);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.ForeColor = System.Drawing.Color.Black;
            this.Guardarbutton.Image = global::SistemaDeVentas.Properties.Resources.save1;
            this.Guardarbutton.Location = new System.Drawing.Point(105, 189);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(85, 41);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::SistemaDeVentas.Properties.Resources.cancel2;
            this.button1.Location = new System.Drawing.Point(293, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DescripcionerrorProvider
            // 
            this.DescripcionerrorProvider.ContainerControl = this;
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // Editarbutton
            // 
            this.Editarbutton.ForeColor = System.Drawing.Color.Black;
            this.Editarbutton.Image = global::SistemaDeVentas.Properties.Resources.ark;
            this.Editarbutton.Location = new System.Drawing.Point(196, 190);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(91, 40);
            this.Editarbutton.TabIndex = 111;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // RegistrosCategoriaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 242);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ArtculosgroupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegistrosCategoriaArticulos";
            this.Text = "RegistroDeCategoriaArticulos";
            this.Load += new System.EventHandler(this.RegistrosCategoriaArticulos_Load);
            this.ArtculosgroupBox.ResumeLayout(false);
            this.ArtculosgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ArtculosgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox CategoriaIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider DescripcionerrorProvider;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.Button Editarbutton;
    }
}
namespace SistemaDeVentas.Registros
{
    partial class RegistrosDeEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosDeEmpleado));
            this.SexogroupBox = new System.Windows.Forms.GroupBox();
            this.FemeninocheckBox = new System.Windows.Forms.CheckBox();
            this.MasculinocheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.REmpleadoLabel = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CelularmaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EmpleadoIdtextBox = new System.Windows.Forms.TextBox();
            this.Celularlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Direccionlabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.EmpleadoIdlabel = new System.Windows.Forms.Label();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.FechaNacimientolabel = new System.Windows.Forms.Label();
            this.FechaNacimientomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CedulaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaNacimientoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SexoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CiudaderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DireccionerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TelefonoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Editarbutton = new System.Windows.Forms.Button();
            this.SexogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CedulaerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudaderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SexogroupBox
            // 
            this.SexogroupBox.BackColor = System.Drawing.Color.DarkBlue;
            this.SexogroupBox.Controls.Add(this.FemeninocheckBox);
            this.SexogroupBox.Controls.Add(this.MasculinocheckBox);
            this.SexogroupBox.ForeColor = System.Drawing.Color.White;
            this.SexogroupBox.Location = new System.Drawing.Point(21, 342);
            this.SexogroupBox.Name = "SexogroupBox";
            this.SexogroupBox.Size = new System.Drawing.Size(217, 66);
            this.SexogroupBox.TabIndex = 50;
            this.SexogroupBox.TabStop = false;
            this.SexogroupBox.Text = "Sexo";
            // 
            // FemeninocheckBox
            // 
            this.FemeninocheckBox.AutoSize = true;
            this.FemeninocheckBox.Location = new System.Drawing.Point(119, 33);
            this.FemeninocheckBox.Name = "FemeninocheckBox";
            this.FemeninocheckBox.Size = new System.Drawing.Size(73, 19);
            this.FemeninocheckBox.TabIndex = 21;
            this.FemeninocheckBox.Text = "Femenino";
            this.FemeninocheckBox.UseVisualStyleBackColor = true;
            // 
            // MasculinocheckBox
            // 
            this.MasculinocheckBox.AutoSize = true;
            this.MasculinocheckBox.Location = new System.Drawing.Point(19, 33);
            this.MasculinocheckBox.Name = "MasculinocheckBox";
            this.MasculinocheckBox.Size = new System.Drawing.Size(77, 19);
            this.MasculinocheckBox.TabIndex = 20;
            this.MasculinocheckBox.Text = "Masculino";
            this.MasculinocheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Ciudad:";
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Items.AddRange(new object[] {
            "Espaillat",
            "Puerto Plata",
            "Santiago",
            "La Vega",
            "Monseñor Nouel",
            "Sánchez Ramírez",
            "Duarte",
            "Hermanas Mirabal",
            "María Trinidad Sánchez",
            "Samaná",
            "Dajabón",
            "Monte Cristi",
            "Santiago Rodríguez",
            "Valverde",
            "Azua",
            "Peravia",
            "San José de Ocoa",
            "San Cristóbal",
            "Elías Piña",
            "San Juan",
            "Enriquillo\t",
            "Barahona",
            "Bahoruco",
            "Independencia",
            "Pedernales",
            "El Seibo",
            "La Romana",
            "La Altagracia",
            "Hato Mayor",
            "Monte Plata",
            "San Pedro de Macorís",
            "Distrito Nacional",
            "Santo Domingo "});
            this.CiudadcomboBox.Location = new System.Drawing.Point(284, 171);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(216, 23);
            this.CiudadcomboBox.TabIndex = 48;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(23, 227);
            this.CedulamaskedTextBox.Mask = "999-9999999-9";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(216, 21);
            this.CedulamaskedTextBox.TabIndex = 47;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(373, 99);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(107, 21);
            this.FechadateTimePicker.TabIndex = 33;
            this.FechadateTimePicker.ValueChanged += new System.EventHandler(this.FechadateTimePicker_ValueChanged);
            // 
            // REmpleadoLabel
            // 
            this.REmpleadoLabel.AutoSize = true;
            this.REmpleadoLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REmpleadoLabel.Location = new System.Drawing.Point(82, 25);
            this.REmpleadoLabel.Name = "REmpleadoLabel";
            this.REmpleadoLabel.Size = new System.Drawing.Size(290, 31);
            this.REmpleadoLabel.TabIndex = 46;
            this.REmpleadoLabel.Text = "Registros De Empleados";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.ForeColor = System.Drawing.Color.Black;
            this.Eliminarbutton.Image = global::SistemaDeVentas.Properties.Resources.file_broken_32x32_32;
            this.Eliminarbutton.Location = new System.Drawing.Point(346, 426);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(100, 48);
            this.Eliminarbutton.TabIndex = 45;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.ForeColor = System.Drawing.Color.Black;
            this.Guardarbutton.Image = global::SistemaDeVentas.Properties.Resources.save1;
            this.Guardarbutton.Location = new System.Drawing.Point(121, 426);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(104, 48);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ForeColor = System.Drawing.Color.Black;
            this.Nuevobutton.Image = global::SistemaDeVentas.Properties.Resources._new;
            this.Nuevobutton.Location = new System.Drawing.Point(22, 426);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(93, 48);
            this.Nuevobutton.TabIndex = 43;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::SistemaDeVentas.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(162, 97);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(101, 48);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CelularmaskedTextBox2
            // 
            this.CelularmaskedTextBox2.Location = new System.Drawing.Point(284, 346);
            this.CelularmaskedTextBox2.Mask = "000-000-0000";
            this.CelularmaskedTextBox2.Name = "CelularmaskedTextBox2";
            this.CelularmaskedTextBox2.Size = new System.Drawing.Size(216, 21);
            this.CelularmaskedTextBox2.TabIndex = 41;
            // 
            // TelefonomaskedTextBox1
            // 
            this.TelefonomaskedTextBox1.Location = new System.Drawing.Point(284, 283);
            this.TelefonomaskedTextBox1.Mask = "000-000-0000";
            this.TelefonomaskedTextBox1.Name = "TelefonomaskedTextBox1";
            this.TelefonomaskedTextBox1.Size = new System.Drawing.Size(216, 21);
            this.TelefonomaskedTextBox1.TabIndex = 40;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(284, 227);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(216, 21);
            this.DirecciontextBox.TabIndex = 39;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(22, 174);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(216, 21);
            this.NombretextBox.TabIndex = 37;
            // 
            // EmpleadoIdtextBox
            // 
            this.EmpleadoIdtextBox.Location = new System.Drawing.Point(22, 117);
            this.EmpleadoIdtextBox.Name = "EmpleadoIdtextBox";
            this.EmpleadoIdtextBox.Size = new System.Drawing.Size(121, 21);
            this.EmpleadoIdtextBox.TabIndex = 36;
            // 
            // Celularlabel
            // 
            this.Celularlabel.AutoSize = true;
            this.Celularlabel.Location = new System.Drawing.Point(281, 325);
            this.Celularlabel.Name = "Celularlabel";
            this.Celularlabel.Size = new System.Drawing.Size(44, 15);
            this.Celularlabel.TabIndex = 35;
            this.Celularlabel.Text = "Celular:";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(370, 80);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(76, 15);
            this.Fechalabel.TabIndex = 34;
            this.Fechalabel.Text = "Fecha Ingreso:";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(281, 263);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(52, 15);
            this.Telefonolabel.TabIndex = 32;
            this.Telefonolabel.Text = "Telefono:";
            // 
            // Direccionlabel
            // 
            this.Direccionlabel.AutoSize = true;
            this.Direccionlabel.Location = new System.Drawing.Point(281, 206);
            this.Direccionlabel.Name = "Direccionlabel";
            this.Direccionlabel.Size = new System.Drawing.Size(56, 15);
            this.Direccionlabel.TabIndex = 31;
            this.Direccionlabel.Text = "Direccion:";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(19, 153);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(49, 15);
            this.Nombrelabel.TabIndex = 29;
            this.Nombrelabel.Text = "Nombre:";
            // 
            // EmpleadoIdlabel
            // 
            this.EmpleadoIdlabel.AutoSize = true;
            this.EmpleadoIdlabel.Location = new System.Drawing.Point(19, 97);
            this.EmpleadoIdlabel.Name = "EmpleadoIdlabel";
            this.EmpleadoIdlabel.Size = new System.Drawing.Size(71, 15);
            this.EmpleadoIdlabel.TabIndex = 28;
            this.EmpleadoIdlabel.Text = "Empleado Id:";
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Location = new System.Drawing.Point(19, 209);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(43, 15);
            this.Cedulalabel.TabIndex = 51;
            this.Cedulalabel.Text = "Cedula:";
            // 
            // FechaNacimientolabel
            // 
            this.FechaNacimientolabel.AutoSize = true;
            this.FechaNacimientolabel.Location = new System.Drawing.Point(18, 281);
            this.FechaNacimientolabel.Name = "FechaNacimientolabel";
            this.FechaNacimientolabel.Size = new System.Drawing.Size(93, 15);
            this.FechaNacimientolabel.TabIndex = 52;
            this.FechaNacimientolabel.Text = "FechaNacimiento:";
            // 
            // FechaNacimientomaskedTextBox
            // 
            this.FechaNacimientomaskedTextBox.Location = new System.Drawing.Point(23, 301);
            this.FechaNacimientomaskedTextBox.Mask = "00/00/0000";
            this.FechaNacimientomaskedTextBox.Name = "FechaNacimientomaskedTextBox";
            this.FechaNacimientomaskedTextBox.Size = new System.Drawing.Size(212, 21);
            this.FechaNacimientomaskedTextBox.TabIndex = 53;
            this.FechaNacimientomaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // CedulaerrorProvider
            // 
            this.CedulaerrorProvider.ContainerControl = this;
            // 
            // FechaNacimientoerrorProvider
            // 
            this.FechaNacimientoerrorProvider.ContainerControl = this;
            // 
            // SexoerrorProvider
            // 
            this.SexoerrorProvider.ContainerControl = this;
            // 
            // CiudaderrorProvider
            // 
            this.CiudaderrorProvider.ContainerControl = this;
            // 
            // DireccionerrorProvider
            // 
            this.DireccionerrorProvider.ContainerControl = this;
            // 
            // TelefonoerrorProvider
            // 
            this.TelefonoerrorProvider.ContainerControl = this;
            // 
            // Editarbutton
            // 
            this.Editarbutton.ForeColor = System.Drawing.Color.Black;
            this.Editarbutton.Image = global::SistemaDeVentas.Properties.Resources.ark;
            this.Editarbutton.Location = new System.Drawing.Point(231, 428);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(106, 46);
            this.Editarbutton.TabIndex = 112;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // RegistrosDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(525, 498);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.FechaNacimientomaskedTextBox);
            this.Controls.Add(this.FechaNacimientolabel);
            this.Controls.Add(this.Cedulalabel);
            this.Controls.Add(this.SexogroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CiudadcomboBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.REmpleadoLabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CelularmaskedTextBox2);
            this.Controls.Add(this.TelefonomaskedTextBox1);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.EmpleadoIdtextBox);
            this.Controls.Add(this.Celularlabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Telefonolabel);
            this.Controls.Add(this.Direccionlabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.EmpleadoIdlabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrosDeEmpleado";
            this.Text = "Registro De Empleado";
            this.SexogroupBox.ResumeLayout(false);
            this.SexogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CedulaerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaNacimientoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudaderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SexogroupBox;
        private System.Windows.Forms.CheckBox FemeninocheckBox;
        private System.Windows.Forms.CheckBox MasculinocheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        public System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label REmpleadoLabel;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.MaskedTextBox CelularmaskedTextBox2;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox1;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox EmpleadoIdtextBox;
        private System.Windows.Forms.Label Celularlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Direccionlabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label EmpleadoIdlabel;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label FechaNacimientolabel;
        private System.Windows.Forms.MaskedTextBox FechaNacimientomaskedTextBox;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider CedulaerrorProvider;
        private System.Windows.Forms.ErrorProvider FechaNacimientoerrorProvider;
        private System.Windows.Forms.ErrorProvider SexoerrorProvider;
        private System.Windows.Forms.ErrorProvider CiudaderrorProvider;
        private System.Windows.Forms.ErrorProvider DireccionerrorProvider;
        private System.Windows.Forms.ErrorProvider TelefonoerrorProvider;
        private System.Windows.Forms.Button Editarbutton;
    }
}
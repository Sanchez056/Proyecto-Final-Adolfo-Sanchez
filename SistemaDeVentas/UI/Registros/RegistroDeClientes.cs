using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;


namespace SistemaDeVentas
{
    public partial class RegistroDeClientes : Form
    {
        UtilidadesInt ut = new UtilidadesInt();
        Clientes cliente = new Clientes();
        public List<Clientes> lista = new List<Clientes>();
        public RegistroDeClientes()
        {
            InitializeComponent();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Cliente que desea buscar") && ValidarBuscar())
                LLenar(ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)));
        }

        private void LLenar(Clientes cliente)
        {
            
            ClienteIdtextBox.Text = cliente.ClienteId.ToString();
            NombretextBox.Text = cliente.Nombre;
            CiudadcomboBox.Text = cliente.Ciudad;
            DirecciontextBox.Text = cliente.Direccion;
            CedulamaskedTextBox.Text = cliente.Cedula;
            TelefonomaskedTextBox1.Text = cliente.Telefono;
            CelularmaskedTextBox2.Text = cliente.Celular;
            if (cliente.Sexo == "M")
                MasculinocheckBox.Checked = true;
            if (cliente.Sexo == "F")
                FemeninocheckBox.Checked = true;

        }
     
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        //----------
       

        private bool ValidarExiste(string aux)
        {
            if (ClientesBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este cedula de cliente ya existe, favor intentar con otra Cedula o modificar...");
                return false;
            }
            return true;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            CiudadcomboBox.Text = "Elegir Su Ciudad";
            TelefonomaskedTextBox1.Clear();
            CelularmaskedTextBox2.Clear();
            MasculinocheckBox.Checked = false;
            FemeninocheckBox.Checked = false;
            FechadateTimePicker.Value = f.Value;
            //-----
            limpiarErroresProvider();

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            BuscarerrorProvider1.Clear();
            LlenarClase(cliente);
            if (ValidarTextbox() && ValidarExiste(CedulamaskedTextBox.Text))
            {
                
                    ClientesBLL.Insertar(cliente);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("-_-Guardado Con Exito-_-");      

            }
                  
                
            }
        


        
        private void LlenarClase(Clientes c)
        {
           
            c.Nombre = NombretextBox.Text;
            c.Cedula = CedulamaskedTextBox.Text;
            c.Ciudad  = CiudadcomboBox.Text;
            c.Direccion = DirecciontextBox.Text;
            c.Telefono = TelefonomaskedTextBox1.Text;
            c.Celular = CelularmaskedTextBox2.Text;
            if (MasculinocheckBox.Checked == true)
            {
                c.Sexo = "M";
            }
            else
            {
                if (FemeninocheckBox.Checked == true)

                    c.Sexo = "F";
                else

                    c.Sexo = "M";
            }

            c.Fecha = FechadateTimePicker.Value;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(CedulamaskedTextBox.Text) &&
                string.IsNullOrEmpty(CiudadcomboBox.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox1.Text) &&
                string.IsNullOrEmpty(CelularmaskedTextBox2.Text)

                )
            {
                 NombreerrorProvider2.SetError(NombretextBox, "Favor Ingresar el Nombre de cliente");
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresar la Cedula Cliente");
                 CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor Ingresar la Ciudad actual de donde recide el cliente");
                 DirrecionerrorProvider8.SetError(DirecciontextBox,"Favor Ingresar la Dirrecion de la ciudad de donde esta el Cliente");
                 TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor Ingresar el Numero de Telefono Recidencia del Cliente");
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresarel Numero de Celular de Cliente");
                 
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider2.Clear();
                NombreerrorProvider2.SetError(NombretextBox, "Favor ingresar el Nombre del Cliente");
                return false;
            }
           

            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text))
            {
                 CedulaerrorProvider4.Clear();
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor ingresar el Numero de Cedula de Identidad");
                return false;
            }
            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
                CiudaderrorProvider7.Clear();
                CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor ingrese la Ciudad que Actual de Cliente");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                DirecciontextBox.Clear();
                DirrecionerrorProvider8.SetError(DirecciontextBox, "Favor ingrese la dirrecion de la ciudad de donde vive cliente");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonomaskedTextBox1.Text))
            {
                TelefonoerrorProvider9.Clear();
                TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor ingrese el numero telefono de su Recidencia");
                return false;
            }
            if (string.IsNullOrEmpty(CelularmaskedTextBox2.Text))
            {
                CelularerrorProvider10.Clear();
                CelularerrorProvider10.SetError(CelularmaskedTextBox2, "Favor ingrese el Numero de Celular");
                return false;
            }

            if (MasculinocheckBox.Checked == false && FemeninocheckBox.Checked == false)
            {
                SexoerrorProvider1.SetError(SexogroupBox, "Seleccionar sexo");
                return false;
            }




            return true;
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Cliente que desea eliminar") && ValidarBuscar())
            {
                ClientesBLL.Eliminar(ut.StringInt(ClienteIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }

        ///---------------
        private void limpiarErroresProvider()
        {
            BuscarerrorProvider1.Clear();
            NombreerrorProvider2.Clear();
            CedulamaskedTextBox.Clear();
            SexoerrorProvider1.Clear();
            CiudaderrorProvider7.Clear();
            DirrecionerrorProvider8.Clear();
            TelefonoerrorProvider9.Clear();
            CelularerrorProvider10.Clear();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroDeClientes_Load(object sender, EventArgs e)
        {

        }

        private void Sexolabel_Click(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(cliente);
                if (ValidarExiste(CedulamaskedTextBox.Text))
                {
                    ClientesBLL.Modificar(ut.StringInt(ClienteIdtextBox.Text), cliente);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }

        ///-------------
    }
}

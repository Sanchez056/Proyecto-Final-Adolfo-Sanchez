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
namespace SistemaDeVentas.Registros
{
    public partial class RegistroDeProveedores : Form
    {
        Proveedores proveedor = new Proveedores();
        public RegistroDeProveedores()
        {
            InitializeComponent();
        }

        UtilidadesInt ut = new UtilidadesInt();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Proveedor que desea buscar") && ValidarBuscar())
                LLenar(ProveedorBLL.Buscar(ut.StringInt(ProveedorIdtextBox.Text)));
        }
        private void LLenar(Proveedores proveedor)
        {
            ProveedorIdtextBox.Text = proveedor.ProveedorId.ToString();
            NombretextBox.Text = proveedor.NombreProveedor;
            DirreciontextBox.Text = proveedor.Direccion;
            CiudadcomboBox.Text = proveedor.Ciudad;
            TelefonomaskedTextBox.Text = proveedor.Telefono;
            FaxmaskedTextBox.Text = proveedor.Fax;
            CorreotextBox.Text = proveedor.Correo;

  
        }

        private bool ValidarBuscar()
        {
            if (ProveedorBLL.Buscar(ut.StringInt(ProveedorIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ProveedorIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
             DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            DirreciontextBox.Clear();
            CiudadcomboBox.Text = "Elegir su Ciudad";
            TelefonomaskedTextBox.Clear();
            FaxmaskedTextBox.Clear();
            CorreotextBox.Clear();
            FechaIngresodateTimePicker.Value = f.Value;
            limpiarErroresProvider();

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            BuscarerrorProvider.Clear();
            LlenarClase(proveedor);
            if (ValidarTextbox() && ValidarExiste(NombretextBox.Text))
            {
                ProveedorBLL.Insertar(proveedor);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }
           

        }

        private bool ValidarExiste(string aux)
        {
            if (ProveedorBLL.GetListaNombreProveedor(aux).Count() > 0)
            {
                MessageBox.Show("Este Nombre proveedor de ya existe, favor intentar con otro Nombre de Proveedor o modificar...");
                return false;
            }
            return true;
        }

        private void LlenarClase(Proveedores p)
        {
           
            p.NombreProveedor = NombretextBox.Text;
            p.Ciudad = CiudadcomboBox.Text;
            p.Direccion = DirreciontextBox.Text;
            p.Telefono= TelefonomaskedTextBox.Text;
            p.Fax = FaxmaskedTextBox.Text;
            p.Correo = CorreotextBox.Text;
          
            p.FechaIngreso = FechaIngresodateTimePicker.Value;
        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(DirreciontextBox.Text) &&
                string.IsNullOrEmpty(CiudadcomboBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox.Text) &&
                string.IsNullOrEmpty(FaxmaskedTextBox.Text) &&
                string.IsNullOrEmpty(CorreotextBox.Text) 
                
                )
            {
                 NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar el Nombre de Proveedor");
                 DirrecionerrorProvider.SetError(DirreciontextBox, "Favor Ingresar la Dirrecion");
                 CiudaderrorProvider.SetError(CiudadcomboBox, "Favor Ingresar la ciudad de donde esta el proveedor");
                 TelefonoerrorProvider.SetError(TelefonomaskedTextBox, "Favor Ingresar el Telefono de proveedor");
                 FaxerrorProvider.SetError(FaxmaskedTextBox, "Favor Ingresar el numero de Fax de proveedor");
                 CorreoerrorProvider.SetError(CorreotextBox, "Favor Ingresar Correo de la proveedor");
                 
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Favor ingresar el Nombre del proveedor");
                return false;
            }
            if (string.IsNullOrEmpty(DirreciontextBox.Text))
            {
                 DirrecionerrorProvider.Clear();
                 DirrecionerrorProvider.SetError(DirreciontextBox, "Favor ingresar la dirrecion del proveedor");
                return false;
            }

            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
                CiudaderrorProvider.Clear();
                CiudaderrorProvider.SetError(CiudadcomboBox, "Favor ingresar la Ciudad de donde esta ubicado el proveedor");
                return false;
            }
            if (string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                TelefonoerrorProvider.Clear();
                TelefonoerrorProvider.SetError(TelefonomaskedTextBox, "Favor ingrese el numero de telefono del proveedor");
                return false;
            }

            if (string.IsNullOrEmpty(FaxmaskedTextBox.Text))
            {
                FaxerrorProvider.Clear();
                FaxerrorProvider.SetError(FaxmaskedTextBox, "Favor ingrese el numero de fax del proveedor");
                return false;
            }
            if (string.IsNullOrEmpty(CorreotextBox.Text))
            {
                CorreoerrorProvider.Clear();
                CorreoerrorProvider.SetError(CorreotextBox, "Favor ingrese el correo eletronico de proveedor");
                return false;
            }


            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Proveedor que desea eliminar") && ValidarBuscar())
            {
                ProveedorBLL.Eliminar(ut.StringInt(ProveedorIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }

        private void limpiarErroresProvider()
        {
            NombreerrorProvider.Clear();
            DirrecionerrorProvider.Clear();
            CiudaderrorProvider.Clear();
            TelefonoerrorProvider.Clear();
            FaxerrorProvider.Clear();
            CorreoerrorProvider.Clear();
            
        }

        private void RegistroDeProveedores_Load(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
          
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(proveedor);
                if (ValidarExiste(NombretextBox.Text))
                {
                    ProveedorBLL.Modificar(ut.StringInt(ProveedorIdlabel.Text), proveedor);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}


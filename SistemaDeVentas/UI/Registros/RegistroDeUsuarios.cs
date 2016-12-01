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
using SistemaDeVentas.Entidades;

namespace SistemaDeVentas
{
    public partial class RegistroDeUsuarios : Form 
    {
        Usuarios usuario = new Usuarios();
        UtilidadesInt ut = new UtilidadesInt();
        public RegistroDeUsuarios()
        {
            InitializeComponent();

        }
        //-- Botton Buscar y Todos sus Metodos Utilizados para Realizar dicha busqueda en la base de datos
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            CargarConboBox();
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(UsuariosBLL.Buscar(ut.StringInt(UsuarioIdtextBox.Text)));

        }
        private void LLenar(Usuarios usuario)
        {
            
            UsuarioIdtextBox.Text = usuario.UsuarioId.ToString();
            NombreUsuariostextBox.Text = usuario.NombreUsuario.ToString();
            ContraseñatextBox.Text = usuario.Contrasena;
            ConfimarContraseñatextBox1.Text = usuario.Contrasena;
           
            CargarConboBox();
        }
       
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(UsuarioIdtextBox.Text))
            {
                BuscarerrorProvider1.SetError(UsuarioIdtextBox, "Por Favor Ingresar Id");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (UsuariosBLL.Buscar(ut.StringInt(UsuarioIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                 return false;
            }

            return true;


        }
       
        //--
        //Botton de Nuevo Usuario
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        // Metodo Limpiar para el Botton de Nuevo Usuario
        public void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariostextBox.Clear();
            ContraseñatextBox.Clear();
            ConfimarContraseñatextBox1.Clear();
            limpiarErroresProvider();
        }
        //--
        //Botton De Guardar Usuario
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            BuscarerrorProvider1.Clear();
            LlenarClase(usuario);
            CargarConboBox();
            if (ValidarTextbox() && ValidarExiste(NombreUsuariostextBox.Text))
            {
               UsuariosBLL.Insertar(usuario);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
           

        }

        private void LlenarClase(Usuarios u)
        {
            TipoUsuarios tus = new TipoUsuarios();
            u.NombreUsuario = NombreUsuariostextBox.Text;
            u.Contrasena = ContraseñatextBox.Text;
            tus.Detalle = TipoUsuarioscomboBox.Text;
            u.Tipo =  tus.Detalle = TipoUsuarioscomboBox.Text;

        }
        //---

        //-- Botton Moficar que Modifica el Usuario  
       
        

        private bool ValidarExiste(string aux)
        {
            if (UsuariosBLL.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario o Modificar..");
                return false;
            }
            return true;
        }

        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text) && string.IsNullOrEmpty(ContraseñatextBox.Text) && string.IsNullOrEmpty(ConfimarContraseñatextBox1.Text))
            {
                NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor Ingresar El Nombre de Usuario");
                ContraseñaerrorProvider1.SetError(ContraseñatextBox, "Favor ingresar la contraseña del usuario");
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
               
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text))
            {
                NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                NombreUsuarioserrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor ingresar la contraseña del usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                NombreUsuarioserrorProvider1.Clear();
                ContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }

            if (ContraseñatextBox.Text != ConfimarContraseñatextBox1.Text)
            {
                NombreUsuarioserrorProvider1.Clear();
                ContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "La contraseña no coincide");
                MessageBox.Show("La Contraseña no conciden");
                return false;
            }
            if (TipoUsuarioscomboBox.Text != TipoUsuarioscomboBox.Text)
            {
                NombreUsuarioserrorProvider1.Clear();
                ContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.Clear();
                ElegirTipoUsuarioserrorProvider.Clear();
                MessageBox.Show("elegir tipo de usuarios");
                return false;
            }
            return true;
        }
       
       //---
       //Botton Eliminar
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                 UsuariosBLL.Eliminar(ut.StringInt(UsuarioIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        //-------
        // En Prueba
        public List<TipoUsuarios> lista = new List<TipoUsuarios>();
        private void CargarConboBox()
        {
           var db = new SistemaVentasDb();
            lista = db.TipoUsuarios.ToList();
            if (lista.Count > 0)
            {
               TipoUsuarioscomboBox.DataSource = lista;
               TipoUsuarioscomboBox.ValueMember = "TipoUsuarioId";
                TipoUsuarioscomboBox.DisplayMember = "Detalle";
            }
        }

        private void limpiarErroresProvider()
        {
           NombreUsuarioserrorProvider1.Clear();
           ConfimarContraseñaerrorProvider1.Clear();
           ContraseñaerrorProvider1.Clear();
            
           
        }




        private void RegistroDeUsuarios_Load(object sender, EventArgs e)
        {
            CargarConboBox();
            
        }

        private void TipoUsuarioscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {

            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(usuario);
                if (ValidarExiste(NombreUsuariostextBox.Text))
                {
                    UsuariosBLL.Modificar(ut.StringInt(UsuarioIdtextBox.Text), usuario);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}

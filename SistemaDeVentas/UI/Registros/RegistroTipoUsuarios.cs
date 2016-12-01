using BLL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistroTipoUsuarios : Form
    {
        TipoUsuarios tipo = new TipoUsuarios();
        UtilidadesInt ut = new UtilidadesInt();

        public RegistroTipoUsuarios()
        {
            InitializeComponent();
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BuscarerrorProvider.Clear();
            LlenarClase(tipo);
            if (ValidarTextbox() && ValidarExiste(DetalletextBox.Text))
            {
                TiposUsuariosBLL.Insertars(tipo);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
           

        }
        private void LlenarClase(TipoUsuarios t)
        {
            t.Detalle = DetalletextBox.Text;
        }





        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(DetalletextBox.Text))
            {
                DetalleerrorProvider.SetError(DetalletextBox, "Favor ingresar el detalle o descripcion el  tipo de usuarios");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }


            return true;
        }
        private bool ValidarExiste(string aux)
        {
            if (TiposUsuariosBLL.GetListaDetalle(aux).Count() > 0)
            {
                MessageBox.Show("Este tipo de usuario ya  existe, favor intentar con otro tipo de usuario o decea Modificar ...");
                return false;
            }
            return true;
        }
        private bool ValidarBuscar()
        {
            if (TiposUsuariosBLL.Buscar(ut.StringInt(TipoIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(TipoIdtextBox.Text))
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
            TipoIdtextBox.Clear();
            DetalletextBox.Clear();
            limpiarErroresProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id el tipo que desea eliminar") && ValidarBuscar())
            {
                TiposUsuariosBLL.Eliminar(ut.StringInt(TipoIdtextBox.Text));
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("ELiminado con exito");
            }
           
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Categoria que desea buscar") && ValidarBuscar())
                LLenar(TiposUsuariosBLL.Buscar(ut.StringInt(TipoIdtextBox.Text)));
        }
        private void LLenar(TipoUsuarios tipo)
        {

            TipoIdtextBox.Text = tipo.TipoUsuarioId.ToString();
            DetalletextBox.Text = tipo.Detalle;
        }
        private void limpiarErroresProvider()
        {
            BuscarerrorProvider.Clear();
            DetalleerrorProvider.Clear();
           


        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(tipo);
                if (ValidarExiste(DetalletextBox.Text))
                {
                    TiposUsuariosBLL.Modificard(ut.StringInt(TipoIdtextBox.Text), tipo);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}

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

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosCategoriaArticulos : Form
    {
        UtilidadesInt ut = new UtilidadesInt();
        Entidades.Articulos art = new Entidades.Articulos();
        Categorias categoria = new Categorias();
        public RegistrosCategoriaArticulos()
        {
            InitializeComponent();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Categoria que desea buscar") && ValidarBuscar())
                LLenar(BLL.CategoriaBLL.Buscar(ut.StringInt(CategoriaIdtextBox.Text)));
        }
        private void LLenar(Categorias categoria)
        {

            CategoriaIdtextBox.Text = categoria.CategoriaId.ToString();
            DescripciontextBox.Text = categoria.Descripcion;
        }

        private bool ValidarExiste(string aux)
        {
            if (BLL.CategoriaBLL.GetListaDescripcion(aux).Count() > 0)
            {
                MessageBox.Show("Este Categoria ya  existe, favor intentar con otra Descripcion de Categoria o Modificar...");
                return false;
            }
            return true;
        }
        private bool ValidarBuscar()
        {
            if (BLL.CategoriaBLL.Buscar(ut.StringInt(CategoriaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(CategoriaIdtextBox.Text))
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
            CategoriaIdtextBox.Clear();
            DescripciontextBox.Clear();
            limpiarErroresProvider();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            BuscarerrorProvider.Clear();
            LlenarClase(categoria);
           
            if (ValidarTextbox() && ValidarExiste(DescripciontextBox.Text))
            {
                BLL.CategoriaBLL.Insertar(categoria);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("Guardado con exito");
            }
            
        }

        private void LlenarClase(Categorias c)
        {
            c.Descripcion = DescripciontextBox.Text;
        }





        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(DescripciontextBox.Text) 
                

                )
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Favor la descripcion de  la Categoria de los articulo");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }     
           

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Categoria que desea eliminar") && ValidarBuscar())
            {
                BLL.CategoriaBLL.Eliminar(ut.StringInt(CategoriaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void limpiarErroresProvider()
        {
            BuscarerrorProvider.Clear();
            DescripcionerrorProvider.Clear();

        }

        private void RegistrosCategoriaArticulos_Load(object sender, EventArgs e)
        {
          
        }
        private void Quitarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(categoria);
                if (ValidarExiste(DescripciontextBox.Text))
                {
                    BLL.CategoriaBLL.Modificar(ut.StringInt(CategoriaIdtextBox.Text), categoria);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}

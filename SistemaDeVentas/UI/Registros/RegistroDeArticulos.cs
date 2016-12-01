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

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistroDeArticulos : Form
    {
        Entidades.Articulos articulos = new Entidades.Articulos();
        UtilidadesDouble utdouble = new UtilidadesDouble();
        UtilidadesInt ut = new UtilidadesInt();
        public double StringDouble(string texto)
        {
            double numero = 0;

            double.TryParse(texto, out numero);

            return numero;
        }
        public RegistroDeArticulos()
        {
            InitializeComponent();
        }
        private void RegistroDeArticulos_Load(object sender, EventArgs e)
        {
            CargarConboBoxProveedores();
            CargarConboBoxCategorias();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Articulo que desea buscar") && ValidarBuscar())
                LLenar(ArticuloBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)));
        }
        private void LLenar(Entidades.Articulos articulo)
        {


            ArticuloIdtextBox.Text = articulo.ArticuloId.ToString();
            NombreArticulotextBox.Text = articulo.Nombre;
            DespcripciontextBox.Text = articulo.Descripcion;
            CantidadtextBox.Text = articulo.CantidadDispodible.ToString();
            PrecioCompratextBox.Text = articulo.PrecioCompra.ToString();
            PrecioVentatextBox.Text = articulo.Precio.ToString();
            MarcaArticulotextBox.Text = articulo.Marca;

            CargarConboBoxCategorias();
            CargarConboBoxProveedores();
        }
        private bool ValidarBuscar()
        {
            if (ArticuloBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ArticuloIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarExiste(string aux)
        {
            if (ArticuloBLL.GetListaNombreArticulo(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre ya existe, favor intentar con otra nombre o modificar ...");
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
            ArticuloIdtextBox.Clear();
            NombreArticulotextBox.Clear();
            MarcaArticulotextBox.Clear();
            DescuentotextBox.Clear();
            DespcripciontextBox.Clear();
            CantidadtextBox.Clear();
            PrecioCompratextBox.Clear();
            PrecioVentatextBox.Clear();
            NombreProveedorcomboBox1.Text = "Elegir una opcion";
            FechadateTimePicker.Value = f.Value;
            //-----
            limpiarErroresProvider();

        }

       
        
        private void Guardabutton_Click(object sender, EventArgs e)
        {

           Entidades.Articulos arti = new Entidades.Articulos();
            BuscarerrorProvider.Clear();
            LlenarClase(arti);
            CargarConboBoxProveedores();
            CargarConboBoxCategorias();
            if (ValidarTextbox() && ValidarExiste(NombreArticulotextBox.Text))
            {

               ArticuloBLL.Insertar(arti);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");

            }
            

            // LlenarClase(arti);






        }

        private void LlenarClase(Entidades.Articulos a)
        {
            Proveedores p = new Proveedores();
            Categorias c = new Categorias();
            a.Nombre = NombreArticulotextBox.Text;
            a.CantidadDispodible = ut.StringInt(CantidadtextBox.Text);
            a.Descripcion = DespcripciontextBox.Text; ;
            a.Marca = MarcaArticulotextBox.Text;
            a.PrecioCompra = StringDouble(PrecioCompratextBox.Text);
            a.Precio = StringDouble(PrecioVentatextBox.Text);
            a.Descuento = ut.StringInt(DescuentotextBox.Text);
            p.NombreProveedor = a.NombreProveedor = NombreProveedorcomboBox1.Text;
            a.Categoria = c.Descripcion = CategoriacomboBox.Text;
            a.Fecha = FechadateTimePicker.Value;
         
        }


        private bool ValidarTextbox()
        {


            if (string.IsNullOrEmpty(NombreArticulotextBox.Text) &&
                string.IsNullOrEmpty(DespcripciontextBox.Text) &&
                string.IsNullOrEmpty(MarcaArticulotextBox.Text) &&
                string.IsNullOrEmpty(NombreProveedorcomboBox1.Text) &&
                string.IsNullOrEmpty(CategoriacomboBox.Text) &&
                string.IsNullOrEmpty(CantidadtextBox.Text) &&
                string.IsNullOrEmpty(PrecioCompratextBox.Text) &&
                string.IsNullOrEmpty(PrecioVentatextBox.Text)
               


                )
            {
               NombreArticuloerrorProvider.SetError(NombreArticulotextBox, "Favor Ingresar el  nombre del articulos");
               DescripcionerrorProvider.SetError(DespcripciontextBox, "Favor Ingresar la descripcion del articulo");
               MarcaerrorProvider.SetError(MarcaArticulotextBox, "Favor Ingresar la marca del articulo");
               NombreProveedorerrorProvider.SetError(NombreProveedorcomboBox1, "Favor elegir el proveedor a que  correponde el  articulo");
               CategoriaerrorProvider.SetError(CategoriacomboBox, "Favor elegir la categoria a que correponde el articulo");
               CantidaderrorProvider.SetError(CantidadtextBox, "Favor Ingresar la cantidad del articulo");
               PrecioCompraerrorProvider.SetError(PrecioCompratextBox, "Favor Ingresar el precio de compra del articulo");
               PrecioVentaerrorProvider.SetError(PrecioVentatextBox, "Favor Ingresar el precio de venta del articulo");
               MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
           
            if (string.IsNullOrEmpty(NombreArticulotextBox.Text))
            {
                NombreArticuloerrorProvider.Clear();
                NombreArticuloerrorProvider.SetError(NombreArticulotextBox, "Favor Ingresar el  nombre del articulos");
                return false;
            }

            if (string.IsNullOrEmpty(DespcripciontextBox.Text))
            {
                DescripcionerrorProvider.Clear();
                DescripcionerrorProvider.SetError(DespcripciontextBox, "Favor Ingresar la descripcion del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(MarcaArticulotextBox.Text))
            {
                MarcaerrorProvider.Clear();
                MarcaerrorProvider.SetError(MarcaArticulotextBox, "Favor Ingresar la marca del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(NombreProveedorcomboBox1.Text))
            {
                NombreProveedorerrorProvider.Clear();
                NombreProveedorerrorProvider.SetError(NombreProveedorcomboBox1, "Favor elegir el proveedor a que  correponde el  articulo");

                return false;
            }

            if (string.IsNullOrEmpty(CategoriacomboBox.Text))
            {
                CategoriaerrorProvider.Clear();
                CategoriaerrorProvider.SetError(CategoriacomboBox, "Favor elegir la categoria a que correponde el articulo");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                CantidaderrorProvider.Clear();
                CantidaderrorProvider.SetError(CantidadtextBox, "Favor Ingresar la cantidad del articulo");
                return false;
            }

            if (string.IsNullOrEmpty(PrecioCompratextBox.Text))
            {
                PrecioCompraerrorProvider.Clear();
                PrecioCompraerrorProvider.SetError(PrecioCompratextBox, "Favor Ingresar el precio de compra del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(PrecioVentatextBox.Text))
            {
                PrecioVentaerrorProvider.Clear();
                PrecioVentaerrorProvider.SetError(PrecioVentatextBox, "Favor Ingresar el precio de venta del articulo");
                return false;
            }
           



            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Articulo que desea eliminar") && ValidarBuscar())
            {
                ArticuloBLL.Eliminar(ut.StringInt(ArticuloIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        public List<Proveedores> lista = new List<Proveedores>();
         private void CargarConboBoxProveedores()
         {
             var db = new SistemaVentasDb();
             lista = db.Proveedores.ToList();
             if (lista.Count > 0)
             {
                 NombreProveedorcomboBox1.DataSource = lista;
                 NombreProveedorcomboBox1.ValueMember = "ProveedorId";
                 NombreProveedorcomboBox1.DisplayMember = "NombreProveedor";
             }
         }
        public List<Categorias> list = new List<Categorias>();
        private void CargarConboBoxCategorias()
        {
            var db = new SistemaVentasDb();
            list = db.Categorias.ToList();
            if (list.Count > 0)
            {
                CategoriacomboBox.DataSource = list;
                CategoriacomboBox.ValueMember = "CategoriaId";
                CategoriacomboBox.DisplayMember = "Descripcion";
            }
        }
        ///---------------
        private void limpiarErroresProvider()
        {
            

        }

        private void Articulopanel_Paint(object sender, PaintEventArgs e)
        {
       
        }

        
        public void CargarCombox()
        {

        }

        private void NombreProveedorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(articulos);
                if (ValidarExiste(NombreArticulotextBox.Text))
                {
                   ArticuloBLL.Modificar(ut.StringInt(ArticuloIdtextBox.Text), articulos);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}

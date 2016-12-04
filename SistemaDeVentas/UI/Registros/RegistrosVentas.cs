using BLL;
using Entidades;
using SistemaDeVentas;
using SistemaDeVentas.BLL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.Registros
{
    public partial class RegistrosVentass : Form
    {
        Ventas factura;
        public RegistrosVentass()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarClientes();
            CargarArticulos();
            CargarTipoPagos();
            factura = new Ventas();
        }
        public void CargarArticulos()
        {

            ArticulocomboBox.DataSource = null;
            ArticulocomboBox.DataSource = BLL.ArticuloBLL.GetLista();
            ArticulocomboBox.ValueMember = "ArticuloId";
            ArticulocomboBox.DisplayMember = "Nombre";

        }
        public void CargarEmpleados()
        {

            EmpleadocomboBox.DataSource = null;
            EmpleadocomboBox.DataSource = BLL.EmpleadosBLL.GetLista();
            EmpleadocomboBox.ValueMember = "EmpleadoId";
            EmpleadocomboBox.DisplayMember = "Nombre";

        }

        public void CargarClientes()
        {

            ClientecomboBox.DataSource = null;
            ClientecomboBox.DataSource = BLL.ClientesBLL.GetLista();
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombre";

        }

        private void CargarTipoPagos()
        {

            CondicioncomboBox.DataSource = null;
            CondicioncomboBox.DataSource = CondicionPagosBLL.GetLista();
            CondicioncomboBox.ValueMember = "CondicionId";
            CondicioncomboBox.DisplayMember = "Descripcion";

        }






        UtilidadesInt ut = new UtilidadesInt();


        private void BuscarIdbutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Venta que desea buscar") && ValidarBuscar())
                factura = VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text));
                 Llenar();
        }
        private void Llenar()
        {

            if (factura != null)
            {
                SubTotaltextBox.Text = factura.SubTotal.ToString();
                TotalItebistextBox.Text = factura.TotalItebis.ToString();
                TotaltextBox.Text = factura.Total.ToString();
                ArticulodataGridView.DataSource = null;
                ArticulodataGridView.DataSource = factura.Articulos;
            }

        }

        private void Nuevabutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Cobrarbutton_Click_1(object sender, EventArgs e)
        {
            LlenarClase();
            if (ValidarTextbox())
            {
                if (VentasBLL.Insertar(factura))
                {
                    MessageBox.Show("Guardo");
                    Limpiar();
                }
            }
        }
        private void LlenarClase()
        {
            //factura.FechaVencimiento = FechaVencimientodateTimePicker;
            factura.Empleado = EmpleadocomboBox.Text;
            factura.Cliente = ClientecomboBox.Text;
            factura.Cantidad = factura.Articulos.Count();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Venta  que desea eliminar") && ValidarBuscar())
            {
                VentasBLL.Eliminar(VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text)));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
           
        }
        //------------------------Carcular Para el Agregar-----------------------------------------
        private void Calcular(Ventas venta)
        {
            double subTotal = 0, itebis = 18, total = 0, totalItebis = 0;
            foreach (var detalle in venta.Articulos)
            {
                subTotal += detalle.Importe;
                totalItebis += subTotal * itebis / 100;
                total = subTotal + totalItebis;
            }
            venta.SubTotal = subTotal;
            venta.Itebis = itebis;
            venta.Total = total;
            venta.TotalItebis += venta.SubTotal * venta.Itebis / 100;
            venta.Total = venta.SubTotal + venta.TotalItebis;

        }
        //-----------------------Agregar-----------------------------------------------------------
        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            if (ValidarTextbox())
            {
                int id = (int)ArticulocomboBox.SelectedValue;
                factura.Articulos.Add(new Articulos(id, ArticulocomboBox.Text, ArticuloBLL.GetPrecio(id), ut.StringInt(CantidadArticulotextBox.Text)));
                ArticulodataGridView.DataSource = null;
                ArticulodataGridView.DataSource = factura.Articulos;
                Calcular(factura);
                CantidadAgregafotextBox.Text = factura.Articulos.Count().ToString();
                SubTotaltextBox.Text = factura.SubTotal.ToString();
                TotalItebistextBox.Text = factura.TotalItebis.ToString();
                TotaltextBox.Text = factura.Total.ToString();
            }
        }

        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            //var reporte = new ve.FacturaReporte();
            //reporte.VentaId = ut.StringInt(FacturaIdtextBox.Text);
            //reporte.Show();

        }
        //-------------------------Validar---------------------------------------------------

        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))

            {
                //SetError(FacturaIdtextBox, "Favor Ingresar el codigo de la venta");

                MessageBox.Show("Favor Campos sellalados Con el punto rojo");

            }
            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))
            {

                //CodigoerrorProvider.SetError(FacturaIdtextBox, "Favor ingresar el codigo de la venta");
                return false;
            }

            return true;

        }





        private bool ValidarBuscar()
        {
            if (VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(FacturaIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        //--------------------------------Limpiar----------------------------------------------
        private void Limpiar()
        {
            ArticulodataGridView.DataSource = null;
            CantidadArticulotextBox.Clear();
            CantidadAgregafotextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            FacturaIdtextBox.Clear();
            factura = new Ventas();
        }

        private void RegistrosVentass_Load(object sender, EventArgs e)
        {

        }
    }
}

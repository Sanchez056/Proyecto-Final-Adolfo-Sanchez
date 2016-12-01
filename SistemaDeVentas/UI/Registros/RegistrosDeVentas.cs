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
using DAL;
using BLL;
using SistemaDeVentas.Entidades;
using SistemaDeVentas.BLL;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosDeVentas : Form
    {
        public List<Ventas> ventList = new List<Ventas>();
        public List<Empleados> list = new List<Empleados>();
        public List<Articulos> lista = new List<Articulos>();
        public List<Clientes> listac = new List<Clientes>();
        public List<CondicionPagos> listacd = new List<CondicionPagos>();
        Ventas venta = new Ventas();
        Clientes cliente = new Clientes();
        UtilidadesInt utint = new UtilidadesInt();
        UtilidadesDouble utDouble = new UtilidadesDouble();
        public RegistrosDeVentas()
        {
            InitializeComponent();
        }

      
        public List<Clientes> lists = new List<Clientes>();
       
        private void RegistrosDeVentas_Load(object sender, EventArgs e)
        {
            CargarComboxCondicion();
            CargarComboxEmpleados();
            CargarConboBoxClientes();
            CargarComboxArticulo();
           
            //LLenarCombo();

           
           
        }
       

        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            ClientecomboBox.Text ="Elegir Cliente";
            FacturaIdtextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            CantidadArticulotextBox.Clear();
            ItebistextBox.Clear();
            ItebisTotaltextBox.Clear();
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.Rows.Clear();
            //FechadateTimePicker.Value = f.Value;
            LimpiarErroresProvider();

            //-----
            // limpiarErroresProvider();

        }

        private void Nuevabutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarIdbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Venta que desea buscar") && ValidarBuscar())
                LLenar(BLL.VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text)));
             
        }

        private void LLenar(Ventas v)
        {
           
            var vent = BLL.VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text));
            FacturaIdtextBox.Text = v.VentaId.ToString();
            
            ArticulodataGridView.DataSource = venta.Cantidad;
            ArticulodataGridView.DataSource = v.Articulos;
            CantidadArticulotextBox.Text = v.Cantidad.ToString();
            CondicioncomboBox.Text = v.CodicionPago;
            EmpleadocomboBox.Text = v.Empleado;
            ClientecomboBox.Text = v.Cliente;
            
            

            //v.Fecha = FechadateTimePicker.Value;

            
           CargarComboxEmpleados();
            CargarConboBoxClientes();
            CargarComboxCondicion();
            
           
        }
        public List<CondicionPagos> listass = new List<CondicionPagos>();

        private void CargarComboxArticulo()
        {
           


                ArticulocomboBox.DataSource = lista;
                ArticulocomboBox.ValueMember = "ArticuloId";
                ArticulocomboBox.DisplayMember = "Nombre";
            
        }
        private void CargarComboxCondicion()
        {
          

                CondicioncomboBox.DataSource = listacd;
                CondicioncomboBox.ValueMember = "CondicionId";
                CondicioncomboBox.DisplayMember = "Descripcion";
            
        }

        private void CargarComboxEmpleados()
        {

                EmpleadocomboBox.DataSource = list;
                EmpleadocomboBox.ValueMember = "EmpleadoId";
                EmpleadocomboBox.DisplayMember = "Nombre";
            
           

        }
         public List<Clientes> listas = new List<Clientes>();
        private void CargarConboBoxClientes()
        {
            

                ClientecomboBox.DataSource = listac;
                ClientecomboBox.ValueMember = "ClienteId";
                ClientecomboBox.DisplayMember = "Nombre";
            
        }


        UtilidadesInt ut = new UtilidadesInt();
        private bool ValidarBuscar()
        {
            if (BLL.VentasBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text)) == null)
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

        private void EmpleadogroupBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void RefrecarVentanabutton_Click(object sender, EventArgs e)
        {

        }

        private void Cobrarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarClase(venta);
                if (ValidarTextbox())
                {

                    BLL.VentasBLL.Insertar(venta);
                    Limpiar();
                    LimpiarErroresProvider();
                    MessageBox.Show("Guardado con exito");
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());


            }
        
           
            
            //LlenarClase(venta);
            //if (ValidarTextbox())
            //{
              
            //    BLL.VentasBLL.Insertar(venta);
            //    Limpiar();
            //    LimpiarErroresProvider();
            //    MessageBox.Show("Guardado con exito");
            //}
                


        }
        private void LlenarClase(Ventas v)
        {

            // v.Deuda = utDouble.StringDouble(MontoDeudatextBox.Text);
            v.CodicionPago = CondicioncomboBox.Text;
            v.Fecha = FechadateTimePicker.Value;
            v.Cantidad = v.Articulos.Count();
            v.Cliente = ClientecomboBox.Text;
            v.Empleado = EmpleadocomboBox.Text;
            CargarComboxEmpleados();
            CargarConboBoxClientes();
            CargarComboxArticulo();
            CargarComboxCondicion();

        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text) )
                
            {
               //SetError(FacturaIdtextBox, "Favor Ingresar el codigo de la venta");
              
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))
            {
              
                //CodigoerrorProvider.SetError(FacturaIdtextBox, "Favor ingresar el codigo de la venta");
                return false;
            }
           
            return true;

        }
      
        //---------------------------------------------------------------------

       

       
       
        private bool ValidarBuscarArticulo()
        {
            if (ArticuloBLL.Buscar(ut.StringInt(FacturaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarIdArticulo(string message)
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
        
        
       

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Venta  que desea eliminar") && ValidarBuscar())
            {
                BLL.VentasBLL.Eliminar(ut.StringInt(FacturaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        private void Calcular(Ventas venta)
        {
            double subTotal = 0, itebis = 18, total=0 ,totalItebis=0;
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


        private void Agregarbutton_Click(object sender, EventArgs e)
        {

             venta.Articulos.Add(new Articulos((int)ArticulocomboBox.SelectedValue,ArticulocomboBox.Text, ut.StringInt(CantidadArticulotextBox.Text),ArticuloBLL.GetListaPrecio((int)ArticulocomboBox.SelectedValue), utDouble.StringDouble(ArticulocomboBox.Text)));
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.DataSource = venta.Articulos;
            Calcular(venta);
            SubTotaltextBox.Text = venta.Articulos.Count().ToString();
            SubTotaltextBox.Text = venta.SubTotal.ToString();
            ItebisTotaltextBox.Text = venta.TotalItebis.ToString();
            TotaltextBox.Text = venta.Total.ToString();

        }

        private void LimpiarErroresProvider()
        {
           
        }


       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
        private void ContadoradioButton_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {


        }

        private void FiltrarVentaIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            


        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

        }
        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {

        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(venta);
                
                    BLL.VentasBLL.Modificar(ut.StringInt(FacturaIdtextBox.Text), venta);
                    Limpiar();
                    LimpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                

            }
        }

        private void CondicioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CondicioncomboBox.Text = "Elegir Condicion";

        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientecomboBox.Text = "Elegir Cliente";

        }

        private void EmpleadocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpleadocomboBox.Text= "Elegir Empleados";
        }

        private void ItebisTotaltextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    


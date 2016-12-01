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

namespace SistemaDeVentas.Consultas
{
    public partial class ConsultaProveedores : Form
    {
        public ConsultaProveedores()
        {
            InitializeComponent();
        }

        public List<Proveedores> lista = new List<Proveedores>();

        private void ConsultaProveedores_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ProveedorId");
            FiltrarcomboBox.Items.Insert(1, "NombreProveedor");
            FiltrarcomboBox.Items.Insert(2, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaProveedoressdataGridView.DataSource = ProveedorBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            UtilidadesInt ut = new UtilidadesInt();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedorBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = ProveedorBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedorBLL.GetListaNombreProveedor(FiltrotextBox.Text);
                }
                else
                {
                    lista = ProveedorBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }
            
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedorBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ProveedorBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {
            UtilidadesInt ut = new UtilidadesInt();

            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir un intervalo diferente entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && ProveedorBLL.GetListaNombreProveedor(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
           

            if (FiltrarcomboBox.SelectedIndex == 0 && ProveedorBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
             MyViewerProveedor viewer = new MyViewerProveedor();

            viewer.ProveedorreportViewer.Reset();
            viewer.ProveedorreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ProveedorreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\UI\Reportes\ListadoProveedores.rdlc";


            viewer.ProveedorreportViewer.LocalReport.DataSources.Clear();


            viewer.ProveedorreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetProveedores",
                ProveedorBLL.GetLista()));

            viewer.ProveedorreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}

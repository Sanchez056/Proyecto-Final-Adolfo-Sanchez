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
using SistemaDeVentas.Entidades;

namespace SistemaDeVentas.Consultas
{
    public partial class ConsultasArticulos : Form
    {
        public ConsultasArticulos()
        {
            InitializeComponent();
        }

        public List<Articulos> lista = new List<Articulos>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
             if (validar() == true)
                BuscarSelecionComBox();
        
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ArticuloId");
            FiltrarcomboBox.Items.Insert(1, "NombreArticulo");
            FiltrarcomboBox.Items.Insert(2, "MarcaArticulo");      
            FiltrarcomboBox.Items.Insert(3, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaArticulosdataGridView.DataSource = ArticuloBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            UtilidadesInt ut = new UtilidadesInt();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticuloBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = ArticuloBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticuloBLL.GetListaNombreArticulo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ArticuloBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticuloBLL.GetListaMarcaArticulo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ArticuloBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }
            
           
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    //lista = ArticuloBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ArticuloBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {
            UtilidadesInt ut = new UtilidadesInt();

            if (FiltrarcomboBox.SelectedIndex == 0 && ArticuloBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }


            
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && ArticuloBLL.GetListaNombreArticulo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ArticuloBLL.GetListaMarcaArticulo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
           
            if (FiltrarcomboBox.SelectedIndex == 4)
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


            BuscarerrorProvider.Clear();


            return true;
        }


        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerArticulos viewer = new MyViewerArticulos();

            viewer.ArticulosreportViewer.Reset();
            viewer.ArticulosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ArticulosreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\UI\Reportes\ListadoArticulos.rdlc";


            viewer.ArticulosreportViewer.LocalReport.DataSources.Clear();


            viewer.ArticulosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetArticulos",
                ArticuloBLL.GetLista()));

            viewer.ArticulosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }

        private void ConsultasArticulos_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }
    }
}

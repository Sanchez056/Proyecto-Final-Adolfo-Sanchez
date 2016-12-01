using Entidades;
using SistemaDeVentas.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.UI.Consultas
{
    public partial class ConsultaCatedoriaArticulos : Form
    {
        public ConsultaCatedoriaArticulos()
        {
            InitializeComponent();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerCategoria viewer = new MyViewerCategoria();

            viewer.CategoriareportViewer.Reset();
            viewer.CategoriareportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.CategoriareportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\UI\Reportes\ListadosCategoria.rdlc";


            viewer.CategoriareportViewer.LocalReport.DataSources.Clear();


            viewer.CategoriareportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("CategoriaDataSet",
                BLL.CategoriaBLL.GetLista()));

            viewer.CategoriareportViewer.LocalReport.Refresh();

            viewer.Show();
        }

        private void ConsultaCatedoriaArticulos_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }
        List<Categorias> lista = new List<Categorias>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "CategoriaId");
            FiltrarcomboBox.Items.Insert(1, "Descripcion");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaCategoriadataGridView.DataSource = CategoriaBLL.GetLista();
        }
        private void BuscarSelecionComBox()
        {
            UtilidadesInt ut = new UtilidadesInt();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = CategoriaBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = CategoriaBLL.GetLista();
                }

                ConsultaCategoriadataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = CategoriaBLL.GetListaDescripcion(FiltrotextBox.Text);
                }
                else
                {
                    lista = CategoriaBLL.GetLista();
                }

                ConsultaCategoriadataGridView.DataSource = lista;
            }

        }
        private bool validar()
        {
            UtilidadesInt ut = new UtilidadesInt();




            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrarcomboBox.SelectedIndex == 0 && CategoriaBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && CategoriaBLL.GetListaDescripcion(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }





            BuscarerrorProvider.Clear();


            return true;
        }

    }
}

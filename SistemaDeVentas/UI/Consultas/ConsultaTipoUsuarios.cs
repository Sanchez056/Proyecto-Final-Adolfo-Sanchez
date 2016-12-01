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

namespace SistemaDeVentas.UI.Consultas
{
    public partial class ConsultaTipoUsuarios : Form
    {
        public ConsultaTipoUsuarios()
        {
            InitializeComponent();
        }
        public List<TipoUsuarios> lista = new List<TipoUsuarios>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "TipoUsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Detalle");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaTipoUsuariodataGridView.DataSource = TiposUsuariosBLL.GetLista();
        }
        private void BuscarSelecionComBox()
        {
            UtilidadesInt ut = new UtilidadesInt();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = TiposUsuariosBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = TiposUsuariosBLL.GetLista();
                }

               ConsultaTipoUsuariodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = TiposUsuariosBLL.GetListaDetalle(FiltrotextBox.Text);
                }
                else
                {
                    lista = TiposUsuariosBLL.GetLista();
                }

                ConsultaTipoUsuariodataGridView.DataSource = lista;
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

            if (FiltrarcomboBox.SelectedIndex == 0 && TiposUsuariosBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && TiposUsuariosBLL.GetListaDetalle(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }





            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerTipoUsuarios viewer = new MyViewerTipoUsuarios();

            viewer.TipoUsuariosreportViewer.Reset();
            viewer.TipoUsuariosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.TipoUsuariosreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\UI\Reportes\ListadosTipoUsuarios.rdlc";


            viewer.TipoUsuariosreportViewer.LocalReport.DataSources.Clear();


            viewer.TipoUsuariosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("TipoUsuariosDataSet",
                UsuariosBLL.GetLista()));

            viewer.TipoUsuariosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }

        private void ConsultaTipoUsuarios_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }
    }
}

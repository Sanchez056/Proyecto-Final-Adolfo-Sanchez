using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Consultas
{
    public partial class MyViewerArticulos : Form
    {
        public MyViewerArticulos()
        {
            InitializeComponent();
        }

        private void MyViewerArticulos_Load(object sender, EventArgs e)
        {

            this.ArticulosreportViewer.RefreshReport();
        }

        private void ArticulosreportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

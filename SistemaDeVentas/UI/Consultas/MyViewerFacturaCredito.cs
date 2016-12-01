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
    public partial class MyViewerFacturaCredito : Form
    {
        public MyViewerFacturaCredito()
        {
            InitializeComponent();
        }

        private void MyViewerFacturaCredito_Load(object sender, EventArgs e)
        {

            this.FacturaCreditoreportViewer.RefreshReport();
        }
    }
}

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
    public partial class MyViewerProveedor : Form
    {
        public MyViewerProveedor()
        {
            InitializeComponent();
        }

        private void MyViewer_Load(object sender, EventArgs e)
        {

            this.ProveedorreportViewer.RefreshReport();
        }
    }
}

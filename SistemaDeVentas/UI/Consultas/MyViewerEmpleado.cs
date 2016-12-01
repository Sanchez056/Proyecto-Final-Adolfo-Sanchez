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
    public partial class MyViewerEmpleado : Form
    {
        public MyViewerEmpleado()
        {
            InitializeComponent();
        }

        private void MyViewerEmpleado_Load(object sender, EventArgs e)
        {

            this.EmpleadoreportViewer.RefreshReport();
        }

        private void EmpleadoreportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

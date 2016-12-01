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
    public partial class MyViewerTipoUsuarios : Form
    {
        public MyViewerTipoUsuarios()
        {
            InitializeComponent();
        }

        private void MyViewerTipoUsuarios_Load(object sender, EventArgs e)
        {

            this.TipoUsuariosreportViewer.RefreshReport();
        }
    }
}

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
    public partial class MyViewerUsuarios : Form
    {
        public MyViewerUsuarios()
        {
            InitializeComponent();
        }

        private void MyViewerUsuarios_Load(object sender, EventArgs e)
        {

            this.UsuariosreportViewer.RefreshReport();
        }
    }
}

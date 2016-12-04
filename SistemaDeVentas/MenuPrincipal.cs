using Microsoft.Win32;
using ProyectoFinal_Aplicada1.Registros;
using SistemaDeVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaDeVentas
{
    public partial class MenuPrincipal : Form
    {
        
        RegistroDeUsuarios Rus = new RegistroDeUsuarios();
        
       
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroDeArticulos re = new UI.Registros.RegistroDeArticulos();

            re.MdiParent = this;
            re.Show();
            re.Location = new Point(40, 40);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios ResUs = new RegistroDeUsuarios();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios consulta= new Consultas.ConsultaUsuarios();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(40, 40);
        }

        private void ConsultaarticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultasArticulos consulta = new Consultas.ConsultasArticulos();
            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(40, 40);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrosclientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            RegistroDeClientes resCli = new RegistroDeClientes();


            resCli.MdiParent = this;
            resCli.Show();
            resCli.Location = new Point(40, 40);

        }

        private void registrosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosDeEmpleado regisEmpleado= new Registros.RegistrosDeEmpleado();

            regisEmpleado.MdiParent = this;
            regisEmpleado.Show();
            regisEmpleado.Location = new Point(40, 40);


        }

        private void RegistrosproveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroDeProveedores regisProvee = new Registros.RegistroDeProveedores();

            regisProvee.MdiParent = this;
            regisProvee.Show();
            regisProvee.Location = new Point(40, 40);


        }

        

        private void ConsultaclientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientes consulta= new Consultas.ConsultaClientes();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(40, 40);
        }

        private void ConsultaproveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaProveedores consulta = new Consultas.ConsultaProveedores();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(40, 40);
        }

       

        private void Ventasbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
             

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          RegistrosVentass resv = new RegistrosVentass();

            resv.MdiParent = this;
            resv.Show();
            resv.Location = new Point(15, 40);

        }

        private void CalculadoratoolStripButton_Click(object sender, EventArgs e)
        {
            UI.Extras.Calculadoras ca = new UI.Extras.Calculadoras();

            ca.MdiParent = this;
            ca.Show();
            ca.Location = new Point(1050, 40);

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComprastoolStripButton_Click(object sender, EventArgs e)
        {
          


        }

       

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosCategoriaArticulos rect = new UI.Registros.RegistrosCategoriaArticulos();

            rect.MdiParent = this;
            rect.Show();
            rect.Location = new Point(15, 30);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultaempleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaEmpleado cus = new UI.Consultas.ConsultaEmpleado();

            cus.MdiParent = this;
            cus.Show();
            cus.Location = new Point(15, 30);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaCompra cus = new UI.Consultas.ConsultaCompra();

            cus.MdiParent = this;
            cus.Show();
            cus.Location = new Point(15, 30);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaVentas cus = new UI.Consultas.ConsultaVentas();

            cus.MdiParent = this;
            cus.Show();
            cus.Location = new Point(15, 30);
        }

       

        private void tiposUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroTipoUsuarios res = new UI.Registros.RegistroTipoUsuarios();

            res.MdiParent = this;
            res.Show();
            res.Location = new Point(15, 30);
        }

        private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaTipoUsuarios cus = new UI.Consultas.ConsultaTipoUsuarios();

            cus.MdiParent = this;
            cus.Show();
            cus.Location = new Point(15, 30);
        }

        private void categoriaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultaCatedoriaArticulos cus = new UI.Consultas.ConsultaCatedoriaArticulos();

            cus.MdiParent = this;
            cus.Show();
            cus.Location = new Point(15, 30);
        }
    }
}



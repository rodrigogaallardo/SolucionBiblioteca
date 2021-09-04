using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        

        public MenuPrincipal()
        {
            InitializeComponent();
            tsmiNuevoAutor.Click += OpcionesMenu; // Estos son los dos botones con eventos que tiene el menu principal
            tsmiConsultaAutores.Click += OpcionesMenu;
            tsmiConsultaBD.Click += OpcionesMenu;

        }

        private void OpcionesMenu(object sender, EventArgs e)
        {
            ToolStripMenuItem opcion = sender as ToolStripMenuItem; //propiedad de visual para los dos opciones (Agregar y consultar)
            switch (opcion.Name)
            {
                case "tsmiNuevoAutor":
                    Form1 objFormNuevo = new Form1(); // para agregar autor nos dirigimos al form1 
                    objFormNuevo.MdiParent = this;
                    objFormNuevo.StartPosition = FormStartPosition.CenterScreen;
                    objFormNuevo.Show();
                    break;
                case "tsmiConsultaAutores":
                    FrmConsultaAutores objFormConsulta = new FrmConsultaAutores();
                    objFormConsulta.MdiParent = this;
                    objFormConsulta.StartPosition = FormStartPosition.CenterScreen;
                    objFormConsulta.Show();
                    break;
                case "tsmiConsultaBD":
                    FrmConsultaAutoresBD objFormConsultaAutoresBD = new FrmConsultaAutoresBD();
                    objFormConsultaAutoresBD.MdiParent = this;
                    objFormConsultaAutoresBD.StartPosition = FormStartPosition.CenterScreen;
                    objFormConsultaAutoresBD.Show();
                    break;
                default:
                    break;
            }
        }
    }
}

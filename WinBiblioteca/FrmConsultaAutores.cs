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
    public partial class FrmConsultaAutores : Form
    {
        public FrmConsultaAutores()
        {
            InitializeComponent();
            TraerAutores();
        }

        void TraerAutores()
        {
            Logica.Autor objLogica = new Logica.Autor();
            dgvAutores.DataSource = objLogica.TraerTodos(Program.ListaAutores);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

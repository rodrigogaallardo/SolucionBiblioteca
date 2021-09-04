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
    public partial class FrmConsultaAutoresBD : Form
    {
        public FrmConsultaAutoresBD()
        {
            InitializeComponent();
            TraerAutores();
        }

        void TraerAutores()
        {
            Logica.Autor objlogica = new Logica.Autor();
            dgvAutores.DataSource = objlogica.TraerTodos();
        }
    }
}

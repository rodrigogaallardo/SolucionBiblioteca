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
    public partial class Form1 : Form // Es un contructor lo primero que se va a ejecutar cuando venga un New
    {
        public Form1()
        {
            InitializeComponent();
            //subcribir los eventos click de los 2 botones
            btnCerrar.Click += botones;
            btnConfirmar.Click += botones;
        }

        private void botones(object sender, EventArgs e)
        {
            //codigo va a ejecutarse cuando el usuario 
            //haga click en alguno de los 2 botones
            Button boton = sender as Button; // vuelvo a poner las propiades del boton de .net
            switch (boton.Name)
            {
                case "btnCerrar":
                    Close();
                    break;
                case "btnConfirmar":
                    //comunicarnos con la capa de logica
                    Logica.Autor objLogica = new Logica.Autor();

                    Entidades.Autor objEntidad = new Entidades.Autor();
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.FechaNacimiento = dtpFechaNacimiento.Value;
                    objEntidad.Nacionalidad = cboPaises.SelectedItem.ToString();

                    //objLogica.Agregar(Program.ListaAutores, objEntidad);
                    //MessageBox.Show("Autor agregado a la coleccion!!!");

                    //llamo al agregar de logica sobrecargado
                    objLogica.Agregar(objEntidad);
                    MessageBox.Show("Autor agregado a la base de datos!");
                    break;
                default:
                    break;
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

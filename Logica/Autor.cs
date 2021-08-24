using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        //metodos 
        // recibir de presentacion 
        // y si necesita envia a datos
        public void Agregar(List<Entidades.Autor> lista,
                            Entidades.Autor autor)
        {
            // agregar un elemento a una coleccion
            lista.Add(autor); // a la lista suma un autor
        }
        public List<Entidades.Autor> TraerTodos(List<Entidades.Autor> lista)
        {
            return lista;
        }
        public void Modificar()
        { }
        public void Borrrar()
        { }

    }
}

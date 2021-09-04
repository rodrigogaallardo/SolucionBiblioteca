using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // necesito acceder a lo que me devuelve datos

namespace Logica
{   //se pone public para que por fuera de Logica se puedan crear instancias
    public class Autor
    {
        //metodos 
        // recibir de presentacion 
        // y si necesita envia a datos

        //***********************************
        //metodos de acceso a las colecciones
        //***********************************

        public void Agregar(List<Entidades.Autor> lista,
                            Entidades.Autor autor)
        {
            // agregar un elemento a una coleccion
            autor.ID = lista.Count + 1; //pone un id en estado de memoria
            lista.Add(autor); // a la lista suma un autor
        }

        public List<Entidades.Autor> TraerTodos(List<Entidades.Autor> lista)
        {
            return lista;
        }


        //**************************************
        //metodos de acceso a las bases de datos
        //**************************************
        //sobreccargar Agregar

        Datos.Autor objDatos = new Datos.Autor(); //instancia para ejecutar el traer, la saco afuera para usar en todo el manejo de datos
        
        public void Agregar (Entidades.Autor autor)
        {
            //para enviar a la capa de datos le tengo que enviar un objeto
            
            objDatos.Agregar(autor);
        }

        public DataTable TraerTodos() 
        {
            return objDatos.TraerTodos();
        }
        
        public void Modificar()
        { }
        public void Borrrar()
        { }

    }
}

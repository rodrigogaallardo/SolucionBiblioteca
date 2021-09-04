using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //Internal: signnifica que todas ls clases que esten dentro de
    // este namespace tienen acceso a esta clase 
    //Static: para no estar haciendo New de conexion, en cualquier metodo o clase
    // de la capa de datos, no tener que estar haciendo instancias 
    // de la clase conexion
    internal static class Conexion
    {
        // cadena de conexion
        internal static string strConexion = @"Server=RODRI\SQLEXPRESS;DataBase=Biblioteca;Integrated Security=true";
    }
}

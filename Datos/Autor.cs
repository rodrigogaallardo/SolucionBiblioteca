using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //trabajo con las clases que tienen que ver con el modo conectado
using System.Data; //forma para manejar datos

namespace Datos
{   //no es lo mismo que entidades que tenia las propiedades
    //este autor manipula los datos, es el que recibe de logica
    // y envia a la base de datos , se comunica
    public class Autor
    {
        //Entidades solo tenia propiedades
        //asi como logica tenia metodos aca es igual
        //Solo metodos que interactuan con la base de datos
        //tienen que ser publicos, funciones o precedimiento, que sean
        //de tipo Void o de que devuelvan algun valor
        //En el caso de los metodos donde se hacen transacciones en la dba
        // son de tipo VOID . Metodo entre parentesis

        public void Agregar(Entidades.Autor autor) //preguntar "autor"
        {
            string strSQL = @"insert autores(apellido,nombre,fechanacimiento,nacionalidad)
                                     values(@apellido,@nombre,@fechaNacimiento,@nacionalidad)";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objComm = new SqlCommand(strSQL,objConexion);//donde ejecutar esa sentencia
            //agregar los parametros al objComm, los parametros son colecciones
            //del obj comm que es una instancia de la clase sql comman
            objComm.Parameters.AddWithValue("@apellido",autor.Apellido);
            objComm.Parameters.AddWithValue("@nombre", autor.Nombre);
            objComm.Parameters.AddWithValue("@fechaNacimiento", autor.FechaNacimiento);
            objComm.Parameters.AddWithValue("@nacionalidad", autor.Nacionalidad);
            // abro la conexion
            objConexion.Open();
            //ejecutar la sentencia
            //objComm.ExecuteNonQueryAsync();
            objComm.ExecuteNonQuery();
            //cierro la conexion
            objConexion.Close();
        }

        public void Modificar(Entidades.Autor autor)
        {

        }
        //Clase que me permita devolver una tabla
        //metodos entre parentesis
        public DataTable TraerTodos()
        {
            //variable con la funcion y con el tipo que voy a devolver
            DataTable dt = new DataTable();
            //llenar la variable con una sentencia 
            string strSQL = "select * from autores";
            //dataAdapter conforma los dos campos: conectado y desconectado
            //setencia y donde la va a ejecutar
            SqlDataAdapter objDa = new SqlDataAdapter(strSQL, Conexion.strConexion);
            //Llenar el campo dt para que se vaya con una tabla el retorno
            objDa.Fill(dt);
            return dt;
        }
    }
}

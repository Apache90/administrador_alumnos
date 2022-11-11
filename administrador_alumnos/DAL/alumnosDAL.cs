using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using administrador_alumnos.BLL;

namespace administrador_alumnos.DAL
{
    internal class alumnosDAL
    {
        conexionDAL conexion;

        public alumnosDAL()
        {
            conexion = new conexionDAL();
        }

        public bool agregar(alumnosBLL oAlumnosBLL)
        {


            SqlCommand SQLComando = new SqlCommand("INSERT INTO tablaAlumnos VALUES(@ID, @escuela, @año, @nombre, @apellido, @materia, @nota, @foto )");

            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@escuela", SqlDbType.VarChar).Value = oAlumnosBLL.Escuela;
            SQLComando.Parameters.Add("@año", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@materia", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@nota", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@foto", SqlDbType.Image).Value = oAlumnosBLL.ID;


            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);


        }
        public bool eliminar(alumnosBLL oAlumnosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("DELETE FROM tablaAlumnos WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oAlumnosBLL.ID;
            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);
        }
        public bool modificar(alumnosBLL oAlumnosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE tablaAlumnos SET id=@ID, Escuela=@escuela, Año=@año, Nombre=@nombre, Apellido=@apellido, Materia=@materia, Nota=@nota, Foto@foto WHERE ID=@ID");

            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@escuela", SqlDbType.VarChar).Value = oAlumnosBLL.Escuela;
            SQLComando.Parameters.Add("@año", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@materia", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@nota", SqlDbType.VarChar).Value = oAlumnosBLL.ID;
            SQLComando.Parameters.Add("@foto", SqlDbType.Image).Value = oAlumnosBLL.ID;


            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);

        }

        public DataSet mostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM tablaAlumnos");

            return conexion.ejecutarSentencia(sentencia);
        }

    }
}

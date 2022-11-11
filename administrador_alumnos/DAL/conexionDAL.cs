using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administrador_alumnos.DAL
{   
    class conexionDAL
    {
        private string CadenaConexion = "Data Source=DESKTOP-645SDJJ\\SQLEXPRESS; Initial Catalog=dbAlumnos; Integrated Security = True";
        SqlConnection Conexion;

        public SqlConnection establecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }
        /*metodo  INSERT, DELETE, UPDATE */
        
        /*sobre carga INSERT, DELETE, UPDATE */
        public bool ejecutarComandoSinRetornoDatos(SqlCommand SQLComando)
        {
            try
            {
                SqlCommand comando = SQLComando;
                comando.Connection = this.establecerConexion();
                Conexion.Open();
                comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {

                return false;
            }
        }

        /* SELECT (retorno de datos)*/
        public DataSet ejecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = establecerConexion();
                Adaptador.SelectCommand = Comando;
                Conexion.Open();
                Adaptador.Fill(DS);
                Conexion.Close();
                return DS;

            }
            catch
            {
                return DS;
            }
        }

    }
}

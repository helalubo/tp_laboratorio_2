using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AccesoDatos
    {

        #region Atributos

        private SqlConnection conexion;
        private SqlCommand comando;

        #endregion

        #region Constructor
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.ProductosBD);
            this.comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = this.conexion;
           
        }

        #endregion


        #region Atributos

        public SqlConnection Conexion
        {
            get
            {
                return this.conexion;
            }

        }

        public SqlCommand Comando
        {
            get
            {
                return this.comando ;
            }

        }

        #endregion






    }
}

using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Data.SqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace SistemaVenta
{
    internal class ConexionBD
    {
        //Campo de conexión
        private MySqlConnection conexion;

        //Cadena de conexión a MySQL local (XAMPP)
        private string cadenaConexion = "Server=localhost;Port=3306;Database=bdclientes;Uid=root;Pwd=;";


        //Método para abrir la conexión
        public MySqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new MySqlConnection(cadenaConexion);

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        //Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}

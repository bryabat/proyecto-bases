using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyecto1
{
    public class conexion2v
    {
        private String Servidor, BaseDeDatos, ID, Con;
        MySqlConnection conectar;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public conexion2v(String Servidor, String BaseDeDatos, String ID, String Con)
        {
            this.Servidor = Servidor;
            this.BaseDeDatos = BaseDeDatos;
            this.ID = ID;
            this.Con = Con;
        }
        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conectar = new MySqlConnection("server=" + Servidor + ";" + "database= " + BaseDeDatos + ";" + "Uid=" + ID + ";" + "pwd=" + Con + ";");
                return conectar;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectarse a la base de datos", ex);
            }
        }
    }
}

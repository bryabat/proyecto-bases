using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyecto1
{
   public class conexion
    {
        public static MySqlConnection ObtnerCOnexion()
        {
            MySqlConnection Conec = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
            Conec.Open();
            return Conec;
        }
        
    }
}

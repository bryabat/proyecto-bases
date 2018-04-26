using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace proyecto1
{
    public partial class clientes : Form
    {
        MySqlConnection Conexion3 = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public clientes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {try
            {
            string a = label2.Text;
            Conexion3.Open();
            MySqlCommand Guardar1 = new MySqlCommand("INSERT INTO clientes (NIT,nombre,apellido,direccion) VALUES('" + a + "','" + txtnombre.Text + "','" + textapellido.Text + "','" + txtdireccion.Text + "')", Conexion3);
            Guardar1.ExecuteNonQuery();
            Conexion3.Close();
            MessageBox.Show("nuevo cliente agregado correctamente");
            dato_a_pasar.pasar = null;
                this.Close();
            }
            catch { }
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            label2.Text = dato_a_pasar.pasar;
        }
    }
}

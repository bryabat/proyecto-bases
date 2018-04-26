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
    public partial class RegistroProductos : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        double costo;
        double iva;
        double ivadelprducto, precioconiva, ganacia, precio;

        public RegistroProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1grupo_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();
                MySqlCommand Guardar1 = new MySqlCommand("INSERT INTO productos (nombre,grupo,descripcion,modelo,marca,existencia,costo,iva,precio_con_iva,ganancia,precio,proveedor_id_proveedor) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +textBox5.Text+ "','" + textBox7.Text + "','" + costo + "','" + iva + "','" + precioconiva + "','" + ganacia + "','" + precio + "','" + textBox9.Text + "')", Conexion);
                Guardar1.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Producto agregado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            //aqui los proveedores
            Conexion.Open();
            MySqlDataAdapter mostrar = new MySqlDataAdapter("select proveedor.id_proveedor,proveedor.nombre,proveedor.apellido,proveedor.telefono from proveedor;", Conexion);
            DataTable producto = new DataTable();
            mostrar.Fill(producto);
            dataGridView1.DataSource = producto;
            Conexion.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cadena;
           
            costo= Convert.ToDouble(textBox6.Text);
            iva = Convert.ToDouble(textBox8.Text);
            iva = iva / 100;
            ivadelprducto = costo * iva;
            precioconiva = ivadelprducto + costo;
            ganacia = precioconiva * 0.30;
            precio = ganacia + ivadelprducto + costo;

            cadena = Convert.ToString(precio);
            label6.Text = cadena;
            cadena = Convert.ToString(ganacia);
            label7.Text = cadena;
            cadena = Convert.ToString(precioconiva);
            label4.Text = cadena;


        }
    }
}
  
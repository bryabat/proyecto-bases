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
using Microsoft.VisualBasic;

namespace proyecto1
{
    public partial class Venta : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        MySqlConnection Conexion2 = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        String nit;
        double a, b, c;
        string cad;
        string nitventa, idusuario;
        public Venta()
        {
            InitializeComponent();

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            Conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT max(id_factura) from factura;", Conexion);
            int count = (int)cmd.ExecuteScalar();

            lblNoFact.Text = Convert.ToString(count);
            Conexion.Close();




            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();

            c1.HeaderText = "Cantidad";
            c1.Width = 200;
            c1.ReadOnly = true;
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();

            c2.HeaderText = "Nombre";
            c2.Width = 200;
            c2.ReadOnly = true;
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Precio";
            c3.Width = 200;
            c3.ReadOnly = true;
            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "total";
            c4.Width = 200;
            c4.ReadOnly = true;

            dataGridView1.Columns.Add(c1);
            dataGridView1.Columns.Add(c2);
            dataGridView1.Columns.Add(c3);
            dataGridView1.Columns.Add(c4);






        }

        private void buttonRealizarVenta_Click(object sender, EventArgs e)
        {
            dato_a_pasar.pasar = txtNit.Text;
            try
            {

                checkBox1.Checked = false;
                txtNit.Enabled = true;
                Conexion.Open();
                MySqlCommand Buscar1 = new MySqlCommand("SELECT clientes.NIT  FROM clientes WHERE NIT ='" + txtNit.Text + "'", Conexion);
                MySqlDataReader leer = Buscar1.ExecuteReader();
                if (leer.Read())

                {

                    nit = txtNit.Text;
                    string nom = "";
                    Conexion2.Open();
                    // string consulta = ("SELECT clientes.nombre from clientes where NIT = '" + nit+ "' limit 1;");
                    MySqlCommand nombr = new MySqlCommand("SELECT clientes.nombre from clientes where NIT = '" + nit + "' limit 1;", Conexion2);
                    MySqlDataReader resultado = nombr.ExecuteReader();
                    while (resultado.Read())
                    {
                        nom = Convert.ToString(resultado[0]);

                    }
                    Conexion2.Close();

                    //##############################################
                    Conexion2.Open();
                    MySqlCommand dire = new MySqlCommand("SELECT clientes.direccion from clientes where NIT = '" + nit + "' limit 1;", Conexion2);
                    MySqlDataReader resultado2 = dire.ExecuteReader();
                    while (resultado2.Read())
                    {
                        txtDir.Text = Convert.ToString(resultado2[0]);

                    }
                    Conexion2.Close();
                    //#################################################
                    //##############################################
                    Conexion2.Open();
                    string apes = "";
                    MySqlCommand ape = new MySqlCommand("SELECT clientes.apellido from clientes where NIT = '" + nit + "' limit 1;", Conexion2);
                    MySqlDataReader resultape = ape.ExecuteReader();
                    while (resultape.Read())
                    {
                        apes = Convert.ToString(resultape[0]);

                    }
                    Conexion2.Close();
                    txtNombre.Text = nom + " " + apes;

                    dataGridView1.Visible = true;

                    txtNit.Text = nit;
                    checkBox1.Visible = false;
                    Conexion.Close();
                }
                else
                {


                    DialogResult result = MessageBox.Show("CLIENTE NUEVO", "AVISO", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        clientes nc = new clientes();
                        nc.Show();
                        Conexion.Close();
                        Conexion2.Close();
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show("Error en " + ex); }

            // txtNit.Text = "";
            // txtNit.Text = nit;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            buscarprocutoparaventa form = new buscarprocutoparaventa();
            form.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("al contado ?", "AVISO", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    double total;
            string fecha;

            total = float.Parse(label16.Text);
            fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            //#######cliente#########
            Conexion2.Open();
            MySqlCommand dire44 = new MySqlCommand("SELECT clientes.id_cliente from clientes where NIT = '" + txtNit.Text + "' limit 1;", Conexion2);
            MySqlDataReader resultado2 = dire44.ExecuteReader();
            while (resultado2.Read())
            {
                nitventa = Convert.ToString(resultado2[0]);

            }
            Conexion2.Close();
            //#######################
            //########usuarioventa###
            Conexion2.Open();
            MySqlCommand dire445 = new MySqlCommand("SELECT usuario.id_usuario from usuario where usuario.nombre_usuario= '" + BUSQUEDAFACTURA.usuarioventa + "' limit 1;", Conexion2);
            MySqlDataReader resultado23 = dire445.ExecuteReader();
            while (resultado23.Read())
            {
                idusuario = Convert.ToString(resultado23[0]);

            }
            Conexion2.Close();




            //#######################

            Conexion.Open();

            MySqlCommand Actualizar = new MySqlCommand("UPDATE factura SET total_Venta='" + total + "', fecha ='" + "2018-12-12" + "', usuario_id_usuario ='" + idusuario + "', clientes_id_cliente='" + nitventa + "', tipo_id='" + 2 + "', saldo='" + 0 + "' WHERE id_factura= '" + lblNoFact.Text + "'", Conexion);

            Actualizar.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("venta realizada");
            txtNit.Text = "";
            txtNombre.Text = "";
            txtDir.Text = "";

            this.Close();
           }
                else {

                    double total;
                    string fecha;
                    string numeroavendertxt;
                    int cuotas;

                    numeroavendertxt = Interaction.InputBox("Nunero de cuotas", "CANTIDAD", "0", 1, 100);
                    cuotas = Convert.ToInt32(numeroavendertxt);


                    total = float.Parse(label16.Text);
                    fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                    //#######cliente#########
                    Conexion2.Open();
                    MySqlCommand dire44 = new MySqlCommand("SELECT clientes.id_cliente from clientes where NIT = '" + txtNit.Text + "' limit 1;", Conexion2);
                    MySqlDataReader resultado2 = dire44.ExecuteReader();
                    while (resultado2.Read())
                    {
                        nitventa = Convert.ToString(resultado2[0]);

                    }
                    Conexion2.Close();
                    //#######################
                    //########usuarioventa###
                    Conexion2.Open();
                    MySqlCommand dire445 = new MySqlCommand("SELECT usuario.id_usuario from usuario where usuario.nombre_usuario= '" + BUSQUEDAFACTURA.usuarioventa + "' limit 1;", Conexion2);
                    MySqlDataReader resultado23 = dire445.ExecuteReader();
                    while (resultado23.Read())
                    {
                        idusuario = Convert.ToString(resultado23[0]);

                    }
                    Conexion2.Close();


                    //##pagos##
                    Conexion.Open();
                    MySqlCommand us = new MySqlCommand("INSERT INTO pagos(fecha,saldo,cuotas,abono,clientes_id_cliente,usuario_id_usuario) VALUES('" + "2018-12-12" + "','" + total + "','" + cuotas + "','" + 0 + "','" + nitventa + "','" + idusuario + "')", Conexion);
                    us.ExecuteNonQuery();
                    Conexion.Close();
                    //#########

                    //#######################

                    Conexion.Open();

                    MySqlCommand Actualizar = new MySqlCommand("UPDATE factura SET total_Venta='" + total + "', fecha ='" + "2018-12-12" + "', usuario_id_usuario ='" + idusuario + "', clientes_id_cliente='" + nitventa + "', tipo_id='" + 1 + "', saldo='" + total + "' WHERE id_factura= '" + lblNoFact.Text + "'", Conexion);

                    Actualizar.ExecuteNonQuery();
                    Conexion.Close();

                    Conexion.Open();
                    MySqlCommand ccmd = new MySqlCommand("SELECT max(idpagos) from pagos;", Conexion);
                    int idnumeropago = (int)ccmd.ExecuteScalar();
                    Conexion.Close();

                    Conexion.Open();
                    MySqlCommand us2 = new MySqlCommand("INSERT INTO pagos_de_factura(factura_id_factura,pagos_idpagos,saldo) VALUES('" + lblNoFact.Text + "','" + idnumeropago + "','" + 0 + "')", Conexion);
                    us2.ExecuteNonQuery();
                    Conexion.Close();
                    MessageBox.Show("venta realizada");
                    txtNit.Text = "";
                    txtNombre.Text = "";
                    txtDir.Text = "";
                    dataGridView1.Rows.Clear();

                    this.Close();





                }
            }
            catch
            {
                MessageBox.Show("error al vender");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Add(BUSQUEDAFACTURA.cantidadvender, BUSQUEDAFACTURA.nombre, BUSQUEDAFACTURA.precio,BUSQUEDAFACTURA.subtotal);
            // BUSQUEDAFACTURA.subtotal =0.0;
            a = BUSQUEDAFACTURA.subtotal;
            c = c + a;
            cad = Convert.ToString(c);
            label16.Text = cad;

            string NOFACT = lblNoFact.Text;

            //##################


            Conexion.Open();
            MySqlCommand Guardar1 = new MySqlCommand("INSERT INTO detalle_de_factura (cantidad,precioVenta,id_producto,id_factura_venta) VALUES('" + BUSQUEDAFACTURA.cantidadvender + "','" + BUSQUEDAFACTURA.precio + "','" + BUSQUEDAFACTURA.idproduc + "','" + NOFACT + "')", Conexion);
            Guardar1.ExecuteNonQuery();
            Conexion.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            anuladologin nc = new anuladologin();
            nc.Show();
            Conexion.Close();
            Conexion2.Close();
        }
    }
}

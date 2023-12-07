using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Espacio de nombres requerido para interactuar con Sql Server
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    public partial class Productos : Form
    {
        //Instancias
        //Conexion objeto del tipo SqlConnection para conectarnos fisicamente a la base de datos
        SqlConnection Conexion = new SqlConnection();
        //Comando objeto del tipo SqlCommand para representar instrucciones SQL
        SqlCommand Comando;
        //Adaptador objeto del tipo SqlDataAdapter para para intercambiar datos entre una
        // fuente de datos (en este caso Sql Server) y un alamacen de datos (DataSet, DataTable,DataReader)
        SqlDataAdapter Adaptador = null;
        //Tabla objeto del tipo DataTable representa una colección de registros en memoria del cliente
        DataTable Tabla = new DataTable();
        //Variables
        String Sql = ""; //Variable de tipo String para almacenar instrucciones SQL
        //Variable de tipo String para almacenar el nombre de la Instancia SQLServer
        String Servidor = @"DESKTOP-B6V8FPG\SQLEXPRESS";
        //Variable de tipo String para almacenar el nombre de la base de datos
        String Base_Datos = "bdPrograVisualFinal";
        //Metodo Conectar *********************************************************************
        void Conectar()
        {
            try
            {
                //Para establecer la conexion con el servidor debemos usar el objeto Conexion
                //especificando a traves de su propiedad ConnectionString el nombre del servidor, la bases de datos
                //y el timpo de seguridad
                Conexion.ConnectionString = "Data Source=" + Servidor + ";" +
                "Initial Catalog=" + Base_Datos + ";" +
                "Integrated security=true";
                try
                //Bloque try catch para captura de excepciones en ejecución
                {
                    Conexion.Open(); //Abrimos la conexión
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al tratar de establecer la conexión " + ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message);
            }
        }


        public Productos()
        {
            InitializeComponent();
            Conectar();
            Sql = "Select * From Productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(Sql, Conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            Conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conectar();
            //Instrucción SQL
            Sql = "insert into Productos(Producto, Numero_De_Serie, Modelo, Descripcion, Cantidad, Precio" +
            ")values(@Producto,@Numero_De_Serie,@Modelo,@Descripcion,@Cantidad,@Precio)";
            //Pasamos al objeto comando la instrucción SQL a ejecutar y el objeto Conexion
            Comando = new SqlCommand(Sql, Conexion);
            Comando.Parameters.AddWithValue("@Producto", textProducto.Text);
            Comando.Parameters.AddWithValue("@Numero_De_Serie", textSerie.Text);
            Comando.Parameters.AddWithValue("@Modelo", textModelo.Text);
            Comando.Parameters.AddWithValue("@Descripcion", textDescripcion.Text);
            Comando.Parameters.AddWithValue("@Cantidad", textCantidad.Text);
            Comando.Parameters.AddWithValue("@Precio", textPrecio.Text);
            try //Bloque try catch para captura de exepciones en ejecución
            {
                Comando.ExecuteNonQuery(); //Ejecutamos la instrucción SQL
                MessageBox.Show("Registro insertado");
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Conexion.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

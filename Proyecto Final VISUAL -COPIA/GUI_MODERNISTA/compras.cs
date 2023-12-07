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
    public partial class compras : Form
    {
        //Instancias
        //Conexion objeto del tipo SqlConnection para conectarnos fisicamente a la base de datos
        SqlConnection Conexion = new SqlConnection();
        //Comando objeto del tipo SqlCommand para representar instrucciones SQL
        SqlCommand Comando;
        SqlCommand Comando2;
        SqlCommand Comando3;
        SqlCommand Comando4;
        SqlCommand Comando5;
        //Adaptador objeto del tipo SqlDataAdapter para para intercambiar datos entre una
        // fuente de datos (en este caso Sql Server) y un alamacen de datos (DataSet, DataTable,DataReader)
        SqlDataAdapter Adaptador = null;
        //Tabla objeto del tipo DataTable representa una colección de registros en memoria del cliente
        DataTable Tabla = new DataTable();

        int indice = 0;
        //Variables
        String Sql = ""; //Variable de tipo String para almacenar instrucciones SQL
        String Sql1 = "";
        String Sql2 = ""; //Variable de tipo String para almacenar instrucciones SQL
        String Sql3 = "";
        String Sql4 = "";
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

        public compras()
        {
            InitializeComponent();
            Conectar();
            //Cargamos el objeto tabla con todos los registros de la tala estudiantes
            Sql = "select ID,Nombre from Clientes";
            Sql1 = "select ID,Producto from Productos";
            Adaptador = new SqlDataAdapter(Sql, Conexion);

            SqlCommand comando = new SqlCommand(Sql,Conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while(lector.Read()) {

                comboNombre.Items.Add(lector.GetString(1));
            }
            Conexion.Close();
            Conectar();
            SqlCommand comando1 = new SqlCommand(Sql1, Conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {

                comboProducto.Items.Add(lector1.GetString(1));
            }
            Conexion.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Conectar();
            //Instrucción SQL
            Sql = "insert into Compra(ID_Cliente, Nombre, Producto, Precio_Unitario, Cantidad, Precio_Total" +
            ")values(@ID_Cliente,@Nombre,@Producto,@Precio_Unitario,@Cantidad,@Precio_Total)";
            Sql1 = "Select ID from Clientes WHERE Nombre = @Nombre";
            Sql2 = "Select Precio from Productos WHERE Producto = @Producto";
            //Pasamos al objeto comando la instrucción SQL a ejecutar y el objeto Conexion
            Comando = new SqlCommand(Sql, Conexion);
            Comando2 = new SqlCommand(Sql1, Conexion);
            Comando2.Parameters.AddWithValue("@Nombre", comboNombre.Text);
            int idCliente = Convert.ToInt32(Comando2.ExecuteScalar());

            Comando3 = new SqlCommand(Sql2, Conexion);
            Comando3.Parameters.AddWithValue("@Producto", comboProducto.Text);
            int precio = Convert.ToInt32(Comando3.ExecuteScalar());

            Comando.Parameters.AddWithValue("@ID_Cliente", idCliente);
            Comando.Parameters.AddWithValue("@Nombre", comboNombre.Text);
            Comando.Parameters.AddWithValue("@Producto", comboProducto.Text);
            Comando.Parameters.AddWithValue("@Precio_Unitario", precio);
            Comando.Parameters.AddWithValue("@Cantidad", textCantidad.Text);
            string cantidadTexto = textCantidad.Text;
            int cantidad = Convert.ToInt32(cantidadTexto);
            int total = cantidad * precio;
            Comando.Parameters.AddWithValue("@Precio_Total", total);
            try //Bloque try catch para captura de exepciones en ejecución
            {
                Comando.ExecuteNonQuery(); //Ejecutamos la instrucción SQL
                MessageBox.Show("Compra Realizada");

                Sql3 = "Select Cantidad from Productos WHERE Producto=@Producto";
                Comando4 = new SqlCommand(Sql3, Conexion);
                Comando4.Parameters.AddWithValue("@Producto", comboProducto.Text);
                int Cantidad = Convert.ToInt32(Comando4.ExecuteScalar());
                int nuevaCantidad = Cantidad - cantidad;

                Sql4 = "update Productos set Cantidad=@Cantidad WHERE Producto=@Producto";
                Comando5 = new SqlCommand(Sql4, Conexion);
                Comando5.Parameters.AddWithValue("@Producto", comboProducto.Text);
                Comando5.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Conexion.Close();
            }
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }
    }
}

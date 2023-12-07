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
    public partial class EditarProductos : Form
    {

        //Instancias
        //Conexion objeto del tipo SqlConnection para conectarnos fisicamente a la base de datos
        SqlConnection Conexion = new SqlConnection();
        //Comando objeto del tipo SqlCommand para representar instrucciones SQL
        SqlCommand Comando;
        //Adaptador objeto del tipo SqlDataAdapter para para intercambiar datos entre una
        // fuente de datos (en este caso Sql Server) y un alamacen de datos (DataSet, DataTable,DataReader)
        SqlDataAdapter Adaptador=null;
        //Tabla objeto del tipo DataTable representa una colección de registros en memoria del cliente
        DataTable Tabla = new DataTable();
        //Variables
        String Sql=""; //Variable de tipo String para almacenar instrucciones SQL
        //Variable de tipo String para almacenar el nombre de la Instancia SQLServer
        String Servidor = @"DESKTOP-B6V8FPG\SQLEXPRESS";
        //Variable de tipo String para almacenar el nombre de la base de datos
        String Base_Datos = "bdPrograVisualFinal";
        int indice=0;
        //Metodo Conectar *********************************************************************
        void Conectar()
        {
            try
            {
                //Para establecer la conexion con el servidor debemos usar el objeto Conexion
                //especificando a traves de su propiedad ConnectionString el nombre del servidor, la bases de datos
                //y el timpo de seguridad
                Conexion.ConnectionString="Data Source="+Servidor+";" +
                "Initial Catalog="+Base_Datos+";"+
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
                MessageBox.Show("Error en la conexión: "+ex.Message);
            }
        }

        //Este método recibe como parámetro un índice correspondiente al registro a cargar
        void CargarDatos(int indice)
        {
            if (Tabla.Rows.Count > 0) //Si el objeto Tabla posee registros procedemos a realizar la asignación
            {
                DataRow fila = Tabla.Rows[indice]; //Creamos una fila del Objeto Tabla
                //Asignamos los valores correspondientes a cada registro
                textID.Text = fila["ID"].ToString();
                textProducto.Text = fila["Producto"].ToString();
                textSerie.Text = fila["Numero_De_Serie"].ToString();
                textModelo.Text = fila["Modelo"].ToString();
                textDescripcion.Text = fila["Descripcion"].ToString();
                textCantidad.Text = fila["Cantidad"].ToString();
                textPrecio.Text = fila["Precio"].ToString();
            }
            else
            {
                MessageBox.Show("No hay registros para mostrar");
            }
        }
        //Metodo para refrescar el DataTable despues de insertar,modificar o eliminar registros
        void RefrescarDatos()
        {
            //seleccionamos todos los datos de la tabla personal
            Sql = "select * from Productos";
            Adaptador = new SqlDataAdapter(Sql, Conexion); //pasamos los parametros al adaptador
            Tabla.Clear(); //limpiamos antes de llenar el objeto oTabla
            Adaptador.Fill(Tabla); //llenamos la tabla
        }

        public EditarProductos()
        {
            InitializeComponent();
            Conectar();
            //Cargamos el objeto tabla con todos los registros de la tala estudiantes
            Sql = "select * from Productos";
            Adaptador = new SqlDataAdapter(Sql, Conexion);
            Adaptador.Fill(Tabla);
            //Llmamos el metodo CargarDatos para tan pronto se lance el formulario asigne
            //a las cajas de texto los valores correspondientes al primer registro de la tabla
            CargarDatos(indice);

            SqlDataAdapter adaptador = new SqlDataAdapter(Sql, Conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            Conexion.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Conectar();
            indice = 0;
            CargarDatos(indice);
            Conexion.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Conectar();
            if (indice < Tabla.Rows.Count - 1)
            {
                indice = indice + 1;
                CargarDatos(indice);
            }
            Conexion.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Conectar();
            if (Tabla.Rows.Count > 0 && indice > 0)
            {
                indice = indice - 1;
                CargarDatos(indice);
            }
            Conexion.Close();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Conectar();
            if (Tabla.Rows.Count > 0)
            {
                indice = Tabla.Rows.Count - 1;
                CargarDatos(indice);
            }
            Conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conectar();
            Sql = "update Productos set Producto=@Producto, Numero_De_Serie=@Numero_De_Serie, Modelo=@Modelo, Descripcion=@Descripcion, Cantidad=@Cantidad, Precio=@Precio where ID=@ID";
            Comando = new SqlCommand(Sql, Conexion);
            Comando.Parameters.AddWithValue("@ID", textID.Text);
            Comando.Parameters.AddWithValue("@Producto", textProducto.Text);
            Comando.Parameters.AddWithValue("@Numero_De_Serie", textSerie.Text);
            Comando.Parameters.AddWithValue("@Modelo", textModelo.Text);
            Comando.Parameters.AddWithValue("@Descripcion", textDescripcion.Text);
            Comando.Parameters.AddWithValue("@Cantidad", textCantidad.Text);
            Comando.Parameters.AddWithValue("@Precio", textPrecio.Text);
            try //Bloque try catch para captura de excepciones en ejecución
            {
                Comando.ExecuteNonQuery();
                MessageBox.Show("Registro editado");
                RefrescarDatos();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Conexion.Close();
            }
            Conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conectar();
            Sql = "delete from Productos where ID=@ID";
            Comando = new SqlCommand(Sql, Conexion);
            Comando.Parameters.AddWithValue("@ID", textID.Text);
            try
            //Bloque try catch para captura de excepciones en ejecución
            {
                Comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                RefrescarDatos();
                Conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Conexion.Close();
            }
            Conexion.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textProducto.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textSerie.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textModelo.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textDescripcion.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textCantidad.Text = dataGridView1.SelectedCells[5].Value.ToString();
            textPrecio.Text = dataGridView1.SelectedCells[6].Value.ToString();
        }
    }
}

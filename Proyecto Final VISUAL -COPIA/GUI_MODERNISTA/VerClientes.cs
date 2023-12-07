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
    public partial class VerClientes : Form
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
        int indice = 0;
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

        //Este método recibe como parámetro un índice correspondiente al registro a cargar
        void CargarDatos(int indice)
        {
            if (Tabla.Rows.Count > 0) //Si el objeto Tabla posee registros procedemos a realizar la asignación
            {
                DataRow fila = Tabla.Rows[indice]; //Creamos una fila del Objeto Tabla
                //Asignamos los valores correspondientes a cada registro
                textID.Text = fila["ID"].ToString();
                textNombre.Text = fila["Nombre"].ToString();
                textPaterno.Text = fila["Apellido_Paterno"].ToString();
                textMaterno.Text = fila["Apellido_Materno"].ToString();
                textTel.Text = fila["Telefono"].ToString();
                textDireccion.Text = fila["Direccion"].ToString();
                comboGenero.Text = fila["Genero"].ToString();
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

        public VerClientes()
        {
            InitializeComponent();
            Conectar();
            //Cargamos el objeto tabla con todos los registros de la tala estudiantes
            Sql = "select * from Clientes";
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
            Sql = "update Clientes set Nombre=@Nombre, Apellido_Paterno=@Apellido_Paterno, Apellido_Materno=@Apellido_Materno, Telefono=@Telefono, Direccion=@Direccion, Genero=@Genero where ID=@ID";
            Comando = new SqlCommand(Sql, Conexion);
            Comando.Parameters.AddWithValue("@ID", textID.Text);
            Comando.Parameters.AddWithValue("@Nombre", textNombre.Text);
            Comando.Parameters.AddWithValue("@Apellido_Paterno", textPaterno.Text);
            Comando.Parameters.AddWithValue("@Apellido_Materno", textMaterno.Text);
            Comando.Parameters.AddWithValue("@Telefono", textTel.Text);
            Comando.Parameters.AddWithValue("@Direccion", textDireccion.Text);
            Comando.Parameters.AddWithValue("@Genero", comboGenero.Text);
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
            Sql = "delete from Clientes where ID=@ID";
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
            
     
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textPaterno.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textMaterno.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textTel.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textDireccion.Text = dataGridView1.SelectedCells[5].Value.ToString();
            comboGenero.Text = dataGridView1.SelectedCells[6].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textPaterno.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textMaterno.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textTel.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textDireccion.Text = dataGridView1.SelectedCells[5].Value.ToString();
            comboGenero.Text = dataGridView1.SelectedCells[6].Value.ToString();
        }
    }
}

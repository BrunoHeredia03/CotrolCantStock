using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;


namespace proyecto1_lab3
{
	public partial class Form1 : Form
	{
		private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BdStock\DbStock1.accdb";
		private OleDbConnection conexion = new OleDbConnection();

		private OleDbCommand comando = new OleDbCommand();
		 
		private OleDbDataAdapter adaptador = new OleDbDataAdapter();
		private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BdStock\DbStock1.accdb";
		
			public Form1()
			{
				InitializeComponent();
				ProbarConexion();
			
			}


		private void Form1_Load(object sender, EventArgs e)
		{
			cmbCategoria.Items.Clear();
			cmbCategoria.Items.Add("Prueba");

			CargarProductos();
		}



		//Conexion y Prueba de conexion 
		public void conexiones()
			{
				//recibe la cadena de conexion
				conexion.ConnectionString = cadenaConexion;
				conexion.Open();

				// Asocia el comando SQL a la conexión y define el tipo de comando (SQL)
				comando.Connection = conexion;
				comando.CommandType = CommandType.Text;

			}
			public void ProbarConexion()
			{
				try
				{
					// Configurar la cadena de conexión
					conexion.ConnectionString = cadenaConexion;
					conexion.Open();
					MessageBox.Show("Conexión a la base de datos exitosa.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
				}
				finally
				{
					// Cerrar la conexión si está abierta
					if (conexion.State == ConnectionState.Open)
					{
						conexion.Close();
					}
				}
			}

			private void button2_Click(object sender, EventArgs e)
			{

			using (OleDbConnection conexion = new OleDbConnection(connectionString))
			{
				try
				{
					string consulta = "INSERT INTO Tabla2 (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES (@codigo, @nombre, @descripcion, @precio, @stock, @categoria)";
					OleDbCommand comando = new OleDbCommand(consulta, conexion);

					comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
					comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
					comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
					comando.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
					comando.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
					comando.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedItem.ToString());

					conexion.Open();
					comando.ExecuteNonQuery();
					conexion.Close();

					
					CargarProductos();
					VerificarStockBajo();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al insertar el producto: " + ex.Message);
				}
			}


		}
			private void CargarProductos()

		{
			try
			{
				// Reinicia el DataSource del DataGridView antes de cargar nuevos datos
				dataGridViewProductos.DataSource = null;

				// Usamos la conexión en un bloque using para asegurar su correcto cierre
				using (OleDbConnection conexion = new OleDbConnection(connectionString))
				{
					conexion.Open();

					// Consulta SQL para obtener los productos
					string consulta = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, Categoria FROM Tabla2";

					// Usamos un bloque using para el adaptador
					using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
					{
						// Crear un DataSet para almacenar los datos
						DataSet ds = new DataSet();

						// Llenar el DataSet con los datos obtenidos
						adaptador.Fill(ds, "Tabla2");

						// Configuramos el DataGridView con los datos del DataSet
						dataGridViewProductos.DataSource = ds.Tables["Tabla2"];
					}

					// Ajustamos el tamaño de las columnas automáticamente
					dataGridViewProductos.AutoResizeColumns();

					// Configuramos algunas propiedades del DataGridView si es necesario
					dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					dataGridViewProductos.AllowUserToAddRows = false;  // No permitir filas vacías
				}
			}
			catch (OleDbException dbEx)
			{
				// Error relacionado con la base de datos (conexión o consulta)
				MessageBox.Show("Error al acceder a la base de datos: " + dbEx.Message);
			}
			catch (Exception ex)
			{
				// Otro tipo de error (general)
				MessageBox.Show("Error al cargar los productos: " + ex.Message);
			}
		}





		//00000000000000000000000000000000000000000000000000000000000000000000000000000000000


		//0101010101010101010111111111111111111111111111111111111111111111111111111111111111


		private void btnmodificar_Click(object sender, EventArgs e)
		{

			if (dataGridViewProductos.SelectedRows.Count > 0)
			{
				string codigo = dataGridViewProductos.SelectedRows[0].Cells["Codigo"].Value.ToString();

				using (OleDbConnection conexion = new OleDbConnection(connectionString))
				{
					string consulta = "UPDATE Tabla2 SET Nombre=@nombre, Descripcion=@descripcion, Precio=@precio, Stock=@stock, Categoria=@categoria WHERE Codigo=@codigo";
					OleDbCommand comando = new OleDbCommand(consulta, conexion);

					comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
					comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
					comando.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
					comando.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
					comando.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedItem.ToString());
					comando.Parameters.AddWithValue("@codigo", codigo);

					conexion.Open();
					comando.ExecuteNonQuery();
					conexion.Close();

					CargarProductos(); // Refrescar el DataGridView
				}
			}
			else
			{
				MessageBox.Show("Seleccione un producto a modificar");
			}
		}

		//}

		private void btneliminar_Click(object sender, EventArgs e)
		{

			if (dataGridViewProductos.SelectedRows.Count > 0)
			{
				string codigo = dataGridViewProductos.SelectedRows[0].Cells["Codigo"].Value.ToString();

				using (OleDbConnection conexion = new OleDbConnection(connectionString))
				{
					string consulta = "DELETE FROM Tabla2 WHERE Codigo=@codigo";
					OleDbCommand comando = new OleDbCommand(consulta, conexion);
					comando.Parameters.AddWithValue("@codigo", codigo);

					conexion.Open();
					comando.ExecuteNonQuery();
					conexion.Close();

					CargarProductos(); // Refrescar el DataGridView
				}
			}
			else
			{
				MessageBox.Show("Seleccione un producto a eliminar");
			}
		}

		//}

		private void btnbuscar_Click(object sender, EventArgs e)
		{

			string consulta = "SELECT * FROM Productos WHERE 1=1"; // Inicialmente no tiene filtro

			if (!string.IsNullOrEmpty(txtNombre.Text))
				consulta += $" AND Nombre LIKE '%{txtNombre.Text}%'";

			if (!string.IsNullOrEmpty(txtCodigo.Text))
				consulta += $" AND Codigo LIKE '%{txtCodigo.Text}%'";

			if (cmbCategoria.SelectedItem != null)
				consulta += $" AND Categoria = '{cmbCategoria.SelectedItem.ToString()}'";

			dataGridViewProductos.DataSource = EjecutarConsulta(consulta); // Refrescar con los datos filtrados


		}

		private DataTable EjecutarConsulta(string consulta)
		{
			// Crear una tabla en la que se almacenarán los datos resultantes
			DataTable dt = new DataTable();

			try
			{
				// Usar la conexión con un bloque using para asegurar su correcto cierre
				using (OleDbConnection conexion = new OleDbConnection(connectionString))
				{
					// Abrir la conexión
					conexion.Open();

					// Crear un adaptador para ejecutar la consulta y llenar el DataTable
					using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
					{
						// Llenar el DataTable con los datos obtenidos de la consulta
						adaptador.Fill(dt);
					}
				}
			}
			catch (OleDbException dbEx)
			{
				MessageBox.Show("Error al ejecutar la consulta: " + dbEx.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message);
			}

			// Devolver la tabla llena con los datos
			return dt;
		}



		private void VerificarStockBajo()
		{
			string consulta = "SELECT * FROM Tabla2 WHERE Stock < 10";
			DataTable productosBajoStock = EjecutarConsulta(consulta);

			if (productosBajoStock.Rows.Count > 0)
			{
				lblAlerta.Text = "Producto con Stock bajo"; // Muestra un mensaje en la etiqueta
				MessageBox.Show("Verificar Producto! Cuenta con stock bajo.");
				lblAlerta.Visible = true;
			}
			else
			{
				lblAlerta.Visible = false;
			}
		}

		private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Eleccion(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnbuscar_Click_1(object sender, EventArgs e)
		
			
			{
				string consulta = "SELECT * FROM Tabla2 WHERE 1=1"; // Inicialmente no tiene filtro

				// Agregar filtros según los valores ingresados
				if (!string.IsNullOrEmpty(txtNombre.Text))
					consulta += $" AND Nombre LIKE '%{txtNombre.Text}%'";

				if (!string.IsNullOrEmpty(txtCodigo.Text))
					consulta += $" AND Codigo LIKE '%{txtCodigo.Text}%'";

				if (cmbCategoria.SelectedItem != null)
					consulta += $" AND Categoria = '{cmbCategoria.SelectedItem.ToString()}'";

				// Ejecutar la consulta y actualizar la grilla con los resultados
				dataGridViewProductos.DataSource = EjecutarConsulta(consulta); // Refrescar con los datos filtrados
			}

		}
	}




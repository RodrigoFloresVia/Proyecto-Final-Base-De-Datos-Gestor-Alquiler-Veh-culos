using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos_BD
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=gestorAlquilerVehiculos;User ID=root;";
        private string selectQuery = "SELECT * FROM Vehiculos;";
        private string insertQuery = "INSERT INTO Vehiculos (TipoVehiculo, Marca, Año, Placa, PrecioalquilerPorDia)" + " values (@TipoVehiculo, @Marca, @Año, @Placa, @PrecioalquilerPordia);";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvVehiculos.DataSource = dataTable;
                }
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos después de la inserción o modificación
            txtTipoVehiculo.Text = "";
            txtMarca.Text = "";
            txtAño.Text = "";
            txtPlaca.Text = "";
            txtPrecioAlquilerPorDia.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    // Asignar valores de los controles a los parámetros
                    insertCommand.Parameters.AddWithValue("@TipoVehiculo", txtTipoVehiculo.Text);
                    insertCommand.Parameters.AddWithValue("@Marca", txtMarca.Text);
                    insertCommand.Parameters.AddWithValue("@Año", Convert.ToInt32(txtAño.Text));
                    insertCommand.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    insertCommand.Parameters.AddWithValue("@PrecioalquilerPordia", Convert.ToDouble(txtPrecioAlquilerPorDia.Text));

                    // Ejecutar la consulta de inserción
                    insertCommand.ExecuteNonQuery();
                }
            }

            // Recargar los datos en el DataGridView
            CargarDatos();

            // Limpiar los campos después de la inserción
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                // Obtener el ID del vehículo seleccionado
                int idVehiculo = Convert.ToInt32(dgvVehiculos.SelectedRows[0].Cells["IdVehiculo"].Value);

                // Eliminar el registro en la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Vehiculos WHERE IdVehiculo = @IdVehiculo"; // Corregir el nombre de la columna aquí
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                // Recargar los datos en el DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el ID del vehículo seleccionado
                    int idVehiculo = Convert.ToInt32(dgvVehiculos.SelectedRows[0].Cells["IdVehiculo"].Value);

                    // Construir la consulta de actualización
                    string updateQuery = "UPDATE Vehiculos SET TipoVehiculo = @TipoVehiculo, Marca = @Marca, Año = @Año, Placa = @Placa, PrecioalquilerPorDia = @PrecioalquilerPorDia WHERE IdVehiculo = @IdVehiculo";

                    // Abrir la conexión y ejecutar la consulta de actualización
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            // Asignar valores de los controles a los parámetros
                            updateCommand.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                            updateCommand.Parameters.AddWithValue("@TipoVehiculo", txtTipoVehiculo.Text);
                            updateCommand.Parameters.AddWithValue("@Marca", txtMarca.Text);

                            // Verificar si la cadena es convertible a un entero para el año
                            if (int.TryParse(txtAño.Text, out int año))
                            {
                                updateCommand.Parameters.AddWithValue("@Año", año);
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese un año válido.");
                                return;
                            }

                            // Manejar la conversión del precio de alquiler por día
                            if (double.TryParse(txtPrecioAlquilerPorDia.Text, out double precio))
                            {
                                updateCommand.Parameters.AddWithValue("@PrecioalquilerPorDia", precio);
                            }
                            else
                            {
                                MessageBox.Show("El precio de alquiler por día ingresado no es válido.");
                                return;
                            }

                            updateCommand.Parameters.AddWithValue("@Placa", txtPlaca.Text);

                            // Ejecutar la consulta de actualización
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    // Recargar los datos en el DataGridView
                    CargarDatos();

                    // Limpiar los campos después de la modificación
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el vehículo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para modificar.");
            }
        }
    }
}

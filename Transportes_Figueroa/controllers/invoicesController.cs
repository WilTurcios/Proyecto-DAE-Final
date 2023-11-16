using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.Controllers
{
    internal class invoicesController
    {
        private SqlConnection connection = new SqlConnection();
        public invoicesController(string connectionString)
        {
            connection.ConnectionString = connectionString;
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public List<Invoice> GetAll()
        {
            List<Invoice> invoices = new List<Invoice>();

            try
            {
                OpenConnection();
                string query = $"SELECT * FROM facturas;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Invoice invoice = new Invoice();
                        invoice.Id = (int)reader["id_factura"];
                        invoice.NumeroFactura = (string)reader["num_factura"];
                        invoice.FechaFactura = (DateTime)reader["fecha_factura"];
                        invoice.MontoTotal = (decimal)reader["monto_total"];
                        invoice.ServicioId = (int)reader["id_servicio"];
                        invoice.EmpleadoId = (Guid)reader["id_empleado"];

                        invoices.Add(invoice);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al recuperar las facturas: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return invoices;
        }

        public int Add(Invoice invoice)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand("CrearFactura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ServicioID", invoice.ServicioId);
                    command.Parameters.AddWithValue("@EmpleadoID", invoice.EmpleadoId);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar la factura: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }


        public int Delete(int invoiceID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "delete from facturas where id_factura = @InvoiceID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InvoiceID", invoiceID);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la factura: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }
        public List<Invoice> GetInvoicesByClientId(Guid clienteID)
        {
            List<Invoice> invoices = new List<Invoice>();

            try
            {
                OpenConnection();
                string values = "F.id_factura, F.num_factura, F.fecha_factura, F.monto_total, F.id_servicio";
                string condition = "F.id_servicio = (SELECT S.id_servicio FROM servicios WHERE S.id_cliente = @ClienteID)";
                string query = $"SELECT {values} FROM facturas F WHERE {condition};";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Invoice invoice = new Invoice();
                        invoice.Id = (int)reader["id_factura"];
                        invoice.NumeroFactura = (string)reader["num_factura"];
                        invoice.FechaFactura = (DateTime)reader["fecha_factura"];
                        invoice.MontoTotal = (decimal)reader["monto_total"];
                        invoice.ServicioId = (int)reader["id_servicio"];
                        invoice.EmpleadoId = (Guid)reader["id_empleado"];

                        invoices.Add(invoice);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al recuperar las facturas del cliente: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return invoices;
        }

        public Invoice GetInvoiceByServiceID(int serviceID)
        {
            try
            {
                OpenConnection();
                Invoice invoice = new Invoice();
                string query = "select * from facturas where id_servicio = @ServiceID;";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ServiceID", serviceID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            invoice.Id = (int)reader["id_factura"];
                            invoice.FechaFactura = (DateTime)reader["fecha_factura"];
                            invoice.ServicioId = (int)reader["id_servicio"];
                            invoice.EmpleadoId = (Guid)reader["id_empleado"];
                            invoice.MontoTotal = (decimal)reader["monto_total"];
                            invoice.NumeroFactura = (string)reader["num_factura"];
                        }
                    }
                }

                return invoice;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al recuperar la factura: " + ex.Message);
                return new Invoice();
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

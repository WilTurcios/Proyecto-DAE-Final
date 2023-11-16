using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using System.IO;
using iText.Layout.Element;
using iText.Layout;

namespace Transportes_Figueroa.views
{
    public partial class PrevisualizacionFactura : Form
    {
        private Invoice _invoice;
        private Service _service;
        private Vehicle _vehicle;
        private string _serviceType;
        private string _clientName;
        private string _clientEmail;
        public PrevisualizacionFactura(Invoice insertedInvoice, Service service, Vehicle vehicle, string serviceType, string clientName, string clientEmail)
        {
            InitializeComponent();
            this._clientName = clientName;
            this._invoice = insertedInvoice;
            this._vehicle = vehicle;
            this._service = service;
            this._serviceType = serviceType;
            this._clientEmail = clientEmail;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrevisualizacionFactura_Load(object sender, EventArgs e)
        {
            txtCosto.Text = (_serviceType == "Transporte de cargas") ? "Costo por km recorrido:" : "Costo por hora:";
            txtValorMedido.Text = (_serviceType == "Transporte de cargas") ? "Km totales" : "Horas totales:";

            numeroFactura.Text = _invoice.NumeroFactura;
            FechaFactura.Text = _invoice.FechaFactura.Date.ToString();
            NombreCliente.Text = _clientName;
            NombreCliente.Text = _clientName;
            NombreCliente.Text = _clientName;
            TipoServicio.Text = _serviceType;
            Costo.Text = _vehicle.Costo.ToString("0.00");
            ValorMedido.Text = _service.ValorMedido.ToString("0.00");
            MontoTotal.Text = _invoice.MontoTotal.ToString("0.00");
        }

        private void btnEnviarFactura_Click(object sender, EventArgs e)
        {
            DialogResult sendMail = MessageBox.Show("Quieres que la factura sea enviada a tu correo electrónico", "Enviar factura por correo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sendMail == DialogResult.OK)
            {

                string rutaPdf = CrearArchivoFacturaPDF(
                            _invoice.NumeroFactura,
                            _serviceType,
                            _clientName,
                            _invoice.MontoTotal,
                            _invoice.FechaFactura,
                            _service.ValorMedido,
                            _vehicle.Costo
                        );

                EnviarFacturaPorCorreo(_clientEmail, rutaPdf);

            }
        }

        private void EnviarFacturaPorCorreo(string correoDestinatario, string rutaPdf)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.elasticemail.com"))
                {
                    smtpClient.Port = 2525;
                    smtpClient.Credentials = new NetworkCredential("wildev123456789@gmail.com", "CF12D1BADE0527F3DD87CEB6876309DF87F5");
                    smtpClient.EnableSsl = true;

                    using (MailMessage mensaje = new MailMessage())
                    {
                        mensaje.From = new MailAddress("wildev123456789@gmail.com");
                        mensaje.To.Add(correoDestinatario);
                        mensaje.Subject = "Factura";
                        mensaje.Body = "Adjunto encontrarás tu factura en formato PDF.";

                        string rutaArchivo = rutaPdf;

                        using (Attachment adjunto = new Attachment(rutaArchivo))
                        {
                            mensaje.Attachments.Add(adjunto);

                            smtpClient.Send(mensaje);
                        }
                    }

                    System.Threading.Thread.Sleep(1000);

                    File.Delete(rutaPdf);

                    MessageBox.Show("Factura enviada por correo electrónico correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la factura por correo electrónico: {ex.Message}");
            }
        }


        private string CrearArchivoFacturaPDF(string numeroFactura, string tipoServicio, string cliente, decimal monto, DateTime fechaFactura, double valorMedido, decimal costoVehiculo)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Factura.pdf");

            using (var writer = new PdfWriter(rutaArchivo))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    // Agregar contenido al PDF basado en los datos de la factura
                    document.Add(new Paragraph($"Factura #{numeroFactura}"));
                    document.Add(new Paragraph($"Fecha de factura #{fechaFactura.Date}"));
                    document.Add(new Paragraph($"Cliente: {cliente}"));
                    document.Add(new Paragraph($"Tipo de servicio solicitado: {tipoServicio}"));
                    document.Add(new Paragraph($"{(tipoServicio == "Transporte de cargas" ? "Costo por kilometro recorrido" : "Costo por hora")}: {costoVehiculo:C}"));
                    document.Add(new Paragraph($"{(tipoServicio == "Transporte de cargas" ? "Kilometros recorridos" : "Horas alquilado")}: {valorMedido:C}"));
                    document.Add(new Paragraph($"Total: {monto:C}"));
                }
            }

            return rutaArchivo;
        }
    }
}

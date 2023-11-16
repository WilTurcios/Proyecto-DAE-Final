using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;

namespace Transportes_Figueroa.views
{
    public partial class AdministrarFacturas : Form
    {
        private ServiceManager ServicesBD = new ServiceManager();
        private List<Invoice> _invoices = new List<Invoice>();
        public AdministrarFacturas()
        {
            InitializeComponent();
        }

        private void ShowInvoices(List<Invoice> invoices)
        {
            DataTable InvoicesToShow = new DataTable();
            InvoicesToShow.Columns.Clear();

            InvoicesToShow.Columns.Add("ID");
            InvoicesToShow.Columns.Add("Numero de factura");
            InvoicesToShow.Columns.Add("Fecha de factura");
            InvoicesToShow.Columns.Add("Monto Total");
            InvoicesToShow.Columns.Add("ID empleado");
            InvoicesToShow.Rows.Clear();

            foreach (Invoice invoice in invoices)
            {
                DataRow fila = InvoicesToShow.NewRow();

                fila["ID"] = invoice.Id;
                fila["Numero de factura"] = invoice.NumeroFactura;
                fila["Monto total"] = invoice.MontoTotal;
                fila["Fecha de factura"] = invoice.FechaFactura;
                fila["ID empleado"] = invoice.EmpleadoId;

                InvoicesToShow.Rows.Add(fila);

            }

            DataGridFaccturas.DataSource = InvoicesToShow;
            DataGridFaccturas.Refresh();
        }

        private void AdministrarFacturas_Load(object sender, EventArgs e)
        {
            _invoices = ServicesBD.GetAllInvoices();

            ShowInvoices(_invoices);

        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            bool alMenosUnaCeldaSeleccionada = false;

            foreach (DataGridViewRow row in DataGridFaccturas.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        alMenosUnaCeldaSeleccionada = true;

                        if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int invoiceID))
                        {
                            if (MessageBox.Show("¿Está seguro de que desea eliminar el vehiculo seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ServicesBD.DeleteInvoice(invoiceID);

                                _invoices = ServicesBD.GetAllInvoices();

                                ShowInvoices(_invoices);
                            }
                        }
                    }
                }
            }

            if (!alMenosUnaCeldaSeleccionada)
            {
                MessageBox.Show("Seleccione al menos una celda antes de eliminar un vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

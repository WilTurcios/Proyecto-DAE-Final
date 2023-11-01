using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.Models
{
    internal class Factura
    {
        public int Id { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }
        public int ServicioId { get; set; }
        public Guid EmpleadoId { get; set; }
    }
}

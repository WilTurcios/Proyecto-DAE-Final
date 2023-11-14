using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.Models
{
    internal class Service
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public double ValorMedido { get; set; }
        public int TipoServicioId { get; set; }
        public int VehiculoId { get; set; }
        public Guid ClienteId { get; set; }
        public int? ConductorID { get; set; } = null;
    }
}

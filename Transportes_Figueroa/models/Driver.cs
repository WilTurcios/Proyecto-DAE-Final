using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.Models
{
    internal class Driver
    {
        public int Id { get; set; }
        public Guid EmpleadoID { get; set; }
        public string Disponibilidad { get; set; }
    }
}

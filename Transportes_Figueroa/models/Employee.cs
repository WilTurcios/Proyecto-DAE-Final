using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.models
{
    internal class Employee
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public string CodigoAFP { get; set; }
        public string CodigoSeguro { get; set; }
        public byte[] Imagen { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Calle { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Ubicacion { get; set; }
        public string CodigoCasa { get; set; }
        public int RolId { get; set; }
        public string DUI { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Email { get; set; }
        public int DireccionId { get; set;}
        public string Calle { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Ubicacion { get; set; }
        public string CodigoCasa { get; set; }
        public string DUI { get; set; }
    }
}

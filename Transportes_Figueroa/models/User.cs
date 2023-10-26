using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Figueroa.Services;

namespace Transportes_Figueroa.models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Contrasenia { get; set; }
        public string Correo {  get; set; }
    }
}

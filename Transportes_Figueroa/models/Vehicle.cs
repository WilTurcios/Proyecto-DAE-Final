using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public double Kilometraje { get; set; }
        public int Anio { get; set; }
        public string Matricula { get; set; }
        public double CapacidadPeso { get; set; }
        public int CapacidadPersonas { get; set; }
        public double Costo { get; set; }
        public int TipoVehiculoId { get; set; }
        public int ModeloId {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._2
{
    public class Propietario
    {
        public int numeroDocumento { get; set; }

        public string Nombre { get; set; }

        public Propietario (int numeroDocumento, string nombre)
        {
            this.numeroDocumento = numeroDocumento;
            Nombre = nombre;
        }
    }
}

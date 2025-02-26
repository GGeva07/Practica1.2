using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._2
{
    public class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public Propietario Propietario { get; set; }

        public double Saldo { get; set; }

        public CuentaBancaria(int numeroCuenta, Propietario propietario, double saldo = 0)
        {
            NumeroCuenta = numeroCuenta;
            Propietario = propietario;
            Saldo = saldo;
        }
    }
}

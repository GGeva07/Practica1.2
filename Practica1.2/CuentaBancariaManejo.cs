using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._2
{
    public class CuentaBancariaManejo
    {
        public static void depositar(List<CuentaBancaria> Lista, int numeroCuenta, double monto)
        {
            CuentaBancaria NumCuenta = Lista.Find(cuenta => cuenta.NumeroCuenta == numeroCuenta);
            if (NumCuenta != null)
            {
                NumCuenta.Saldo += monto;
                Console.WriteLine($"Deposito realizado, nuevo saldo {NumCuenta.Saldo}");

            }
            else
            {
                Console.WriteLine("Ingresa un numero de cuenta valido por favor");
            }
        }

        public static void Retirar(List<CuentaBancaria> Lista, int numCuenta, double Monto)
        {
            CuentaBancaria NumCuenta = Lista.Find(cuenta => cuenta.NumeroCuenta == numCuenta);
            if (NumCuenta != null)
            {
                NumCuenta.Saldo -= Monto;
                Console.WriteLine($"Retiro realizado, nuevo saldo {NumCuenta.Saldo}");
            }
            else
            {
                Console.WriteLine("Ingresa un numero de cuenta valido por favor");
            }
        }

        public static void MostrarSaldo(List<CuentaBancaria> Lista, int NumCuenta)
        {
            CuentaBancaria cuenta = Lista.Find(c => c.NumeroCuenta == NumCuenta);
            if (cuenta != null)
            {
                Console.WriteLine($"Saldo de la cuenta: {cuenta.Saldo}");
            }
            else
            {
                Console.WriteLine("Ingresa un numero de cuenta valido por favor");
            }
        }
    }
}

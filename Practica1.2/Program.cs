namespace Practica1._2
{
    public class Program
    {
        public static List<CuentaBancaria> ListaCuentasBancarias = new List<CuentaBancaria>();
        static void Main(string[] args)
        {
            

            //Creamos objetos de cuenta bancaria para tener
            Propietario propietario1 = new Propietario( 402310, "Eva Gonzalez");
            CuentaBancaria cuenta1 = new CuentaBancaria(1234, propietario1, 500.50);

            Propietario propietario2 = new Propietario(50203, "Daniel Castro");
            CuentaBancaria cuenta2 = new CuentaBancaria(5678, propietario2, 500.50);

            ListaCuentasBancarias.Add(cuenta2);
            ListaCuentasBancarias.Add(cuenta1);
            

            bool parar = true;

            while (parar)
            {
                Console.WriteLine("Menuuuu" +
                "\n1. Depositar" +
                "\n2. Retirar" +
                "\n3. Mostrar saldo");

                string opcion = Console.ReadLine();

                switch (opcion) 
                {
                    case "1":
                        Depositar();
                        break;
                    case "2":
                        Retirar();
                        break;
                    case "3":
                        MostrarSaldo();
                        break;
                    case "4":
                        parar = false;
                        break;
                    default:
                        Console.WriteLine("Ingresa una opcion valida por favor"); 
                        break;
                }

            }



        }
        static void Depositar()
        {
            Console.WriteLine("Ingresa el numero de cuenta");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad que vas a depositar");
            double monto = Convert.ToInt32(Console.ReadLine());

            if (num != null && monto != null)
            {
                CuentaBancariaManejo.depositar(ListaCuentasBancarias, num, monto);
            }
            else
            {
                Console.WriteLine("Ingresa datos validos por favor");
            }
        }

        static void Retirar()
        {
            Console.WriteLine("Ingresa el numero de cuenta");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad que vas a retirar");
            double monto = Convert.ToInt32(Console.ReadLine());

            if (num != null && monto != null)
            {
                CuentaBancariaManejo.Retirar(ListaCuentasBancarias, num, monto);
            }
            else
            {
                Console.WriteLine("Ingresa datos validos por favor");
            }
        }

        static void MostrarSaldo()
        {
            Console.WriteLine("Ingresa el numero de cuenta");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num != null )
            {
                CuentaBancariaManejo.MostrarSaldo(ListaCuentasBancarias, num);
            }
            else
            {
                Console.WriteLine("Ingresa datos validos por favor");
            }
        }
    }
}

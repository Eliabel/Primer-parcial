using System;

namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, f;
            double t;
            Console.WriteLine("Digite el precio del producto que desea comprar: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("### Ahora ingrese el metodo de pago deseado #### \n EFECTIVO [1]      TARJETA[2] ");
            f = Convert.ToInt32(Console.ReadLine());
            switch (f)
            {
                case 1: Console.WriteLine("Gracias por su compra, su factura es de $" + p);
                        break;
                case 2:
                    Console.WriteLine("Ingrese los 12 digitos de su tarjeta: ");
                    t=Convert.ToDouble(Console.ReadLine());
                    if (t > 99999999999) {
                    
                        Console.WriteLine("Su pago se a efectuado correctamente, su factura es de $"+p+" Gracias por su compra.");

                    }
                    else
                    {
                        Console.WriteLine("Hubo un error con los datos de su tarjeta, ingrese de nuevo a la aplicacion y intentelo nuevamente. ");

                    }
                    break;
            }


        }
    }
}

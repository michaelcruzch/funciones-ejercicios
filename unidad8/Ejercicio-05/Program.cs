using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
            //de pagos (entero) y devuelva el monto de cada pago. Hacer un programa para
            //ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
            //El programa deberá mostrar la cantidad de pagos y el monto del pago para
            //cada una de las ventas.

            float monto, montoCuota;
            int cp;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese el monto:");
                monto = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de pagos:");
                cp = int.Parse(Console.ReadLine());

                montoCuota = pagos(monto, cp);

                Console.WriteLine("La cantidad de pago es : " + cp);
                Console.WriteLine("El monto de la cuota pagos es " + montoCuota);
            }


        }
        static float pagos(float m, int p){
            float cp;

            cp = m / p;
            return cp;
        }


    }
}

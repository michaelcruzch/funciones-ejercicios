using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que
            //devuelva el producto de ambos. Luego hacer un programa que pida el precio
            //de un artículo y la cantidad vendida y muestre por pantalla el monto total a
            //pagar. Usar la función.

            int precioProducto, cantidadVendidad, totalPagar;

            Console.WriteLine("Ingrese el precio del producto:");
            precioProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantidadVendidad = int.Parse(Console.ReadLine());
            
            totalPagar = producto(precioProducto, cantidadVendidad);

            Console.WriteLine("Total a pagar es: " + totalPagar);



        }

        static int producto(int a, int b){
            int r;
            r = a * b;
            return r;
        }
    }
}

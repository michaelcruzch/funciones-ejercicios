using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función que se llame “sumaResta” que reciba dos números y que
            //devuelva la suma Y la resta del primer número con el segundo.
            //Nota: recordemos que una función solo puede devolver UN valor por return.
            //Cómo podríamos hacer para tener ambos resultados en el main?

            int a, b, suma;

            Console.WriteLine("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());

            suma = sumaResta(a, ref b);
            
            Console.WriteLine("la suma es " + suma);
            Console.WriteLine("la resta del primer numero con el segundo numero es: " + b);



        }
        static int sumaResta(int primerNumero, ref int segundoNumero){
            int suma;

            suma = primerNumero + segundoNumero;

            segundoNumero = primerNumero - segundoNumero;

            return suma;
        }
    }
}

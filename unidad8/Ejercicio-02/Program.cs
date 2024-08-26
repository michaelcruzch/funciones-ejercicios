using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “mayor” que reciba dos números enteros y
            //devuelva el mayor de ellos o cero si son iguales.

            int n1, n2, respuesta;


            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            respuesta = mayor(n1, n2);

            Console.WriteLine("La respuesta de los dos numeros ingresados es: " + respuesta);      

        }

        static int mayor(int a, int b){
            if(a == b)
                return 0;
            if(a > b)
                return a;
            else    
                return b;
        }
    }
}

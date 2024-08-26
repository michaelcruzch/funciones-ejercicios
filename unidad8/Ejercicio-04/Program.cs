using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1
            //si el número es primo o cero si no lo es. Hacer un programa para ingresar
            //números. El lote corta cuando se ingresa un número cero. Informar el
            //promedio teniendo en cuenta sólo los números primos.

            int a, conPrimos = 0, acuPrimos = 0, promedio;
        

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
            
                if(primo(a)){
                    conPrimos++;
                    acuPrimos+=a;
                }

                Console.WriteLine("Ingrese un numero:");
                a = int.Parse(Console.ReadLine());
            }
            promedio = acuPrimos / conPrimos;
            Console.WriteLine("El promedio de los numeros primos es: " + promedio);


        }
        static bool primo(int n){
            int con = 0;
            for (int x = 1; x < n; x++)
            {
                if(n % x == 0)
                    con++;
            }
            if(con == 2)
                return true;
            else
                return false;
        }


    }
}

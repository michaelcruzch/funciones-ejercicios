using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta
            //cuando se ingresa un cero. A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.
            //Hacer uso de las funciones anteriormente desarrolladas.

            int n, banMinPrimos = 0, bMaxPar = 0, conImpar = 0, maxPar = 0, minPrimo = 0;
            bool bp, pri;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                bp = par(n);

                if(bp){
                    if(bMaxPar == 0){
                        maxPar = n;
                        bMaxPar = 1;
                    }else if(n > maxPar)
                        maxPar = n;
                }else
                    conImpar++;


                pri = primo(n);

                if(pri)
                    if(banMinPrimos == 0){
                        minPrimo = n;
                        banMinPrimos = 1;
                    }else if(n < minPrimo)
                        minPrimo = n;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("el mayor de los numeros pares es : " + maxPar);
            Console.WriteLine("la cantidad de numeros impares es: " + conImpar);
            Console.WriteLine("el menor de los numeros primos es " + minPrimo);

            
        }
        static bool par(int n){
            if(n % 2 == 0)
                return true;
            else   
                return false;
        }
        static bool primo(int n){
            int con = 0;
            for (int x = 1; x <= n; x++)
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

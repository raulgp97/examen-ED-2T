using System;

/************************************
 * Autor: Raúl González Parra
 * Curso: 1DAM-T
 * Asignación: Ejercicio con estructuras de control.
 * Fecha Asignación: 12 de Febrero de 2020
 * **********************************/

namespace ejercicioEstructurasControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int cuentaPares = 0;
            int limitador;
            int numeros;
            String numerosPares = "";
            int multiplicacion = 1;

            //Lee los números que se hayan introducido por teclado.
            Console.WriteLine("Introduce una cantidad de numeros: ");
            limitador = Convert.ToInt32(Console.ReadLine());

            while (contador != limitador)
            {

                //Lee los números que se estén introduciendo por teclado.
                Console.WriteLine("Introduce un numero: ");
                numeros = Convert.ToInt32(Console.ReadLine());

                //Comprueba sí el número introducido es par o impar.
                if (numeros % 2 == 0)
                {

                    Console.WriteLine("Este es un número par: " + numeros);
                    cuentaPares += 1;

                }
                
                contador++;
            }
            //Multiplica los números pares.
            for (int i = 1; i <= cuentaPares; i++)
            {
                
                numerosPares += Convert.ToString(i * 2) + " * ";
                multiplicacion *= i * 2;
                contador++;
            }
            //Imprime los números pares introducidos.
            Console.WriteLine("Has introducido " + cuentaPares + " números pares");
            //Imprime cuántos números pares se han contado en total.
            Console.WriteLine("El producto de los primeros " + cuentaPares + " números pares es el siguiente: ");
            //Imprime los números pares que se han multiplicado y el resultado de dicha multiplicación.
            Console.WriteLine(numerosPares + " es igual a: " + multiplicacion);
            //Suspende la pantalla.
            Console.ReadKey();
        }
    }
}

using System;

/************************************
 * Autor: Raúl González Parra
 * Curso: 1DAM-T
 * Asignación: Ejercicio de condiciones compuestas
 * Fecha Asignación: 5 de Febrero de 2020
 * **********************************/

namespace ejercicioCondicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;

           //Lee los meses introducidos por teclado.
           Console.WriteLine("Introduce las tres primeras letras del mes: ");
           mes = Console.ReadLine().ToLower();

            /*Comprueba si las tres primeras letras de los meses corresponden con las tres primeras letras de los 
            meses que pertenecen al segundo trimestre.*/
            if (mes.Equals("ene") || mes.Equals("feb") || mes.Equals("mar"))
            {

                Console.WriteLine("Este es el segundo trimestre");

            }
            else
            {
                Console.WriteLine("Este no es el segundo trimestre");

            }

            //Suspende la pantalla.
            Console.ReadKey();
        }
    }
}

using System;

/************************************
 * Autor: Raúl González Parra
 * Curso: 1DAM-T
 * Asignación: Pintar la consola de colores
 * Fecha Asignación: 4 de Marzo de 2020
 * **********************************/

namespace PintarConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Parte 1
            int fila;
            int columna;

            Random filaAleatoria = new Random();
            Random columnaAleatoria = new Random();

            //Parte 2
            char[] caracteres = { '$', '@', '%', '#' };

            Random indiceAleatorio = new Random();

            //Parte 3
            ConsoleColor[] colores = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));//Colores de la consola.

            Random indiceColorCaracter = new Random();

            Random indiceColorFondo = new Random();

            ConsoleColor colorCaracter;//Color del caracter.

            ConsoleColor colorFondo;//Color de fondo del caracter.

            int contador = 0;

            //Situa los carácteres de forma aleatoria y pinta los caracteres de forma aleatoria. 

            while (contador != 3000)
            {
                
                fila = filaAleatoria.Next(24);
                columna = columnaAleatoria.Next(80);
                
                Console.SetCursorPosition(columna, fila);
                
                colorCaracter = colores[indiceColorCaracter.Next(14)];

                colorFondo = colores[indiceColorFondo.Next(14)];
               
                Console.ForegroundColor = colorCaracter;

                Console.BackgroundColor = colorFondo;
                
                Console.WriteLine(caracteres[indiceAleatorio.Next(4)]);
               
                contador++;
            }
            //Resetea el color de la consola.
            Console.ResetColor();
            //Posiciona el cursor en la ultima posición de la consola.
            Console.SetCursorPosition(1, 24);
            //Suspende la pantalla.
            Console.ReadKey();

        }
    }
}

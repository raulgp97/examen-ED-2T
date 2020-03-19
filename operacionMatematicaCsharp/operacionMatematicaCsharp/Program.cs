using System;

/************************************
 * Autor: Raúl González Parra
 * Curso: 1DAM-T
 * Asignación: Operación Matemática en Csharp
 * Fecha Asignación: 19 de Febrero de 2020
 * **********************************/

namespace operacionMatematicaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String numeroA;
            String numeroB; 
            String operador;

            double convertidoA;
            double convertidoB = 0;
            double resultado = 0;

            //Lee el primer valor.
            Console.WriteLine("Introduce el primer operando: ");
            numeroA = Console.ReadLine();

            //Lee el operador.
            Console.WriteLine("Introduce el operador: ");
            operador = Console.ReadLine();

            //Lee el segundo valor.
            Console.WriteLine("Introduce el segundo operando: ");
            numeroB = Console.ReadLine();

            //Comprueba si los valores introducidos son números.
            if (!(Double.TryParse(numeroA, out convertidoA) && Double.TryParse(numeroB, out convertidoB)))
            {
                Console.WriteLine("Uno de los dos operandos es no númerico o los dos operandos no son númericos.");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            /*Realiza todas las operaciones matemáticas básicas(sumar, restar, multiplicar, dividir, modulo) y 
            también realiza las comprobaciones necesarias.*/
            switch (operador)
            {
                
                case "+":

                    resultado = convertidoA + convertidoB;

                    break;
                
                case "-":

                    resultado = convertidoA - convertidoB;

                    break;
                
                case "*":
                case "x":

                    resultado = convertidoA * convertidoB;

                    break;
                
                case "/":

                    if (convertidoB != 0)
                    {

                        resultado = convertidoA / convertidoB;
                    }
                    else
                    {
                        Console.WriteLine("El segundo operando no puede ser un cero.");
                        Console.ReadKey();
                        System.Environment.Exit(2);

                    }

                    break;
                
                case "%":

                    if (convertidoB != 0)
                    {

                        resultado = convertidoA % convertidoB;
                    }
                    else
                    {
                        Console.WriteLine("El segundo operando no puede ser un cero.");
                        Console.ReadKey();
                        System.Environment.Exit(2);

                    }

                    break;
                //Imprime un mensaje, en caso de que no hayas introducido el operador correcto.
                default:

                    Console.WriteLine("No has introducido el operador correcto.");
                    Console.ReadKey();
                    System.Environment.Exit(3);

                    break;
            }
            //Imprime los números que se han utilizado para realizar la operación y el resultado de la operación.
            Console.WriteLine("El resultado de " + Convert.ToString(convertidoA) + operador + Convert.ToString(convertidoB) + " es: " + Convert.ToString(resultado));
            //Suspende la pantalla.
            Console.ReadKey();
        }
    }
}

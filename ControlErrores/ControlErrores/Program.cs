using System;
using System.IO;

/************************************
 * Autor: Raúl González Parra
 * Curso: 1DAM-T
 * Asignación: TryCatch Finally con ficheros
 * Fecha Asignación: 4 de Marzo de 2020
 * **********************************/

namespace ControlErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = null;

            try
            {
                //Lee el fichero y lo imprime linea por linea.
                file = new System.IO.StreamReader(@"./datos.txt");
                while ((line = file.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                    counter++;
                }
            }
            //Imprimen mensajes de error, según la excepción que se capture.
            catch(FileNotFoundException f)
            {
                
                Console.WriteLine(f);

            }
            catch (Exception e)
            {
               
                Console.WriteLine(e);
            }
            //En caso de error o no, cierra el fichero para que no se quede abierto.
            finally
            {
               
               file.Close();
                
            }
            //Imprime las lineas que se han leído.
            System.Console.WriteLine("There were {0} lines.", counter);
            //Suspende la pantalla.
            System.Console.ReadLine();
        }
    }
}

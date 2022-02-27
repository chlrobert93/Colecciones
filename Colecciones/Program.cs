using System;
using System.Collections;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz de cadena
            string[] nombres = new string[2] { "Eder", "Eder" };

            //e.MoveNext //En caso de que la colección contenga un elemento es true
            //e.current //Ver el valor actual de nuestro enumerador
            //IEnumerator Los enumeradores se pueden usar para leer los datos de la colección, pero no se pueden usar para modificar la colección subyacente.

            for (IEnumerator e = nombres.GetEnumerator(); e.MoveNext(); Console.WriteLine(e.Current)) ;




            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();


        }
    }
}

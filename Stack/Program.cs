using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la oracion gramatical original que desee invertir: ");
            string palabra = Console.ReadLine();
            string[] separar = palabra.Split(' ');
            Stack<string> ordenPila = new Stack<string>(separar);
            Console.WriteLine("");

            Console.Write("La oracion gramatical invertida es: ");

            for (int i = 0; i < separar.Length; i++)
            {
                Console.Write($"{ordenPila.Pop()} ");
            }
            Console.WriteLine("");
        }
    }
}

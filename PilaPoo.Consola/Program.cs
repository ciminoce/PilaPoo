using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PilaPoo.Entidades;

namespace PilaPoo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stacks!");
            var libro1 = new Libro() { Nombre = "El Sol Desnudo", Autor = "Isaac Asimov" };

            var arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("Arreglo");
            arraylist.Add(libro1);


            var pila = new Stack<Libro>();
            var libro2 = new Libro() { Nombre = "Planeta de Exilio", Autor = "Usula Le Guin" };
            var libro3 = new Libro() { Nombre = "Yo, Robot", Autor = "Isaac Asimov" };

            pila.Push(libro1);
            pila.Push(libro2);
            pila.Push(libro3);

            foreach (var libro in pila)
            {
                Console.WriteLine($"{libro.ToString()}");
            }

            do
            {
                Console.WriteLine($"Próximo libro:{pila.Peek().ToString()}");
                Thread.Sleep(3000);
                Console.WriteLine($"Leyendo a {pila.Peek().ToString()}");
                pila.Pop();
            } while (pila.Count > 0);

        }
    }
}

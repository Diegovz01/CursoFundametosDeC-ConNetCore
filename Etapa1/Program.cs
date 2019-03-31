using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");

            ImprimirCursosEscuela(engine.Escuela);
        }
        // cw => Atajo, Escribir Console.WriteLine
        // control + . => Generar Metodo
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            // alt + shift + mouse => Multiples punteros
            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela.Cursos != null && escuela != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }
}

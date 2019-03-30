using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota",
                                        pais: "Colombia"); // control + . => Ayuda CONSTRUCTOR

            escuela.Cursos = new Curso[] {
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "102"},
                new Curso(){ Nombre = "103"}
            };
            // cw => Atajo, Escribir Console.WriteLine
            // control + . => Generar Metodo

            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            // alt + shift + mouse => Multiples punteros
            WriteLine("==========================");
            WriteLine("Cursos de la Escueal");
            WriteLine("==========================");

            if (escuela.Cursos != null && escuela != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                System.Console.WriteLine($"Nombre {arregloCursos[contador].Nombre }, Id {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                System.Console.WriteLine($"Nombre {arregloCursos[contador].Nombre }, Id {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                System.Console.WriteLine($"Nombre {arregloCursos[i].Nombre }, Id {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                System.Console.WriteLine($"Nombre {curso.Nombre }, Id {curso.UniqueId}");
            }
        }
    }
}

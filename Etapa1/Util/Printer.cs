namespace CoreEscuela.Util
{
    public static class Printer // Shortcut class
    {
        // static
        //no permite crear nuevas instancias
        //si usar sus funciones 
        public static void DibujarLinea(int tam = 10)
        {
            System.Console.WriteLine("".PadLeft(tam, '='));
        }
        public static void WriteTitle(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            System.Console.WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
    }
}
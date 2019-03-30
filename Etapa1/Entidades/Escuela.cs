namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {   // Cuando alguien pregunte por el nombre.
            get { return "Copia: " + nombre; } // return - lo que va a devolver - la variable nombre.  
            set { nombre = value.ToUpper(); }// Asignar un valor a esta propiedad, se asigna nombre a value.
        } // value - palabra clave

        // ToUpper(); => Convert to Mayus
        // shift + alt + f => Format Document

        public int AñoDeCreacion { get; set; } // prop - atajo para crear una propiedad.
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }

        // Todo objeto para que se pueda crear.
        // Cuenta con el método Constructor.
        // El constructor es un metodo que.
        // Nos ayuda a crear una instancia del objeto.

        /* METODO CONSTRUCTOR
        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñoDeCreacion = año;
        }*/

        // Atajo, escribirlo de manera mas corta:
        // Igualación por tuplas
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
        // Palabra calve 'override' -> Sobrescribir
        //Método ToString();
    }
}
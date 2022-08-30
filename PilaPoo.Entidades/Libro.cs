using System;

namespace PilaPoo.Entidades
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public override string ToString()
        {
            return $"{Nombre} - {Autor}";
        }
    }
}

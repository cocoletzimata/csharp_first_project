using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2019);
            escuela.Pais = "Mexico";
            escuela.Ciudad = "Queretaro";
            Console.WriteLine(escuela.Nombre);
        }
    }
}

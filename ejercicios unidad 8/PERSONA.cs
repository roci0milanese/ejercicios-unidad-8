using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Direccion Direccion { get; set; } 

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            if (Direccion != null)
            {
                Direccion.MostrarDireccion();
            }
            else
            {
                Console.WriteLine("Sin dirección");
            }
        }
    }
}


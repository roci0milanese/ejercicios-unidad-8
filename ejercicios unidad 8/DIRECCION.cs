using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    internal class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Ciudad { get; set; }

        public void MostrarDireccion()
        {
            Console.WriteLine($"Dirección: {Calle} {Numero} {Ciudad}");
        }
    }
}


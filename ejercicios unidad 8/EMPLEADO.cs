using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    abstract class Empleado
        {
            public string Nombre { get; set; }
            public abstract double CalcularSueldo();
        }
}


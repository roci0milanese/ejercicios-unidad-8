using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    
    class EmpleadoPermanente : Empleado
    {
        public double SueldoBase { get; set; }

        public override double CalcularSueldo()
        {
            return SueldoBase + 10000;
        }
    }
}

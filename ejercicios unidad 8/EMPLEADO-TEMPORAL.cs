using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    class EmpleadoTemporal : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double PagoPorHora { get; set; }

        public override double CalcularSueldo()
        {
            return HorasTrabajadas * PagoPorHora;
        }
    }
}
    

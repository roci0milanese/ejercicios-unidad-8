using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    internal class Class1
    {
        internal class Perro : Animal
        {
            public override void HacerSonido()
            {
                Console.WriteLine("Guau guau!");
            }
        }
    }
}

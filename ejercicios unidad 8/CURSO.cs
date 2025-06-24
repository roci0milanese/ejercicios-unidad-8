using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_unidad_8
{
    internal class Curso
    {
        private List<Alumno> alumnos;

        public Curso()
        {
            alumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void MostrarNombres()
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.Nombre);
            }
        }
    }
}


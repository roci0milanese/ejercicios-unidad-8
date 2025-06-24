using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejercicios_unidad_8.Class1;

namespace ejercicios_unidad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();

            animales.Add(new Perro());
            animales.Add(new Vaca());

     
            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }

            Direccion direccion = new Direccion
            {
                Calle = "Av.Belgrano",
                Numero = 742,
                Ciudad = "Sunchales"
            };

            Persona persona = new Persona
            {
                Nombre = "Rocio Milanese",
                Edad = 21,
                Direccion = direccion
            };

           persona.MostrarDatos();

            EmpleadoPermanente emp1 = new EmpleadoPermanente
            {
                Nombre = "Ana",
                SueldoBase = 50000
            };

            EmpleadoTemporal emp2 = new EmpleadoTemporal
            {
                Nombre = "Luis",
                HorasTrabajadas = 120,
                PagoPorHora = 400
            };

            Console.WriteLine("Empleado: " + emp1.Nombre);
            Console.WriteLine("Sueldo: " + emp1.CalcularSueldo());
            Console.WriteLine("Empleado: " + emp2.Nombre);
            Console.WriteLine("Sueldo: " + emp2.CalcularSueldo());

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Auto());
            vehiculos.Add(new Bicicleta());

            foreach (Vehiculo v in vehiculos)
            {
                v.Conducir();
            }

            Curso curso = new Curso();
            curso.AgregarAlumno(new Alumno("Juan"));
            curso.AgregarAlumno(new Alumno("Lucía"));
            curso.AgregarAlumno(new Alumno("Pedro"));

            curso.MostrarNombres();
        }
    }
}
    

using System;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            IComparable a = FabricaDeAlumno.crearAleatorio(2);
            Student s = new AdaptadorAlumno((Alumno)a);
            t.goToClass(s);
            t.teachingAClass();

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

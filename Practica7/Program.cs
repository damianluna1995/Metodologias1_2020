using System;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher(); 
            IComparable a = (AlumnoProxy)FabricaDeComparables.crearAleatorio(5); //opcion proxy
            Student s = new AdaptadorAlumno((IAlumno)a);
            t.goToClass(s);
            t.teachingAClass();

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

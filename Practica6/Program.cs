using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- Ejercicio 2 ----- (Ejercicio 2, Practica 5 ; Ejercicio 8, Practica 4) 
            /*Teacher teacher = new Teacher();
        
            IAlumno alumnoComp = (AlumnoComposite)FabricaDeComparables.crearAleatorio(6);
            IAlumno alumnoComp2 = (AlumnoComposite)FabricaDeComparables.crearAleatorio(6);

			Student s1 = new AdaptadorAlumno(alumnoComp);
			Student s2 = new AdaptadorAlumno(alumnoComp2);

			teacher.goToClass(s1);
			teacher.goToClass(s2);

			teacher.teachingAClass();*/
			
			//----- Ejercicio 4 -----
			Persona p = new Persona("qwert",123);
			Persona p1 = new Persona("sdad",454);
			Persona p3 = new Persona("aaaaaa",45453);
			Persona p4 = new Persona("zxcas",45544);

			JuegoDeCartas juego1 = new SumandoCartas();
			Console.WriteLine("El ganador es: " + juego1.jugar(p,p1));

			Console.WriteLine("");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("");

			JuegoDeCartas juego2 = new ContandoCartasPares();
 			Console.WriteLine("El ganador es: " + juego2.jugar(p3,p4));


            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }

    }

}

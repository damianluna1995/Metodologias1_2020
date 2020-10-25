using System;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- Ejercicio 1 ----- 
            /*Teacher t = new Teacher();
            IAlumno a = new AlumnoProxy(2,"qwerty",123);
            IAlumno a1 = new AlumnoProxy(4,"asdfg",456);
            Student s = new AdaptadorAlumno(a);
            Student s1 = new AdaptadorAlumno(a1);
            t.goToClass(s);
            t.goToClass(s1);
            t.teachingAClass();*/

            
            //----- Ejercicio 2 ----- (Ejercicio 8, Practica 4) 
            /*Teacher teacher = new Teacher();
            GeneradorDeDatosAleatorios g = new GeneradorDeDatosAleatorios();
    
			for (int i = 1; i <= 10; i++) {
				IAlumno alumno = new AlumnoProxy(2, g.stringAleatorio(5), g.numeroAleatorio(1000));
				IAlumno decorado = new DecNotaEnLetras(alumno);
				decorado = new DecNotaConLegajo(decorado);
				decorado = new DecCondicionMateria(decorado);
				decorado = new DecNotaEnRecuadro(decorado);
			    Student student = new AdaptadorAlumno(decorado);
			    teacher.goToClass(student);
			}
			for (int i = 1; i <= 10; i++) {
				IAlumno alumMuyEstudioso = new AlumnoProxy(4, g.stringAleatorio(5), g.numeroAleatorio(1000));
				IAlumno decorado = new DecNotaEnLetras(alumMuyEstudioso);
				decorado = new DecNotaConLegajo(decorado);
				decorado = new DecCondicionMateria(decorado);
				decorado = new DecNotaEnRecuadro(decorado);
				Student student2 = new AdaptadorAlumno(decorado);
				teacher.goToClass(student2);
			}
			teacher.teachingAClass();*/
			
			//----- Ejercicio 10 -----
			Pila p = new Pila();
			Aula a = new Aula();
			a.Comenzar();
			p.setOrdenInicio(new OrdenInicio(a));
			p.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
			p.setOrdenAulaLlena(new OrdenAulaLlena(a));
			Llenar(p,2);
			Llenar(p,4);

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }

        //----- Ejercicio 6, Practica 3-----
		public static void Llenar(IColeccionable coleccionable, int opcion){

			int cantVeces = 0;
			
			while (cantVeces < 20){
				IComparable alumno = FabricaDeComparables.crearAleatorio(opcion);
				coleccionable.Agregar(alumno);
				cantVeces ++;
			}

		}

    }

}

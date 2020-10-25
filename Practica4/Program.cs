using System;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			//----- Ejercicio 4 -----
			/*Teacher teacher = new Teacher();
			for (int i = 1; i <= 10; i++) {
				IComparable comparable = FabricaDeComparables.crearAleatorio(2);
			    Student student = new AdaptadorAlumno((Alumno)comparable);
			    teacher.goToClass(student);
			}
			for (int i = 1; i <= 10; i++) {
				IComparable comparable = FabricaDeComparables.crearAleatorio(4);
				Student student2 = new AdaptadorAlumno((AlumnoMuyEstudioso)comparable);
				teacher.goToClass(student2);
			}
			teacher.teachingAClass();*/
			
			//----- Ejercicio 7 -----
			/*Teacher t = new Teacher();
			IAlumno a = (AlumnoMuyEstudioso)FabricaDeAlumno.crearAleatorio(4);
			IAlumno decorado = new DecNotaEnLetras(a);
			decorado = new DecNotaConLegajo(decorado);
			decorado = new DecCondicionMateria(decorado);
			decorado = new DecNotaEnRecuadro(decorado);
			Student s = new AdaptadorAlumno(decorado);
			t.goToClass(s);
			t.teachingAClass();*/


			//----- Ejercicio 8 -----
			Teacher teacher = new Teacher();
			for (int i = 1; i <= 10; i++) {
				IAlumno alumno = (Alumno)FabricaDeAlumno.crearAleatorio(2);
				IAlumno decorado = new DecNotaEnLetras(alumno);
				decorado = new DecNotaConLegajo(decorado);
				decorado = new DecCondicionMateria(decorado);
				decorado = new DecNotaEnRecuadro(decorado);
			    Student student = new AdaptadorAlumno(decorado);
			    teacher.goToClass(student);
			}
			for (int i = 1; i <= 10; i++) {
				IAlumno alumMuyEstudioso = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
				IAlumno decorado = new DecNotaEnLetras(alumMuyEstudioso);
				decorado = new DecNotaConLegajo(decorado);
				decorado = new DecCondicionMateria(decorado);
				decorado = new DecNotaEnRecuadro(decorado);
				Student student2 = new AdaptadorAlumno(decorado);
				teacher.goToClass(student2);
			}
			teacher.teachingAClass();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

	}

}

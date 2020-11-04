using System;

namespace Practica7
{
    public class Aula
    {
        Teacher teacher;

        public void Comenzar(){
            teacher = new Teacher();
            Console.WriteLine("Comienzo de la clase...");
        }

       public void nuevoAlumno(IComparable alumno){
           Student s = new AdaptadorAlumno((IAlumno)alumno);
           teacher.goToClass(s);
           Console.WriteLine("Llego el alumno: " + s.getName());
       }

       public void ClaseLista(){
            Console.WriteLine("El aula esta llena...");
            teacher.teachingAClass();
       }

    }

}
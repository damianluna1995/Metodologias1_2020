using System;

namespace Practica6
{
    class Aula
    {
        Teacher teacher;

        public void Comenzar(){
            teacher = new Teacher();
            Console.WriteLine("Comienzo de la clase...");
        }

       public void nuevoAlumno(IAlumno alumno){
           Student s = new AdaptadorAlumno((Alumno)alumno);
           teacher.goToClass(s);
       }

       public void ClaseLista(){
            teacher.teachingAClass();
       }

    }

}
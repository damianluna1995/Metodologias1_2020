using System;

namespace Practica6
{
    class OrdenLlegaAlumno: IOrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula a){
            this.aula = a;
        }

        public void Ejecutar(IComparable comparable){
            //aula.nuevoAlumno(new AdaptadorAlumno((IAlumno)comparable));
        }
        
    }

}
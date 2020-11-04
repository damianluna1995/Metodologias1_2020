using System;

namespace Practica7
{
    public class OrdenLlegaAlumno: IOrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula a){
            this.aula = a;
        }

        public void Ejecutar(IComparable comparable){
            aula.nuevoAlumno(comparable);
        }
        
    }

}
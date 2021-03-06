using System;

namespace Practica7
{
    public class EstrategiaPorNombre: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getNombre().CompareTo(((IAlumno)comparable2).getNombre()) == 0;
        }

        //Retorna true si comparable1 es menor a la cantidad de letras a comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getNombre().CompareTo(((IAlumno)comparable2).getNombre()) == -1;
        }

        //Retorna true si comparable1 es mayor a la cantidad de letras a comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getNombre().CompareTo(((IAlumno)comparable2).getNombre()) == 1;
        }
        
    }
    
}
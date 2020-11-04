using System;

namespace Practica6
{
    class EstrategiaPorPromedio: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getPromedio() == ((IAlumno)comparable2).getPromedio();
        }

        //Retorna true si comparable1 es menor a el promedio de comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getPromedio() < ((IAlumno)comparable2).getPromedio();
        }

        //Retorna true si comparable1 es mayor a el promedio de comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getPromedio() > ((IAlumno)comparable2).getPromedio();
        }
        
    }
    
}
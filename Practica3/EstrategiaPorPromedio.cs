using System;

namespace Practica3
{
    class EstrategiaPorPromedio: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getPromedio() == ((Alumno)comparable2).getPromedio();
        }

        //Retorna true si comparable1 es menor a el promedio de comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getPromedio() < ((Alumno)comparable2).getPromedio();
        }

        //Retorna true si comparable1 es mayor a el promedio de comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getPromedio() > ((Alumno)comparable2).getPromedio();
        }
        
    }
    
}
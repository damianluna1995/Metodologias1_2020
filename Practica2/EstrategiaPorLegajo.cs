using System;

namespace Practica2
{
    class EstrategiaPorLegajo: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getLegajo() == ((Alumno)comparable2).getLegajo();
        }

        //Retorna true si comparable1 es menor a el legajo de comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getLegajo() < ((Alumno)comparable2).getLegajo();
        }

        //Retorna true si comparable1 es mayor a el legajo de comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((Alumno)comparable1).getLegajo() > ((Alumno)comparable2).getLegajo();
        }
        
    }
    
}
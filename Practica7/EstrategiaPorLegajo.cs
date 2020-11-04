using System;

namespace Practica7
{
    public class EstrategiaPorLegajo: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getLegajo() == ((IAlumno)comparable2).getLegajo();
        }

        //Retorna true si comparable1 es menor a el legajo de comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getLegajo() < ((IAlumno)comparable2).getLegajo();
        }

        //Retorna true si comparable1 es mayor a el legajo de comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getLegajo() > ((IAlumno)comparable2).getLegajo();
        }
        
    }
    
}
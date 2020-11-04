using System;

namespace Practica7
{
    public class EstrategiaPorDNI: EstrategiaDeComparacionAbstracta
    {   
        public override bool SosIgual(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getDNI() == ((IAlumno)comparable2).getDNI();
        }

        //Retorna true si comparable1 es menor al DNI de comparable2
        public override bool SosMenor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getDNI() < ((IAlumno)comparable2).getDNI();
        }

        //Retorna true si comparable1 es mayor al DNI de comparable2
        public override bool SosMayor(IComparable comparable1, IComparable comparable2){
            return ((IAlumno)comparable1).getDNI() > ((IAlumno)comparable2).getDNI();
        }
        
    }

}
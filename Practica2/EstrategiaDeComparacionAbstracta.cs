using System;

namespace Practica2
{
    public abstract class EstrategiaDeComparacionAbstracta: IEstrategiaDeComparacion{
        
        public abstract bool SosIgual(IComparable comparable1, IComparable comparable2);
        public abstract bool SosMenor(IComparable comparable1, IComparable comparable2);
        public abstract bool SosMayor(IComparable comparable1, IComparable comparable2);

    }

}
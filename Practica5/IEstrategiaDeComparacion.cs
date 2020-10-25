using System;

namespace Practica5
{
    public interface IEstrategiaDeComparacion{
        
        bool SosIgual(IComparable comparable1, IComparable comparable2);
        bool SosMenor(IComparable comparable1, IComparable comparable2);
        bool SosMayor(IComparable comparable1, IComparable comparable2);

    }
    
}
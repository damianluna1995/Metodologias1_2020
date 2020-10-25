using System;

namespace Practica7
{
    public interface IComparable
    {
        bool SosIgual(IComparable comparable);
        bool SosMenor(IComparable comparable);
        bool SosMayor(IComparable comparable);
        
    }

}
using System;

namespace Practica1
{
    public interface IComparable
    {
        bool SosIgual(IComparable comparable);
        bool SosMenor(IComparable comparable);
        bool SosMayor(IComparable comparable);
        
    }

}
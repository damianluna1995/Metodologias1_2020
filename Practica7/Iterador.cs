using System;

namespace Practica7
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();

    }
    
}
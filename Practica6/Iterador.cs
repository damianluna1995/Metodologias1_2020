using System;

namespace Practica6
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();

    }
    
}
using System;

namespace Practica2
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();

    }
    
}
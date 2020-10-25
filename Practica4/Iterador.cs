using System;

namespace Practica4
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        IComparable actual();

    }
    
}
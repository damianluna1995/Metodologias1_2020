using System;

namespace Practica3
{
    public interface IColeccionable
    {
        int Cuantos();
        IComparable Minimo();
        IComparable Maximo();
        void Agregar(IComparable comparable);
        bool Contiene(IComparable comparable);
        
    }

}
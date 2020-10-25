using System;

namespace Practica6
{
    public interface IObservado{

        void Notificar();
        void Agregar(IObservador observador);

    }
    
}
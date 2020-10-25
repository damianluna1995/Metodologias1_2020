using System;

namespace Practica7
{
    public interface IObservado{

        void Notificar();
        void Agregar(IObservador observador);

    }
    
}
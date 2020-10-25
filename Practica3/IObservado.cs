using System;

namespace Practica3
{
    public interface IObservado{

        void Notificar();
        void Agregar(IObservador observador);

    }
    
}
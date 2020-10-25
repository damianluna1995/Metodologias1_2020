using System;

namespace Practica5
{
    public interface IObservado{

        void Notificar();
        void Agregar(IObservador observador);

    }
    
}
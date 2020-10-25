using System;

namespace Practica4
{
    public interface IObservado{

        void Notificar();
        void Agregar(IObservador observador);

    }
    
}
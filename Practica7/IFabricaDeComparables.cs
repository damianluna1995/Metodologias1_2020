using System;

namespace Practica7
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio();
        IComparable crearPorTeclado();
    
    }
    
}
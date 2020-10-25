using System;

namespace Practica6
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio();
        IComparable crearPorTeclado();
    
    }
    
}
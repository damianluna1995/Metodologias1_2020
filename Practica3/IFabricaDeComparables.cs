using System;

namespace Practica3
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio();
        IComparable crearPorTeclado();
    
    }
    
}
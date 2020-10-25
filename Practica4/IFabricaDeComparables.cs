using System;

namespace Practica4
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio();
        IComparable crearPorTeclado();
    
    }
    
}
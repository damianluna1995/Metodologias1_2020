using System;

namespace Practica5
{
    public interface IFabricaDeComparables
    {
        IComparable crearAleatorio();
        IComparable crearPorTeclado();
    
    }
    
}
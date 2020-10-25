using System;
using System.Collections.Generic;

namespace Practica5
{
    class IteradorDePila : Iterador
    {
        List<IComparable> elementos;
        int indice = 0;

        public IteradorDePila(List<IComparable> pila){
            this.elementos = pila;
        }
        
        public void primero(){
            indice = elementos.Count - 1;
        }

        public void siguiente(){
            indice--;
        }

        public bool fin(){
            return indice < 0 ;
        }

        public IComparable actual(){
            return elementos[indice];
        }

    }

}
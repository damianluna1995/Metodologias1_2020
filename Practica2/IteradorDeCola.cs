using System;
using System.Collections.Generic;

namespace Practica2
{
    class IteradorDeCola : Iterador
    {
        List<IComparable> elementos;
        int indice = 0;

        public IteradorDeCola(List<IComparable> cola){
            this.elementos = cola;
        }
        
        public void primero(){
            indice = 0;
        }

        public void siguiente(){
            indice++;
        }

        public bool fin(){
            return indice > elementos.Count - 1;
        }

        public IComparable actual(){
            return elementos[indice];
        }

    }

}
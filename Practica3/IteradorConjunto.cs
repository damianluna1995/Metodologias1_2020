using System;
using System.Collections.Generic;

namespace Practica3
{
    class IteradorConjunto : Iterador
    {
        List<IComparable> elementos;
        int indice = 0;

        public IteradorConjunto(List<IComparable> conjunto){
            this.elementos = conjunto;
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
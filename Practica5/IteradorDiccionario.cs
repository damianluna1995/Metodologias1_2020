using System;

namespace Practica5
{
    class IteradorDiccionario : Iterador
    {
        Conjunto elementos;
        int indice = 0;

        public IteradorDiccionario(Conjunto diccionario){
            this.elementos = diccionario;
        }
        
        public void primero(){
            indice = 0;
        }

        public void siguiente(){
            indice++;
        }

        public bool fin(){
            return indice > elementos.Cuantos() - 1;
        }

        public IComparable actual(){
            return ((ClaveValor)elementos.getConjunto()[indice]).getVal();
        }

    }

}
using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica7
{
    public class ColeccionMultiple: IColeccionable
    {       
        //pila y cola de tipo Pila y Cola
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c){
            this.pila = p;
            this.cola = c;
        }

        public int Cuantos(){
            int elemPila = this.pila.Cuantos();
            int elemCola = this.cola.Cuantos();
            int totalElem = elemPila + elemCola;
            return totalElem;
        }

        public IComparable Minimo(){

            if (pila.Minimo().SosMenor(cola.Minimo()))
                return pila.Minimo();
            else
                return cola.Minimo();

        }

        public IComparable Maximo(){
            
            if (pila.Minimo().SosMayor(cola.Minimo()))
                return pila.Minimo();
            else
                return cola.Minimo();

        }

        public void Agregar(IComparable comparable){
           //por ahora no hace nada
        }

        public bool Contiene(IComparable comparable){
            return pila.Contiene(comparable) || cola.Contiene(comparable);
        }
        
    }

}
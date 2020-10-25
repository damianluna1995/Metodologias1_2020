using System;
using System.Collections.Generic;

namespace Practica4
{
    public class Pila: IColeccionable, Iterable
    {
        private List<IComparable> pila;

        public List<IComparable> getPila(){
            return this.pila;
        }

        public Pila(){
            pila = new List<IComparable>();
        }

        public int Cuantos(){
            return this.pila.Count;
        }
        
        public IComparable Minimo(){
            IComparable menor = pila[0];
            for (int i = 0; i < pila.Count; i++){
                if (menor.SosMayor(pila[i]))
                    menor = pila[i];
            }
            return menor;
        }
        
        public IComparable Maximo(){
            IComparable mayor = pila[0];
            for (int i = 0; i < pila.Count; i++){
                if (mayor.SosMenor(pila[i]))
                    mayor = pila[i];
            }
            return mayor;
        }
        
        public void Agregar(IComparable comparable){
            pila.Add(comparable);
        }
        
        public bool Contiene(IComparable comparable){
            for (int i = 0; i < pila.Count; i++)
                if (comparable.SosIgual(pila[i]))
                    return true;   

            return false;
        }
        
        public Iterador crearIterador(){
        	return new IteradorDePila(pila);
        }
        
    }

}
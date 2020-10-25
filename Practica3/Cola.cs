using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica3
{
    public class Cola: IColeccionable, Iterable
    {
        private List<IComparable> cola;

        public List<IComparable> getCola(){
            return this.cola;
        }

        public Cola(){
            cola = new List<IComparable>();
        }

        public int Cuantos(){
            return this.cola.Count;
        }

        public IComparable Minimo(){
            IComparable menor = cola[0];
            for (int i = 0; i < cola.Count; i++){
                if (menor.SosMayor(cola[i]))
                    menor = cola[i];
            }
            return menor;
        }

        public IComparable Maximo(){
            IComparable mayor = cola[0];
            for (int i = 0; i < cola.Count; i++){
                if (mayor.SosMenor(cola[i]))
                    mayor = cola[i];
            }
            return mayor;
        }
        public void Agregar(IComparable comparable){
            cola.Add(comparable);
        }
        
        public bool Contiene(IComparable comparable){
            for (int i = 0; i < cola.Count; i++)
                if (comparable.SosIgual(cola[i]))
                    return true;   

            return false;
        }
        
        public Iterador crearIterador(){
        	return new IteradorDeCola(cola);
        }
        
    }

}
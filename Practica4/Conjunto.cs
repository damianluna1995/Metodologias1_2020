using System;
using System.Collections.Generic;

namespace Practica4
{
    class Conjunto: IColeccionable, Iterable
    {
        private List<IComparable> conjunto;

        public Conjunto(){
            conjunto = new List<IComparable>();
        }

        public List<IComparable> getConjunto(){
            return this.conjunto;
        }

        public void Agregar(IComparable comparable){
            if (!Pertenece(comparable))
                conjunto.Add(comparable);    
        }

        public bool Pertenece(IComparable elemento){
            return Contiene(elemento);            
        }

        public int Cuantos(){
            return conjunto.Count;
        }

        public IComparable Minimo(){
            IComparable menor = conjunto[0];
            for (int i = 0; i < conjunto.Count; i++){
                if (menor.SosMayor(conjunto[i]))
                    menor = conjunto[i];
            }
            return menor;
        }

        public IComparable Maximo(){
            IComparable mayor = conjunto[0];
            for (int i = 0; i < conjunto.Count; i++){
                if (mayor.SosMenor(conjunto[i]))
                    mayor = conjunto[i];
            }
            return mayor;
        }

        public bool Contiene(IComparable comparable){
            for (int i = 0; i < conjunto.Count; i++)
                if (conjunto[i].SosIgual(comparable))
                    return true;

            return false;  
        }
        
        public Iterador crearIterador(){
        	return new IteradorConjunto(conjunto);
        }

    }

}
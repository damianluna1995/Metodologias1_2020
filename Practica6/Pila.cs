using System;
using System.Collections.Generic;

namespace Practica6
{
    public class Pila: IColeccionable, Iterable, IOrdenable
    {
        private List<IComparable> pila;
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;

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

            if(pila.Count == 0)
                if(ordenInicio != null)
                    ordenInicio.Ejecutar();
            
            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar(comparable);

            pila.Add(comparable);

            if (pila.Count == 40)
                if(ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
            
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

        public void setOrdenInicio(IOrdenEnAula1 orden){
            ordenInicio = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden){
            ordenAulaLlena = orden;
        }
        
        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden){
            ordenLlegaAlumno = orden;
        }

    }

}
using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica6
{
    public class Cola: IColeccionable, Iterable, IOrdenable
    {
        private List<IComparable> cola;
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;

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
            if(cola.Count == 0)
                if(ordenInicio != null)
                    ordenInicio.Ejecutar();
            
            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar(comparable);

            cola.Add(comparable);

            if (cola.Count == 40)
                if(ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
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
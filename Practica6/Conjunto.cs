using System;
using System.Collections.Generic;

namespace Practica6
{
    class Conjunto: IColeccionable, Iterable, IOrdenable
    {
        private List<IComparable> conjunto;
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;

        public Conjunto(){
            conjunto = new List<IComparable>();
        }

        public List<IComparable> getConjunto(){
            return this.conjunto;
        }

        public void Agregar(IComparable comparable){
            
            if (!Pertenece(comparable))
                conjunto.Add(comparable);
                
            if(conjunto.Count == 1)
                if(ordenInicio != null)
                    ordenInicio.Ejecutar();
            
            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar(comparable);

            if (conjunto.Count == 40)
                if(ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();   
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
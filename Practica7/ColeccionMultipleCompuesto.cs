using System;
using System.Collections.Generic;

namespace Practica7
{
    public class ColeccionMultipleCompuesto: IColeccionable
    {
        private List<IColeccionable> coleccionCompuesta = new List<IColeccionable>();

        public void agregarHijo(IColeccionable coleccionable){
            coleccionCompuesta.Add(coleccionable);
        }

        public int Cuantos(){
    
            int cantElementos = 0;
            foreach (var item in coleccionCompuesta)
            {
                cantElementos += item.Cuantos();
            }

            return cantElementos;
        }

        public IComparable Minimo(){

            IComparable min = coleccionCompuesta[0].Minimo();
            foreach (var item in coleccionCompuesta)
            {
                if (item.Minimo().SosMenor(min))
                {
                    min = item.Minimo();
                }
            }
            return min;
        }

        public IComparable Maximo(){
            
            IComparable max = coleccionCompuesta[0].Minimo();
            foreach (var item in coleccionCompuesta)
            {
                if (item.Maximo().SosMayor(max))
                {
                    max = item.Maximo();
                }
            }
            return max;

        }

        public void Agregar(IComparable comparable){
           foreach (var item in coleccionCompuesta)
           {
               item.Agregar(comparable);
           }
        }

        public bool Contiene(IComparable comparable){

            foreach (var item in coleccionCompuesta)
            {
                if (item.Contiene(comparable))
                {
                    return true;
                }
            }
            return false;
        }

    }

}
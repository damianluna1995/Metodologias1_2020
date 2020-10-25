using System;

namespace Practica7
{
    public abstract class Manejador
    {
        private Manejador siguiente;

        public Manejador(Manejador s){
            this.siguiente = s;
        }

        public Manejador(){}

        //Métodos de la clase Lector De Archivos
        public virtual double numeroDesdeArchivo(double max){
			if (this.siguiente != null)
                return siguiente.numeroDesdeArchivo(max);
            else
                return -1;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			if (this.siguiente != null)
                return siguiente.stringDesdeArchivo(cant);
            else
                return " ";
		}

        //Métodos de la clase Lector De Datos
        public virtual int numeroPorTeclado(){
            if (this.siguiente != null)
                return siguiente.numeroPorTeclado();
            else
                return -1;
        } 

        public virtual double doublePorTeclado(){
            if (this.siguiente != null)
                return siguiente.doublePorTeclado();
            else
                return -1;
        }

        public virtual string stringPorTeclado(){
            if (this.siguiente != null)
                return siguiente.stringPorTeclado();
            else
                return " ";
        }

        //Métodos de la clase Generador De Datos Aleatorios
        public virtual int numeroAleatorio(int rangoMaximo){
            if (this.siguiente != null)
                return siguiente.numeroAleatorio(rangoMaximo);
            else
                return -1;
        }

        public virtual string stringAleatorio(int cantCaracter){
            if (this.siguiente != null)
                return siguiente.stringAleatorio(cantCaracter);
            else
                return " ";
        }

    }

}
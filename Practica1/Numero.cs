using System;

namespace Practica1
{
    public class Numero: IComparable
    {
        private int valor;

        public Numero(int v){
            this.valor = v;
        }

        public int getValor(){
            return this.valor;
        }

        public void setValor(int valor){
            this.valor = valor;
        }

        public bool SosIgual(IComparable comparable){
            if (this.valor == ((Numero)comparable).getValor())
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparable comparable){
            if (this.valor < ((Numero)comparable).getValor())
                return true;
            else
                return false;
        }
        
        public bool SosMayor(IComparable comparable){
            if (this.valor > ((Numero)comparable).getValor())
                return true;
            else
                return false;
        }

        public override string ToString() {
            return this.valor.ToString();
        }

    } 

}
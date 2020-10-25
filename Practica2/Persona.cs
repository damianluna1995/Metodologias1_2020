using System;

namespace Practica2
{
    public class Persona: IComparable
    {
        protected string nombre;
        protected int dni;
        protected IEstrategiaDeComparacion estrategia;

        public Persona(string n, int d){
            this.nombre = n;
            this.dni = d;
            estrategia = new EstrategiaPorNombre();
        }

        public string getNombre(){
            return this.nombre;
        }

        public int getDNI(){
            return this.dni;
        }

        public void setNombre(string nombre){
            this.nombre = nombre;
        }

        public void setDNI(int dni){
            this.dni = dni;
        }
        
        public void setEstrategia(IEstrategiaDeComparacion e){
            this.estrategia = e;
        }

        public virtual bool SosIgual(IComparable comparable){
            if (this.dni == ((Persona)comparable).getDNI())
                return true;
            else
                return false;
        }

        public virtual bool SosMenor(IComparable comparable){
            if (this.dni < ((Persona)comparable).getDNI())
                return true;
            else
                return false;
        }

        public virtual bool SosMayor(IComparable comparable){
            if (this.dni > ((Persona)comparable).getDNI())
                return true;
            else
                return false;
        }

        public override string ToString() {
            return this.nombre.ToString() + " " + this.dni.ToString();
        }

    }

}
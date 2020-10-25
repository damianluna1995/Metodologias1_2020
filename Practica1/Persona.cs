using System;

namespace Practica1
{
    public class Persona: IComparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d){
            this.nombre = n;
            this.dni = d;
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

        public bool SosIgual(IComparable comparable){
            if (this.dni == ((Persona)comparable).getDNI())
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparable comparable){
            if (this.dni < ((Persona)comparable).getDNI())
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparable comparable){
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
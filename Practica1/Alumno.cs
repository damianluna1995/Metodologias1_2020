using System;

namespace Practica1
{
    public class Alumno: Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int l, double p): base(n,d){
            this.legajo = l;
            this.promedio = p;
        }

        public int getLegajo(){
            return this.legajo;
        }

        public double getPromedio(){
            return this.promedio;
        }

        public void setLegajo(int legajo){
            this.legajo = legajo;
        }

        public void setPromedio(int promedio){
            this.promedio = promedio;
        }

        public new bool SosIgual(IComparable comparable){
            if (this.promedio == ((Alumno)comparable).getPromedio())
                return true;
            else
                return false;
        }

        public new bool SosMenor(IComparable comparable){
            if (this.promedio < ((Alumno)comparable).getPromedio())
                return true;
            else
                return false;
        }
        
        public new bool SosMayor(IComparable comparable){
            if (this.promedio > ((Alumno)comparable).getPromedio())
                return true;
            else
                return false;
        }

        public override string ToString() {
            return base.nombre.ToString() + " " + base.dni.ToString() + " " + this.legajo.ToString() 
            + " " + this.promedio.ToString();
        }

    }
    
}
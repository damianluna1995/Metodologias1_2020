using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica3
{
    public class Alumno: Persona
    {
        private int legajo;
        private double promedio;
        
        public Alumno(string n, int d, int l, double p): base(n,d){
            this.legajo = l;
            this.promedio = p;
            estrategia = new EstrategiaPorPromedio();
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

        public void setPromedio(double promedio){
            this.promedio = promedio;
        }

        public override bool SosMenor(IComparable comparable){
            return estrategia.SosMenor(this,comparable); 
        }

        public override bool SosMayor(IComparable comparable){
            return estrategia.SosMayor(this,comparable); 
        }        

        public override bool SosIgual(IComparable comparable){
            return estrategia.SosIgual(this,comparable); 
        }

        public override string ToString() {
            return base.nombre.ToString() + " " + base.dni.ToString() + " " + this.legajo.ToString() 
            + " " + this.promedio.ToString();
        }

    }
    
}
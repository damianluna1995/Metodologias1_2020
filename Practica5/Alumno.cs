using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica5
{
    public class Alumno: Persona, IAlumno
    {
        protected int legajo;
        protected double promedio;
        protected int calificacion;
        
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
        
        public int getCalificacion(){
        	return this.calificacion;
        }

        public void setLegajo(int l){
            this.legajo = l;
        }
        
        public void setPromedio(double p){
            this.promedio = p;
        }

        public void setCalificacion(int calif){
        	this.calificacion = calif;
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
        
        public virtual int responderPregunta(int pregunta){
        	Random nroAzar = new Random();
        	return nroAzar.Next(1,3);
        }
        
        public virtual string mostrarCalificacion(){
        	return this.getNombre() + " " + this.getCalificacion();
        }

    }
    
}
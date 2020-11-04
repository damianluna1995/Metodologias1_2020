using System;
using System.Collections.Generic;

namespace Practica7
{
    public class AlumnoComposite: IAlumno
    {
        private List<IAlumno> hijos = new List<IAlumno>();

        public void agregarHijo(IAlumno a) {
            hijos.Add(a);
        }

        public int getCalificacion() {

            int calificaciones = hijos[0].getCalificacion();
            foreach(IAlumno a in hijos)
                calificaciones += a.getCalificacion();
            
            return calificaciones;
        }

        public int getDNI() {

            int dni = hijos[0].getDNI();
            foreach (IAlumno a in hijos)
                dni = dni + a.getDNI();
            
            return dni;
        }

        public int getLegajo(){

            int legajo = hijos[0].getLegajo();
            foreach (IAlumno a in hijos)
                legajo = legajo + a.getLegajo();
            
            return legajo;
        }

        public string getNombre(){

            string nombres = "";
            foreach (IAlumno a in hijos)
                nombres += a.getNombre() + ", " ;
            
            return nombres;
        }

        public double getPromedio() {

            double promedio = hijos[0].getPromedio();
            foreach (IAlumno a in hijos)
                promedio += a.getPromedio();
            
            return promedio;
        }

        public string mostrarCalificacion() {

            string cali = "";
            foreach (IAlumno a in hijos)
                cali += a.mostrarCalificacion() + ", "; 

            return cali;
        }

        public int responderPregunta(int pregunta) {

            int responder = 0;
            foreach (IAlumno a in hijos)
                responder += a.responderPregunta(pregunta);
            
            return responder;
        }

        public void setCalificacion(int nuevaCalificacion){

            foreach (IAlumno a in hijos)
                a.setCalificacion(nuevaCalificacion);
            
        }

        public void setDNI(int dni) {

            foreach (IAlumno a in hijos)
                a.setDNI(dni);
        }

        public void setLegajo(int legajo) {

            foreach (IAlumno a in hijos)
                a.setLegajo(legajo);
        }

        public void setNombre(string nombre) {

            foreach (IAlumno a in hijos)
                a.setNombre(nombre);
            
        }

        public void setPromedio(double promedio) {

            foreach (IAlumno a in hijos)
                a.setPromedio(promedio);
            
        }

        public bool SosIgual(IComparable c) {

            bool unoEsIgual = false;

            foreach (IAlumno a in hijos)
                if(a.SosIgual(c))
                    unoEsIgual = true;
                
            return unoEsIgual;
        }

        public bool SosMayor(IComparable c) {

            bool unoEsMayor = false;
            foreach (IAlumno a in hijos)
                if (a.SosMayor(c))
                    unoEsMayor = true;
            
            return unoEsMayor;
        }

        public bool SosMenor(IComparable c) {

            bool unoEsMenor = false;
            foreach (IAlumno a in hijos)
                if (a.SosMenor(c))
                    unoEsMenor = true;
                       
            return unoEsMenor;
        }

    }
               
}